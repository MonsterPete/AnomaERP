using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Customer;
using Definitions;

namespace AnomaERP.BackOffice.NursingHome
{
    public partial class bed_reserve_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDataToUI(setCondition());
            }
        }

        protected void rptCustomerReserveList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            CustomerEntity customerEntity = (CustomerEntity)e.Item.DataItem;
            Label lblID = (Label)e.Item.FindControl("lblID");
            Label lblBranchName = (Label)e.Item.FindControl("lblBranchName");
            Label lblReserveDate = (Label)e.Item.FindControl("lblReserveDate");
            Label lblCustomerName = (Label)e.Item.FindControl("lblCustomerName");
            Label lblSymtom = (Label)e.Item.FindControl("lblSymtom");
            Label lblPhone = (Label)e.Item.FindControl("lblPhone");
            LinkButton lbnEdit = (LinkButton)e.Item.FindControl("lbnEdit");
            LinkButton lbnCarePlan = (LinkButton)e.Item.FindControl("lbnCarePlan");
            
            DateFormat dateFormat = new DateFormat();

            lblID.Text = customerEntity.customer_id.ToString();
            lblBranchName.Text = customerEntity.branch_name;
            lblReserveDate.Text = dateFormat.EngFormatDate(customerEntity.create_date);
            lblCustomerName.Text = customerEntity.firstname + " " + customerEntity.lastname;
            lblSymtom.Text = "";
            if (customerEntity.customer_RelativeEntity != null)
            {
                lblPhone.Text = customerEntity.customer_RelativeEntity.customer_relative_phone_1;
            }
           
            lbnEdit.CommandName = "Edit";
            lbnEdit.CommandArgument = customerEntity.customer_id.ToString();

            lbnCarePlan.CommandName = "CarePlan";
            lbnCarePlan.CommandArgument = customerEntity.customer_id.ToString();
        }

        protected void rptCustomerReserveList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("/BackOffice/NursingHome/Bed-Reservation/reserve-form.aspx?customer_reserve_id=" + e.CommandArgument);
            }
            else if (e.CommandName == "CarePlan")
            {
                Response.Redirect("/BackOffice/ServiceCare/care-plan.aspx?customerId=" + e.CommandArgument);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            setDataToUI(setCondition());
        }

        public void setDataToUI(CustomerEntity customerEntity)
        {
            CustomerService customerService = new CustomerService();
            List<CustomerEntity> customerEntities = new List<CustomerEntity>();

            customerEntities = customerService.GetDataByCondition(customerEntity);

            rptCustomerReserveList.DataSource = customerEntities;
            rptCustomerReserveList.DataBind();
        }



        public CustomerEntity setCondition()
        {
            CustomerEntity customerEntity = new CustomerEntity();

            customerEntity.firstname = txtCustomerName.Text;
            customerEntity.lastname = txtCustomerName.Text;

            customerEntity.branch_id = Master.branchEntity.branch_id;
            return customerEntity;
        }
    }
}