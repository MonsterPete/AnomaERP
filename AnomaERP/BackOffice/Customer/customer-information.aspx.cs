using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service;
using Service.Customer;

namespace AnomaERP.BackOffice.Customer
{
    public partial class customer_information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCustomerID.Text = "0";
                if (Request.QueryString["customer_id"] != null)
                {

                    if (int.Parse(Request.QueryString["customer_id"]) > 0)
                    {
                        lblCustomerID.Text = Request.QueryString["customer_id"].ToString();
                        SetDataToUI(int.Parse(lblCustomerID.Text));
                    }
                }
            }
        }

        public void SetDataToUI(int branch_id)
        {
            CustomerEntity customerEntity = new CustomerEntity();
            List<CustomerCongenitalDiseaseEntity> customerCongenitalDiseaseEntities = new List<CustomerCongenitalDiseaseEntity>();
            List<CustomerRedFlagEntity> customerRedFlagEntities = new List<CustomerRedFlagEntity>();
            List<CustomerRiskAssessmentEntity> customerRiskAssessmentEntities = new List<CustomerRiskAssessmentEntity>() ;
            List<CustomerPersonalFactorsEntity> customerPersonalFactorsEntities = new List<CustomerPersonalFactorsEntity>();

            CustomerService customerService = new CustomerService();
            CongenitalDiseaseService congenitalDiseaseService = new CongenitalDiseaseService();
            RedFlagService redFlagService = new RedFlagService();
            RiskAssessmentService riskAssessmentService = new RiskAssessmentService();
            PersonalFactorsService personalFactorsService = new PersonalFactorsService();

            branchEntity = branchService.GetDataBranchByID(branch_id);

            txtBranchName.Text = branchEntity.branch_name;
            txtAddress.Text = branchEntity.address;
            txtAddressRegis.Text = branchEntity.registor_address;
            txtTaxID.Text = branchEntity.tax_id;
            txtPrefix.Text = branchEntity.prefix;
            ddlBuildingType.SelectedValue = branchEntity.building_type_id.ToString();
            txtArea.Text = branchEntity.usage_area;
            txtPrice.Text = branchEntity.rental_price.ToString("N2");
            txtPhone.Text = branchEntity.phone;
            txtEmail.Text = branchEntity.email;
            txtUsername.Text = branchEntity.username;
            txtPassword.Text = branchEntity.password;

        }
    }
}