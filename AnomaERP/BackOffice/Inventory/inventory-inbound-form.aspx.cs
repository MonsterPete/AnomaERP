using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Definitions;
using Entity;
using Service.AssetType;
using Service.Category;
using Service.Inventory;

namespace AnomaERP.BackOffice.Inventory
{
    public partial class inventory_inbound_form : System.Web.UI.Page
    {
        public static String gFormatDateValStr = "yyyyMMddHHmmssff";

        public static List<InventoryEntity> gDatastore = new List<InventoryEntity>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gDatastore = new List<InventoryEntity>();

                //***Set Branch
                lblBranchID.Text = "1"; //Suma fix for Test
                if (Request.QueryString["branch_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["branch_ID"]) > 0)
                    {
                        lblBranchID.Text = Request.QueryString["branch_ID"].ToString();
                    }
                }
                if (Request.QueryString["branch_NAME"] != null)
                {
                    if (int.Parse(Request.QueryString["branch_NAME"]) > 0)
                    {
                        txtBranch.Text = Request.QueryString["branch_NAME"].ToString();
                        txtBranch.ReadOnly = true;
                    }
                }
                else
                {
                    txtBranch.Text = "-";
                    txtBranch.ReadOnly = true;
                }

                //***Set CreateBy
                lblCreateByID.Text = "1"; //Suma fix for Test
                if (Request.QueryString["create_by_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["create_by_ID"]) > 0)
                    {
                        lblCreateByID.Text = Request.QueryString["create_by_ID"].ToString();
                    }
                }

                if (Request.QueryString["create_by_NAME"] != null)
                {
                    if (int.Parse(Request.QueryString["create_by_NAME"]) > 0)
                    {
                        txtCreateBy.Text = Request.QueryString["create_by_NAME"].ToString();
                        txtCreateBy.ReadOnly = true;
                    }
                }
                else
                {
                    txtCreateBy.Text = "-";
                    txtCreateBy.ReadOnly = true;
                }

                //***Set DropDownList
                setDropDownList();
            }
        }
        protected void setDropDownList()
        {
            txtQty.ReadOnly = true;
            txtQty.Text = "1";

            ddlType.Items.Clear();
            ddlCategory.Items.Clear();

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

            lbnRemove.CommandName = "Remove";
            lbnRemove.CommandArgument = entity.temp_inventory_id;
        }

        protected void rptList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
                //Response.Redirect("/BackOffice/NursingHome/Visitor-Form/visitor-form.aspx?visitor_id=" + e.CommandArgument);
                foreach (InventoryEntity data in gDatastore)
                {
                    if (data.temp_inventory_id.Equals(e.CommandArgument))
                    {
                        gDatastore.Remove(data);
                        break;
                    }
                }

                resultList.DataSource = gDatastore;
                resultList.DataBind();
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

            //Check Empty
            unValid |= String.IsNullOrEmpty(sku);
            unValid |= String.IsNullOrEmpty(name);
            unValid |= String.IsNullOrEmpty(qty);
            unValid |= String.IsNullOrEmpty(type_id);
            unValid |= String.IsNullOrEmpty(category_id);

            //if type = single require serial
            if (int.Parse(type_id) == 1)
            {
                unValid |= String.IsNullOrEmpty(serial);
            }


            //Check Number < 0 
            if (!String.IsNullOrEmpty(qty))
            {
                unValid |= (int.Parse(qty) < 0);
            }

            valid = !unValid;
            return valid;
        }
        private Boolean checkDuplicateData(InventoryEntity entity)
        {
            Boolean isDuplicate = false;
            int type_id = entity.type_id;

            if (type_id == 1)
            {
                //Check Duplicate from gDatastore
                foreach (InventoryEntity data in gDatastore)
                {
                    if (entity.sku == data.sku && entity.serial == data.serial)
                    {
                        isDuplicate = true;
                    }
                }

                //Check Duplicate from dbTable inventory
                if (isDuplicate == false)
                {
                    InventoryService service = new InventoryService();
                    List<InventoryEntity> duplicateList = new List<InventoryEntity>();
                    duplicateList = service.CheckDuplicateData(entity);
                    if (duplicateList.Count > 0)
                    {
                        isDuplicate = true;
                    }
                }
            }
            return isDuplicate;
        }
        protected void clearAddFrom()
        {
            txtSku.Text = "";
            txtSerial.Text = "";
            txtName.Text = "";
            
            setDropDownList();
        }
        public void addDataToUI(InventoryEntity entity)
        {
            gDatastore.Add(entity);
            resultList.DataSource = gDatastore;
            resultList.DataBind();

            clearAddFrom();
        }
        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            DateFormat dateFormat = new DateFormat();

            if (isValid() == true)
            {
                InventoryEntity entity = new InventoryEntity();
                entity.branch_id = int.Parse(lblBranchID.Text);
                entity.name = txtName.Text;
                entity.qty = int.Parse(txtQty.Text);
                entity.qty_total = int.Parse(txtQty.Text);
                entity.sku = txtSku.Text;
                entity.serial = txtSerial.Text;
                entity.type_id = int.Parse(ddlType.SelectedItem.Value);
                entity.type_name = ddlType.SelectedItem.Text;
                entity.category_id = int.Parse(ddlCategory.SelectedItem.Value);
                entity.category_name = ddlCategory.SelectedItem.Text;
                entity.create_by = int.Parse(lblCreateByID.Text);
                entity.create_date = dateFormat.EngFormatDateToSQL(DateTime.Now);
                entity.is_active = true;
                entity.is_delete = false;
                entity.updateMode = entity.Inbound;
                entity.temp_inventory_id = DateTime.Now.ToString(gFormatDateValStr);

                if (checkDuplicateData(entity) == false)
                {
                    addDataToUI(entity);
                }
                else
                {
                    //Suma Alert DuplicateData
                }
            }
            else
            {
                //Suma Alert !isValid
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (gDatastore.Count > 0)
            {
                InventoryEntity entity = new InventoryEntity();
                entity.updateMode = entity.Inbound;
                entity.inventoryEntityList = gDatastore;

                InventoryService service = new InventoryService();
                int success = 0;
                success = service.InsertData(entity);

                if (success > 0)
                {
                    clearAddFrom();
                    gDatastore = new List<InventoryEntity>();

                    Response.Redirect("/BackOffice/Inventory/inventory.aspx", true);
                }
            }
            else
            {
                //Suma Alert No Update Data
            }
        }

        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int type_id = int.Parse(ddlType.SelectedItem.Value);
            if (type_id == 1)
            {
                txtQty.ReadOnly = true;
                txtQty.Text = "1";
            }
            else if (type_id == 2)
            {
                txtQty.ReadOnly = false;
                txtQty.Text = "";
            }
        }
    }
}