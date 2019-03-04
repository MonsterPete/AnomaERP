using Entity;
using Service.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Definitions;
using Service.BedManagement;

namespace AnomaERP.BackOffice.Bed_Management.Bed
{
    public partial class bed_add_accessory : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDropDownList();
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

        protected void setDropDownList()
        {
            ddlSku.Items.Clear();
            ddlSerial.Items.Clear();
            ddlDate.Items.Clear();

            InventoryService service = new InventoryService();
            List<InventoryEntity> inventoryEntities = service.GetSkuAll();

            for (int i = 0; i < inventoryEntities.Count; i++)
            {
                if (inventoryEntities[i].qty_total <= 0)
                {
                    inventoryEntities.RemoveAt(i);
                }
            }

            inventoryEntities.Insert(0, new InventoryEntity
            {
                type_id = 0,
                sku = "-select-"
            });

            ddlSku.DataSource = inventoryEntities;
            ddlSku.DataTextField = "sku";
            ddlSku.DataValueField = "type_id";
            ddlSku.DataBind();

            setdefault();
        }
        protected void ddlSku_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlSerial.Items.Clear();
            ddlDate.Items.Clear();

            List<InventoryEntity> inventoryEntities = new List<InventoryEntity>();
            InventoryService service = new InventoryService();

            InventoryEntity inventoryEntity = new InventoryEntity();
            inventoryEntity.sku = ddlSku.SelectedItem.ToString();
            inventoryEntity.type_id = int.Parse(ddlSku.SelectedValue);

            inventoryEntities = service.GetDataBySku(inventoryEntity);

            if (inventoryEntities.Count > 0)
            {
                for (int i = 0; i < inventoryEntities.Count; i++)
                {
                    List<InventoryEntity> inventoryEntities_Rpt = getDatafromRpt();
                    foreach (var item in inventoryEntities_Rpt)
                    {
                        if (inventoryEntities.Count > 0)
                        {
                            if (inventoryEntities[i].inventory_id == item.inventory_id)
                            {
                                inventoryEntities.RemoveAt(i);
                            }
                        }
                    }
                }
            }

