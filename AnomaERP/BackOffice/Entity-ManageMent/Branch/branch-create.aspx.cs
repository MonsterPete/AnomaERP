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
                txtPassword.Attributes.Add("type", "password");
            }
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            int success = 0;

            BranchEntity branchEntity = new BranchEntity();
            BranchService branchService = new BranchService();
            DateFormat dateFormat = new DateFormat();

            if (string.IsNullOrEmpty(txtBranchName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุชื่อสาขา (Branch name)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุชื่อผู้ใช้งาน (Username)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุรหัสผ่าน (Password)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุเบอร์โทรศัพท์ (Phone)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุราคา (Rental Price)');", true);
                return;
            }

            if (branchService.CheckUsernameRepeat(txtUsername.Text,int.Parse(lblbranchID.Text)).Role == "repeat")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('ชื่อผู้ใช้งานมีอยู่แล้ว (Username) กรุณาระบุใหม่อีกครั้ง');", true);
                return;
            }

            branchEntity.branch_id = int.Parse(lblbranchID.Text);
            branchEntity.entity_id = Master.entityEntity.entity_id;
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

            if (int.Parse(lblbranchID.Text) > 0 )
            {
                success = branchService.UpdateData(branchEntity);
            }
            else
            {
                success = branchService.InsertData(branchEntity);
            }
            
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