using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Entity;


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
            }
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            int success = 0;

            EntityEntity entityEntity = new EntityEntity();           
            EntityService entityService = new EntityService();

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
            entityEntity.is_delete = true;

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