            if (ddlSku.SelectedValue == "1")
            {                 
                inventoryEntities.Insert(0,new InventoryEntity
                {
                    inventory_id = 0,
                    serial = "-select-"
                });

                ddlSerial.DataSource = inventoryEntities;
                ddlSerial.DataTextField = "serial";
                ddlSerial.DataValueField = "inventory_id";
                ddlSerial.DataBind();
            }
            else if (ddlSku.SelectedValue == "2")
            {
                List<InventoryEntity> inventoryEntities2 = new List<InventoryEntity>();
                foreach (var item in inventoryEntities)
                {
                    inventoryEntities2.Add(new InventoryEntity
                    {
                        inventory_id = item.inventory_id,
                        s_create_date = item.create_date.ToString()
                    });
                }

                inventoryEntities2.Insert(0, new InventoryEntity
                {
                    inventory_id = 0,
                    s_create_date = "select"
                });

                ddlDate.DataSource = inventoryEntities2;
                ddlDate.DataTextField = "s_create_date";
                ddlDate.DataValueField = "inventory_id";
                ddlDate.DataBind();
            }
            else
            {
                setdefault();
            }

        }

        protected void ddlSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSerial.SelectedValue != "0")
            {
                InventoryEntity inventoryEntity = new InventoryEntity();

                inventoryEntity.sku = ddlSku.SelectedItem.ToString();
                inventoryEntity.serial = ddlSerial.SelectedItem.ToString();

                InventoryService service = new InventoryService();
                List<InventoryEntity> inventoryEntities = service.GetDataBySerial(inventoryEntity);


                if (inventoryEntities.Count > 0)
                {
                    foreach (var item in inventoryEntities)
                    {
                        txtName.Text = item.name;
                        txtQtyTotal.Text = item.qty_total.ToString();
                    }
                    txtQtyBed.ReadOnly = true;
                    txtQtyBed.Text = "1";
                }
            }
            else
            {
                txtName.Text = "";
                txtQtyTotal.Text = "";
            }
        }

        protected void ddlDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDate.SelectedValue != "0")
            {
                InventoryEntity inventoryEntity = new InventoryEntity();

                inventoryEntity.sku = ddlSku.SelectedItem.ToString();
                DateFormat dateFormat = new DateFormat();
                inventoryEntity.create_date = dateFormat.EngFormatDateToSQL(DateTime.Parse(ddlDate.SelectedItem.ToString()));

                InventoryService service = new InventoryService();
                List<InventoryEntity> inventoryEntities = service.GetDataByDate(inventoryEntity);

                if (inventoryEntities.Count > 0)
                {
                    foreach (var item in inventoryEntities)
                    {
                        txtName.Text = item.name;
                        txtQtyTotal.Text = item.qty_total.ToString();
                    }
                    txtQtyBed.ReadOnly = false;
                    txtQtyBed.Text = "";
                }
            }
            else
            {
                txtName.Text = "";
                txtQtyTotal.Text = "";
            }
        }

        protected void setdefault()
        {
            ddlSerial.Items.Clear();
            ddlDate.Items.Clear();
            ddlSerial.Items.Add(new ListItem("-select-", "0"));
            ddlDate.Items.Add(new ListItem("-select-", "0"));
            txtName.Text = "";
            txtQtyTotal.Text = "";
            txtQtyBed.Text = "";
        }

        private Boolean isValid()
        {
            String sku = ddlSku.SelectedItem.Value;
            String serial = String.Empty;
            String name = txtName.Text;
            String create_date = String.Empty;

            if (string.IsNullOrEmpty(txtQtyBed.Text))
            {
                return false;
            }

            int qty_total = int.Parse(txtQtyTotal.Text);
            int qty = int.Parse(txtQtyBed.Text);
            if (qty > qty_total)
            {
                return false;
            }

            if (ddlSku.SelectedValue == "0")
            {
                return false;
            }

            if (ddlSku.SelectedValue == "1")
            {
                if (ddlSerial.SelectedValue == "0")
                {
                    return false;
                }
            }
            else if (ddlSku.SelectedValue == "2")
            {
                if (ddlDate.SelectedValue == "0")
                {
                    return false;
                }
            }
            return true;

        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุข้อมูลใหม่อีกครั้ง');", true);
                return;
            }
            List<InventoryEntity> inventoryEntities = getDatafromRpt();

            if (ddlSku.SelectedValue == "1")
            {
                inventoryEntities.Add(new InventoryEntity
                {
                    Bed_inventory_id = 0,
                    inventory_id = int.Parse(ddlSerial.SelectedValue),
                    sku = ddlSku.SelectedItem.ToString(),
                    serial = ddlSerial.SelectedItem.ToString(),
                    name = txtName.Text,
                    qty_total = int.Parse(txtQtyTotal.Text),
                    qty = int.Parse(txtQtyBed.Text),
                    Active = true,
                    flag = "New"
                });
            }
            else if(ddlSku.SelectedValue == "2")
            {
                inventoryEntities.Add(new InventoryEntity
                {
                    Bed_inventory_id = 0,
                    inventory_id = int.Parse(ddlDate.SelectedValue),
                    sku = ddlSku.SelectedItem.ToString(),
                    create_date = DateTime.Parse(ddlDate.SelectedItem.ToString()),
                    name = txtName.Text,
                    qty_total = int.Parse(txtQtyTotal.Text),
                    qty = int.Parse(txtQtyBed.Text),
                    Active = true,
                    flag = "New"
                });
            }
            SetDataToRpt(inventoryEntities);

            ddlSku.SelectedValue = "0";
            setdefault();
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
                Label lblQtyTotla = (Label)resultList.Items[i].FindControl("lblQtyTotla");
                Label lblQtyOutbound = (Label)resultList.Items[i].FindControl("lblQtyOutbound");
                HiddenField flag = (HiddenField)resultList.Items[i].FindControl("flag");

                
                if (!string.IsNullOrEmpty(lblDate.Text))
                {
                    create_date = DateTime.Parse(lblDate.Text);
                }

                if (resultList.Items[i].Visible == true)
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
                        qty_total = int.Parse(lblQtyTotla.Text),
                        qty = int.Parse(lblQtyOutbound.Text),
                        Active = true,
                        flag = flag.Value
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
            Label lblQtyTotla = (Label)e.Item.FindControl("lblQtyTotla");
            Label lblQtyOutbound = (Label)e.Item.FindControl("lblQtyOutbound");
            HiddenField flag = (HiddenField)e.Item.FindControl("flag");

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
            lblQtyTotla.Text = entity.qty_total.ToString();
            lblQtyOutbound.Text = entity.qty.ToString();
            flag.Value = entity.flag.ToString();

            lbnRemove.CommandName = "Remove";
            lbnRemove.CommandArgument = entity.temp_inventory_id;

            if (entity.flag != "New")
            {
                lbnRemove.Visible = false;
            }
        }

        protected void resultList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
                e.Item.Visible = false;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            List<InventoryEntity> inventoryEntities_Rpt = getDatafromRpt();
            BedInventoryService bedInventoryService = new BedInventoryService();

            int success = 0;
            //Update Inventory set QTY_TOTAL
            List<InventoryEntity> inventoryEntities = new List<InventoryEntity>();
            success = bedInventoryService.InsertDataMore(inventoryEntities_Rpt);

            if (success > 0)
            {
                Response.Redirect("/BackOffice/Bed-Management/Bed/bed-entity.aspx");
            }
        }
    }
}