using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Branch;
using Definitions;

namespace AnomaERP.BackOffice.Branch
{
    public partial class branch_create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblbranchID.Text = "0";
                if (Request.QueryString["branch_ID"] != null)
                {

                    if (int.Parse(Request.QueryString["branch_ID"]) > 0)
                    {
                        lblbranchID.Text = Request.QueryString["branch_ID"].ToString();
                        SetDataToUI(int.Parse(lblbranchID.Text));
                    }
                }
            }
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            int success = 0;

            BranchEntity branchEntity = new BranchEntity();
            BranchService branchService = new BranchService();
            DateFormat dateFormat = new DateFormat();
            

            branchEntity.branch_id = int.Parse(lblbranchID.Text);
            branchEntity.entity_id = 1;
            branchEntity.branch_name = txtBranchName.Text;
            branchEntity.address = txtAddress.Text;
            branchEntity.registor_address = txtAddressRegis.Text;
            branchEntity.tax_id = txtTaxID.Text;
            branchEntity.prefix = txtPrefix.Text;
            branchEntity.usage_area = txtArea.Text;
            branchEntity.rental_price = Convert.ToDecimal(txtPrice.Text);
            branchEntity.phone = txtPhone.Text;
            branchEntity.email = txtEmail.Text;
            branchEntity.username = txtUsername.Text;
            branchEntity.password = txtPassword.Text;
            branchEntity.create_date = DateTime.UtcNow;
            branchEntity.modify_date = DateTime.UtcNow;
            branchEntity.is_active = true;
            branchEntity.is_delete = false;

            success = branchService.InsertData(branchEntity);
            if (success > 0)
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/Branch-list.aspx");
            }
        }

        public void SetDataToUI(int branch_id)
        {
            BranchService branchService = new BranchService();
            BranchEntity branchEntity = new BranchEntity();

            branchEntity = branchService.GetDataBranchByID(branch_id);

            txtBranchName.Text = branchEntity.branch_name;
            //fileImage.FileName = entityEntity.logo;
            txtAddress.Text = branchEntity.address;
            txtAddressRegis.Text = branchEntity.registor_address;
            txtTaxID.Text = branchEntity.tax_id;
            txtPrefix.Text = branchEntity.prefix;
            txtArea.Text = branchEntity.usage_area;
            txtPrice.Text = branchEntity.rental_price.ToString("N2");
            txtPhone.Text = branchEntity.phone;
            txtEmail.Text = branchEntity.email;
            txtUsername.Text = branchEntity.username;
            txtPassword.Text = branchEntity.password;

        }
    }
}