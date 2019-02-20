using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Customer;
using Service.Branch;
using Definitions;

namespace AnomaERP.BackOffice.NursingHome
{
    public partial class reserve_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCustomerID.Text = "0";
                lblCustomer_relative_ID.Text = "0";
                lblCustomer_service_agreement_ID.Text = "0";
                if (Request.QueryString["customer_reserve_id"] != null)
                {
                    BranchService branchService = new BranchService();
                    BranchEntity branchEntity = new BranchEntity();
                    //Master.branchEntity.branch_id
                    branchEntity = branchService.GetDataBranchByID(1);

                    txtBranchName.Text = branchEntity.branch_name;
                    if (int.Parse(Request.QueryString["customer_reserve_id"]) > 0)
                    {
                        lblCustomerID.Text = Request.QueryString["customer_reserve_id"].ToString();
                        SetDataToUI(int.Parse(lblCustomerID.Text));
                    }
                }
            }
        }

        public void SetDataToUI(int customer_id)
        {
            CustomerService customerService = new CustomerService();
            CustomerEntity customerEntity = new CustomerEntity();

            customerEntity = customerService.GetDataByID(customer_id);

            

            if (customerEntity.contract_start != default(DateTime))
            {
                txtContractStart.Text = customerEntity.contract_start.ToString("yyyy-MM-dd");
            }

            if (customerEntity.contract_end != default(DateTime))
            {
                txtContractEnd.Text = customerEntity.contract_end.ToString("yyyy-MM-dd");
            }

            txtFirstname.Text = customerEntity.firstname.ToString();
            txtLastname.Text = customerEntity.lastname.ToString();
            ddlGender.SelectedValue = customerEntity.gender;

            if (customerEntity.DOB != default(DateTime))
            {
                txtDOB.Text = customerEntity.DOB.ToString("yyyy-MM-dd");
            }

            lblCustomer_relative_ID.Text = customerEntity.customer_RelativeEntity.Customer_relative_id.ToString();
            txtRelativecustomer.Text = customerEntity.customer_RelativeEntity.Customer_relative_name;
            txtPhone.Text = customerEntity.customer_RelativeEntity.Customer_relative_phone;
            txtrelationCustomer.Text = customerEntity.customer_RelativeEntity.Customer_relation;

            lblCustomer_service_agreement_ID.Text = customerEntity.customer_Service_AgreementEntity.Customer_service_agreement_id.ToString();
            txtMonthyCost.Text = customerEntity.customer_Service_AgreementEntity.Month_service_cost.ToString("#,##0");
            txtDiaperCost.Text = customerEntity.customer_Service_AgreementEntity.Diaper_commutation_cost.ToString("#,##0");
            txtDressingEuqCost.Text = customerEntity.customer_Service_AgreementEntity.Dressing_equipment_commutation_cost.ToString("#,##0");
            txtRemark.Text = customerEntity.customer_Service_AgreementEntity.Remark;
            txtReserveCost.Text = customerEntity.customer_Service_AgreementEntity.Customer_reservations_cost.ToString("#,##0");
            txtBalacneCost.Text = customerEntity.customer_Service_AgreementEntity.Customer_balance_cost.ToString("#,##0");
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            CustomerEntity customerEntity = new CustomerEntity();

            customerEntity.customer_RelativeEntity = new Customer_relativeEntity();
            customerEntity.customer_Service_AgreementEntity = new Customer_service_agreementEntity();

            DateFormat dateFormat = new DateFormat();


            //    Master.branchEntity.branch_id;
            customerEntity.customer_id = int.Parse(lblCustomerID.Text);
            customerEntity.branch_id = 1;

            customerEntity.contract_start = dateFormat.EngFormatDateToSQL(DateTime.Parse(txtContractStart.Text));
            customerEntity.contract_end = dateFormat.EngFormatDateToSQL(DateTime.Parse(txtContractStart.Text));
            customerEntity.firstname = txtFirstname.Text;
            customerEntity.lastname = txtLastname.Text;
            customerEntity.gender = ddlGender.SelectedValue;
            customerEntity.DOB = dateFormat.EngFormatDateToSQL(DateTime.Parse(txtDOB.Text));
            customerEntity.create_by = 1;
            customerEntity.create_date = dateFormat.EngFormatDateToSQL(DateTime.Now);
            customerEntity.modify_by = 1;
            customerEntity.modify_date = dateFormat.EngFormatDateToSQL(DateTime.Now);

            customerEntity.customer_RelativeEntity.Customer_relative_id = int.Parse(lblCustomer_relative_ID.Text);
            customerEntity.customer_RelativeEntity.Customer_relative_name = txtRelativecustomer.Text;
            customerEntity.customer_RelativeEntity.Customer_relative_phone = txtPhone.Text;
            customerEntity.customer_RelativeEntity.Customer_relation = txtrelationCustomer.Text;

            customerEntity.customer_Service_AgreementEntity.Customer_service_agreement_id = int.Parse(lblCustomer_service_agreement_ID.Text);
            customerEntity.customer_Service_AgreementEntity.Month_service_cost = Decimal.Parse(txtMonthyCost.Text);
            customerEntity.customer_Service_AgreementEntity.Diaper_commutation_cost = Decimal.Parse(txtDiaperCost.Text);
            customerEntity.customer_Service_AgreementEntity.Dressing_equipment_commutation_cost = Decimal.Parse(txtDressingEuqCost.Text);
            customerEntity.customer_Service_AgreementEntity.Remark = txtRemark.Text;
            customerEntity.customer_Service_AgreementEntity.Customer_reservations_cost = Decimal.Parse(txtReserveCost.Text);
            customerEntity.customer_Service_AgreementEntity.Customer_balance_cost = Decimal.Parse(txtBalacneCost.Text);
            customerEntity.customer_Service_AgreementEntity.Create_date = dateFormat.EngFormatDateToSQL(DateTime.Now);

            int success = 0;
            if (int.Parse(lblCustomerID.Text) > 0 )
            {
                success = customerService.UpdateData(customerEntity);
            }
            else
            {
                success = customerService.InsertData(customerEntity);
            }

            if (success > 0 )
            {
                Response.Redirect("/BackOffice/NursingHome/Bed-Reservation/bed-reserve-list.aspx", true);
            }
        }
    }
}