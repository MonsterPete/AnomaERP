using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Entity;
using Service.Branch;


namespace AnomaERP.BackOffice.Entity
{
    public partial class Entity_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblentityID.Text = "0";
                if (Request.QueryString["entity_ID"] != null)
                {

                    if (int.Parse(Request.QueryString["entity_ID"]) > 0)
                    {
                        lblentityID.Text = Request.QueryString["entity_ID"].ToString();
                        SetDataToUI(int.Parse(lblentityID.Text));
                    }
                }
                txtPassword.Attributes.Add("type", "password");
            }
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            int success = 0;

            EntityEntity entityEntity = new EntityEntity();           
            EntityService entityService = new EntityService();

            BranchService branchService = new BranchService();

            if (string.IsNullOrEmpty(txtEntityName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุชื่อหน่วยงาน (Entity name)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text))
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

            if (branchService.CheckUsernameRepeat(txtUserName.Text, int.Parse(lblentityID.Text)).Role == "repeat")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('ชื่อผู้ใช้งานมีอยู่แล้ว (Username) กรุณาระบุใหม่อีกครั้ง');", true);
                return;
            }


            entityEntity.entity_id = int.Parse(lblentityID.Text);
            entityEntity.entity_name = txtEntityName.Text;
            entityEntity.logo = fileImage.FileName;
            entityEntity.address = txtAddress.Text;
            entityEntity.register_address = txtRegisAddress.Text;
            entityEntity.tax_id = txtTaxID.Text;
            entityEntity.perfix = txtPrefix.Text;
            entityEntity.phone = txtPhone.Text;
            entityEntity.email = txtEmail.Text;
            entityEntity.username = txtUserName.Text;
            entityEntity.password = txtPassword.Text;
            entityEntity.create_date = DateTime.UtcNow;
            entityEntity.modify_date = DateTime.UtcNow;
            entityEntity.is_active = true;
            entityEntity.is_delete = false;

            success = entityService.InsertData(entityEntity);  
            if(success > 0)
            {
                Response.Redirect("/BackOffice/Entity-Management/Entity/Entity-list.aspx");
            }
        }

        public void SetDataToUI(int entity_id)
        {
            EntityService entityService = new EntityService();
            EntityEntity entityEntity = new EntityEntity();

            entityEntity = entityService.GetDataEntityByID(entity_id);
           
            txtEntityName.Text = entityEntity.entity_name;
            //fileImage.FileName = entityEntity.logo;
            txtAddress.Text = entityEntity.address;
            txtRegisAddress.Text = entityEntity.register_address;
            txtTaxID.Text = entityEntity.tax_id;
            txtPrefix.Text = entityEntity.perfix;
            txtPhone.Text = entityEntity.phone;
            txtEmail.Text = entityEntity.email;
            txtUserName.Text = entityEntity.username;
            txtPassword.Text = entityEntity.password;
         
        }
    }
}