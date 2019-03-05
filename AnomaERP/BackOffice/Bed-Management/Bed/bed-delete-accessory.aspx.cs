using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Entity;
using Service.BedManagement;

namespace AnomaERP.BackOffice.Bed_Management.Bed
{
    public partial class bed_delete_accessory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["bed_id"] != null)
                {
                    lblBedID.Text = Request.QueryString["bed_id"].ToString();
                    SetDataToUI(int.Parse(lblBedID.Text));
                }
            }

        }

        public void SetDataToUI(int bed_id)
        {
            BedCustomerEntity bedCustomerEntity = new BedCustomerEntity();
            List<InventoryEntity> inventoryEntities = new List<InventoryEntity>();

            BedInventoryService bedInventoryService = new BedInventoryService();

            bedCustomerEntity = bedInventoryService.GetDateBedCustomerByBedID(bed_id);

            txtbedname.Text = bedCustomerEntity.bed_name;
            txtcustomername.Text = bedCustomerEntity.customername;

            inventoryEntities = bedInventoryService.GetDateBedInventoryByBedID(bed_id);

            SetDataToRpt(inventoryEntities);
        }


        public List<InventoryEntity> getDatafromRpt()
        {
            List<InventoryEntity> inventoryEntities = new List<InventoryEntity>();
            DateTime create_date = new DateTime();

            for (int i = 0; i < resultList.Items.Count; i++)
            {
                Label lblbedinventoryID = (Label)resultList.Items[i].FindControl("lblbedinventoryID");
                Label lblinventoryID = (Label)resultList.Items[i].FindControl("lblinventoryID");
                Label lblSku = (Label)resultList.Items[i].FindControl("lblSku");
                Label lblSerial = (Label)resultList.Items[i].FindControl("lblSerial");
                Label lblDate = (Label)resultList.Items[i].FindControl("lblDate");
                Label lblName = (Label)resultList.Items[i].FindControl("lblName");
                Label lblQtyTotal = (Label)resultList.Items[i].FindControl("lblQtyTotal");
                Label lblQtyBed = (Label)resultList.Items[i].FindControl("lblQtyBed");
                TextBox txtQtyReturn = (TextBox)resultList.Items[i].FindControl("txtQtyReturn");
                HtmlInputCheckBox chkSelect = (HtmlInputCheckBox)resultList.Items[i].FindControl("chkSelect");

                if (!string.IsNullOrEmpty(lblDate.Text))
                {
                    create_date = DateTime.Parse(lblDate.Text);
                }

                if (chkSelect.Checked)
                {
                    inventoryEntities.Add(new InventoryEntity
                    {
                        Bed_inventory_id = int.Parse(lblbedinventoryID.Text),
                        inventory_id = int.Parse(lblinventoryID.Text),
                        Bed_id = int.Parse(lblBedID.Text),
                        sku = lblSku.Text,
                        serial = lblSerial.Text,
                        create_date = create_date,
                        name = lblName.Text,
                        qty_total = int.Parse(lblQtyTotal.Text),
                        qty = int.Parse(lblQtyBed.Text),
                        qty_return = int.Parse(txtQtyReturn.Text),
                        Active = true,
                        flag = "select"
                    });
                }
                else
                {
                    inventoryEntities.Add(new InventoryEntity
                    {
                        Bed_inventory_id = int.Parse(lblbedinventoryID.Text),
                        inventory_id = int.Parse(lblinventoryID.Text),
                        Bed_id = int.Parse(lblBedID.Text),
                        sku = lblSku.Text,
                        serial = lblSerial.Text,
                        create_date = create_date,
                        name = lblName.Text,
                        qty_total = int.Parse(lblQtyTotal.Text),
                        qty = int.Parse(lblQtyBed.Text),
                        qty_return = int.Parse(txtQtyReturn.Text),
                        Active = true,
                        flag = "noneselect"
                    });
                }
            }

            return inventoryEntities;
        }

        public void SetDataToRpt(List<InventoryEntity> inventoryEntities)
        {
            resultList.DataSource = inventoryEntities;
            resultList.DataBind();
        }

        protected void resultList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            InventoryEntity entity = (InventoryEntity)e.Item.DataItem;

            Label lblbedinventoryID = (Label)e.Item.FindControl("lblbedinventoryID");
            Label lblinventoryID = (Label)e.Item.FindControl("lblinventoryID");
            Label lblSku = (Label)e.Item.FindControl("lblSku");
            Label lblSerial = (Label)e.Item.FindControl("lblSerial");
            Label lblDate = (Label)e.Item.FindControl("lblDate");
            Label lblName = (Label)e.Item.FindControl("lblName");
            Label lblQtyTotal = (Label)e.Item.FindControl("lblQtyTotal");
            Label lblQtyBed = (Label)e.Item.FindControl("lblQtyBed");
            TextBox txtQtyReturn = (TextBox)e.Item.FindControl("txtQtyReturn");
            HtmlInputCheckBox chkSelect = (HtmlInputCheckBox)e.Item.FindControl("chkSelect");

            LinkButton lbnRemove = (LinkButton)e.Item.FindControl("lbnRemove");

            lblbedinventoryID.Text = entity.Bed_inventory_id.ToString();
            lblinventoryID.Text = entity.inventory_id.ToString();
            lblSku.Text = entity.sku;
            lblSerial.Text = entity.serial;

            if (entity.create_date != default(DateTime))
            {
                lblDate.Text = entity.create_date.ToString();
            }

            lblName.Text = entity.name;
            lblQtyTotal.Text = entity.qty_total.ToString();
            lblQtyBed.Text = entity.qty.ToString();
            txtQtyReturn.Text = entity.qty.ToString();

            lbnRemove.CommandName = "Remove";
            lbnRemove.CommandArgument = entity.temp_inventory_id;
        }

        protected void resultList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
                e.Item.Visible = false;
            }
        }

        private Boolean isValid()
        {
            List<InventoryEntity> inventoryEntities_Rpt = getDatafromRpt();

            foreach (var item in inventoryEntities_Rpt)
            {
                if (item.qty_return > item.qty)
                {
                    return false;
                }
            }
            return true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุข้อมูลใหม่อีกครั้ง');", true);
                return;
            }  
            List<InventoryEntity> inventoryEntities_Rpt = getDatafromRpt();
            BedInventoryService bedInventoryService = new BedInventoryService();

            int success = 0;
            //Update Inventory set QTY_TOTAL
            List<InventoryEntity> inventoryEntities = new List<InventoryEntity>();
            success = bedInventoryService.InsertDataMore_return(inventoryEntities_Rpt);

            if (success > 0)
            {
                Response.Redirect("/BackOffice/Bed-Management/Bed/bed-entity.aspx");
            }
        }
    }
}
