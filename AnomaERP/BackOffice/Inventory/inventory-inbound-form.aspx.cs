using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.AssetType;
using Service.Category;

namespace AnomaERP.BackOffice.Inventory
{
    public partial class inventory_inbound_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblBranchID.Text = "1"; //Suma fix for Test
                if (Request.QueryString["branch_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["branch_ID"]) > 0)
                    {
                        lblBranchID.Text = Request.QueryString["branch_ID"].ToString();
                    }
                }
                setDropDownList();
            }
        }
        protected void setDropDownList()
        {
            AssetTypeService atService = new AssetTypeService();
            List<AssetTypeEntity> atEntityList = atService.GetDataAll();
            foreach (AssetTypeEntity at in atEntityList)
            {
                ddlType.Items.Add(new ListItem(at.name, at.type_id.ToString()));
            }

            CategoryService cService = new CategoryService();
            List<CategoryEntity> cEntityList = cService.GetDataAll();
            foreach (CategoryEntity c in cEntityList)
            {
                ddlCategory.Items.Add(new ListItem(c.category_name, c.category_id.ToString()));
            }
        }

        protected void rptList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            InventoryEntity entity = (InventoryEntity)e.Item.DataItem;

            Label lblType = (Label)e.Item.FindControl("lblType");
            Label lblCategory = (Label)e.Item.FindControl("lblCategory");
            Label lblSku = (Label)e.Item.FindControl("lblSku");
            Label lblSerial = (Label)e.Item.FindControl("lblSerial");
            Label lblName = (Label)e.Item.FindControl("lblName");
            Label lblQty = (Label)e.Item.FindControl("lblQty");

            LinkButton lbnRemove = (LinkButton)e.Item.FindControl("lbnRemove");
            //HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");

            lblType.Text = entity.type_name;
            lblCategory.Text = entity.category_name;
            lblSku.Text = entity.sku;
            lblSerial.Text = entity.serial;
            lblName.Text = entity.name;
            lblQty.Text = entity.qty.ToString();

            lbnRemove.CommandName = "Edit";
            lbnRemove.CommandArgument = entity.inventory_id.ToString();
        }

        protected void rptList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("/BackOffice/NursingHome/Visitor-Form/visitor-form.aspx?visitor_id=" + e.CommandArgument);
            }
        }
        private Boolean isValid()
        {
            Boolean unValid = false, valid = true;
            String sku = txtSku.Text;
            String serial = txtSerial.Text;
            String name = txtName.Text;
            String qty = txtQty.Text;
            String type_id = ddlType.SelectedValue;
            String category_id = ddlCategory.SelectedValue;

            unValid |= String.IsNullOrEmpty(sku);
            unValid |= String.IsNullOrEmpty(serial);
            unValid |= String.IsNullOrEmpty(name);
            unValid |= String.IsNullOrEmpty(qty);
            unValid |= String.IsNullOrEmpty(type_id);
            unValid |= String.IsNullOrEmpty(category_id);

            valid = !unValid;
            return valid;
        }
        public void addDataToUI(InventoryEntity entity)
        {
            Object nowList = resultList.DataSource;

            List<InventoryEntity> entityList = new List<InventoryEntity>();
            entityList.Add(entity);

            resultList.DataSource = entityList;
            resultList.DataBind();
        }
        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                InventoryEntity entity = new InventoryEntity();
                entity.sku = txtSku.Text;
                entity.serial = txtSerial.Text;
                entity.name = txtName.Text;
                entity.qty = int.Parse(txtQty.Text);
                entity.type_id = int.Parse(ddlType.SelectedItem.Value);
                entity.category_id = int.Parse(ddlCategory.SelectedItem.Value);

                entity.type_name = ddlType.SelectedItem.Text;
                entity.category_name = ddlCategory.SelectedItem.Text;
                
                addDataToUI(entity);
            }
            else
            {
                //Suma Alert !isValid
            }
        }
    }
}