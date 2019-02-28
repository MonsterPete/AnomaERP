using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Definitions;
using Entity;
using Service.Inventory;
using Service.InventoryLog;

namespace AnomaERP.BackOffice.Inventory
{
    public partial class inventory_outbound_form : System.Web.UI.Page
    {
        public static String gFormatDateValStr = "yyyyMMddHHmmssff";
        public static List<InventoryEntity> gDatastore = new List<InventoryEntity>();

        private static String defaultDDL = "กรุณาระบุ";
        private static String defaultDDL_NoData = "-";

        public static List<InventoryEntity> skuEntityList = new List<InventoryEntity>();

        public static int sel_type_id;
        public static List<InventoryEntity> selEntityList = new List<InventoryEntity>();
        public static InventoryEntity selEntity = new InventoryEntity();

        public static int maxQty = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //** Branch
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

                //** Requestor
                lblRequestorID.Text = "1"; //Suma fix for Test
                if (Request.QueryString["requestor_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["requestor_ID"]) > 0)
                    {
                        lblRequestorID.Text = Request.QueryString["branch_ID"].ToString();
                    }
                }
                if (Request.QueryString["requestor_NAME"] != null)
                {
                    if (int.Parse(Request.QueryString["requestor_NAME"]) > 0)
                    {
                        txtRequestor.Text = Request.QueryString["requestor_NAME"].ToString();
                        txtRequestor.ReadOnly = true;
                    }
                }
                else
                {
                    txtRequestor.Text = "-";
                    txtRequestor.ReadOnly = true;
                }

                //** Approval
                lblApprovalID.Text = "1"; //Suma fix for Test
                if (Request.QueryString["approval_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["approval_ID"]) > 0)
                    {
                        lblApprovalID.Text = Request.QueryString["approval_ID"].ToString();
                    }
                }
                if (Request.QueryString["approval_NAME"] != null)
                {
                    if (int.Parse(Request.QueryString["approval_NAME"]) > 0)
                    {
                        txtApproval.Text = Request.QueryString["approval_NAME"].ToString();
                        txtApproval.ReadOnly = true;
                    }
                }
                else
                {
                    txtApproval.Text = "-";
                    txtApproval.ReadOnly = true;
                }


                gDatastore = new List<InventoryEntity>();
                clearAddFrom();
            }
        }
        protected void setDropDownList()
        {
            ddlSku.Items.Clear();

            ddlSerial.Items.Clear();
            ddlDate.Items.Clear();

            ddlSerial.Items.Add(new ListItem(defaultDDL_NoData, defaultDDL_NoData));
            ddlDate.Items.Add(new ListItem(defaultDDL_NoData, defaultDDL_NoData));

            InventoryService service = new InventoryService();
            skuEntityList = service.GetSkuAll();

            ddlSku.Items.Add(new ListItem(defaultDDL, defaultDDL));
            foreach (InventoryEntity sku in skuEntityList)
            {
                ddlSku.Items.Add(new ListItem(sku.sku, sku.sku));
            }
        }
        protected void ddlSku_SelectedIndexChanged(object sender, EventArgs e)
        {
            String skuVal = ddlSku.SelectedItem.Value;
            if (skuVal == defaultDDL || skuVal == defaultDDL_NoData)
            {
                ddlSerial.Items.Clear();
                ddlDate.Items.Clear();
                clearAddInput();
            }
            else
            {
                ddlSerial.Items.Clear();
                ddlDate.Items.Clear();

                foreach (InventoryEntity sku in skuEntityList)
                {
                    if (sku.sku == skuVal)
                    {
                        sel_type_id = sku.type_id;
                        if (sel_type_id == 1)
                        {
                            //Query Serial List
                            ddlSerial.Items.Add(new ListItem(defaultDDL, defaultDDL));
                            ddlDate.Items.Add(new ListItem(defaultDDL_NoData, defaultDDL_NoData));

                            InventoryService service = new InventoryService();
                            List<InventoryEntity> entityList = service.GetDataBySku(sku);
                            selEntityList = entityList;
                            foreach (InventoryEntity entity in entityList)
                            {
                                ddlSerial.Items.Add(new ListItem(entity.serial, entity.serial));
                            }
                        }
                        else if (sel_type_id == 2)
                        {
                            //Query Serial Date
                            ddlSerial.Items.Add(new ListItem(defaultDDL_NoData, defaultDDL_NoData));
                            ddlDate.Items.Add(new ListItem(defaultDDL, defaultDDL));

                            InventoryService service = new InventoryService();
                            List<InventoryEntity> entityList = service.GetDataBySku(sku);
                            selEntityList = entityList;
                            foreach (InventoryEntity entity in entityList)
                            {
                                String create_date_code = entity.create_date.ToString(gFormatDateValStr);
                                String create_date_value = entity.create_date.ToString("dd/MM/yyyy");

                                ddlDate.Items.Add(new ListItem(create_date_value, create_date_code));
                            }
                        }
                        break;
                    }
                }
            }
        }
        protected void ddlSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSerial.SelectedItem.Value == defaultDDL || ddlSerial.SelectedItem.Value == defaultDDL_NoData)
            {
                clearAddInput();
            }
            else
            {
                InventoryEntity entity = new InventoryEntity();
                entity.sku = ddlSku.SelectedItem.Value;
                entity.serial = ddlSerial.SelectedItem.Value;

                InventoryService service = new InventoryService();
                List<InventoryEntity> entityList = service.GetDataBySerial(entity);
                if (entityList.Count > 0)
                {
                    //เก็บ entity ตัวที่ Edit
                    selEntity = entityList[0];

                    txtName.Text = selEntity.name;
                    txtQtyTotal.Text = selEntity.qty_total.ToString();

                    //เก็บ max Qty ไว้เช็ค isValid
                    maxQty = selEntity.qty;
                }
            }
        }

        protected void ddlDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDate.SelectedItem.Value == defaultDDL || ddlDate.SelectedItem.Value == defaultDDL_NoData)
            {
                clearAddInput();
            }
            else
            {
                InventoryEntity entity = new InventoryEntity();
                String dateVal = ddlDate.SelectedItem.Value;
                DateTime create_date = DateTime.Now;
                foreach (InventoryEntity data in selEntityList)
                {
                    String code = data.create_date.ToString(gFormatDateValStr);
                    if (code == dateVal)
                    {
                        create_date = data.create_date;
                        break;
                    }
                }

                entity.sku = ddlSku.SelectedItem.Value;
                entity.create_date = create_date;

                InventoryService service = new InventoryService();
                List<InventoryEntity> entityList = service.GetDataByDate(entity);
                if (entityList.Count > 0)
                {
                    //เก็บ entity ตัวที่ Edit
                    selEntity = entityList[0];
                    txtName.Text = selEntity.name;
                    txtQtyTotal.Text = selEntity.qty_total.ToString();

                    //เก็บ max Qty ไว้เช็ค isValid
                    maxQty = selEntity.qty;
                }
            }
        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                InventoryEntity entity = selEntity;
                entity.qty_outbound = int.Parse(txtQtyOutbound.Text);

                entity.updateMode = entity.OutBound;
                entity.temp_inventory_id = DateTime.Now.ToString(gFormatDateValStr);

                addDataToUI(entity);
            }
            else
            {
                //Suma Alert !isValid
            }
        }

        protected void rptList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            InventoryEntity entity = (InventoryEntity)e.Item.DataItem;

            Label lblSku = (Label)e.Item.FindControl("lblSku");
            Label lblSerial = (Label)e.Item.FindControl("lblSerial");
            Label lblName = (Label)e.Item.FindControl("lblName");
            Label lblQtyTotla = (Label)e.Item.FindControl("lblQtyTotla");
            Label lblQtyOutbound = (Label)e.Item.FindControl("lblQtyOutbound");

            LinkButton lbnRemove = (LinkButton)e.Item.FindControl("lbnRemove");

            lblSku.Text = entity.sku;
            lblSerial.Text = entity.serial;
            lblName.Text = entity.name;
            lblQtyTotla.Text = entity.qty_total.ToString();
            lblQtyOutbound.Text = entity.qty_outbound.ToString();

            lbnRemove.CommandName = "Remove";
            lbnRemove.CommandArgument = entity.temp_inventory_id;
        }

        protected void rptList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
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
            String sku = ddlSku.SelectedItem.Value;
            String name = txtName.Text;
            String qty_total = txtQtyTotal.Text;
            String qty = txtQtyOutbound.Text;
            String serial = String.Empty;
            String create_date = String.Empty;
            ////////Check Empty
            unValid |= String.IsNullOrEmpty(sku);

            if (sel_type_id == 1)
            {
                serial = ddlSerial.SelectedItem.Value;
                unValid |= String.IsNullOrEmpty(serial);
            }
            else if (sel_type_id == 2)
            {
                create_date = ddlDate.SelectedItem.Value;
                unValid |= String.IsNullOrEmpty(create_date);
            }
            unValid |= String.IsNullOrEmpty(name);
            unValid |= String.IsNullOrEmpty(qty_total);
            unValid |= String.IsNullOrEmpty(qty);
            //Check Number < 0 and  Number < qty
            if (!String.IsNullOrEmpty(qty))
            {
                unValid |= (int.Parse(qty) < 0 || int.Parse(qty) > maxQty);
            }

            //Check Data ซ้ำ 
            if (unValid == false)
            {
                foreach (InventoryEntity data in gDatastore)
                {
                    if (sel_type_id == 1)
                    {
                        if (data.sku == sku && data.serial == serial)
                        {
                            unValid |= true;
                        }

                    }
                    else if (sel_type_id == 2)
                    {
                        if (data.sku == sku && data.create_date.ToString(gFormatDateValStr) == create_date)
                        {
                            unValid |= true;
                        }
                    }
                }
            }
            valid = !unValid;
            return valid;
        }
        protected void clearAddInput()
        {
            txtName.Text = "";
            txtQtyOutbound.Text = "";
            txtQtyTotal.Text = "";
        }
        protected void clearAddFrom()
        {
            clearAddInput();

            //***Set DropDownList
            setDropDownList();

            selEntityList = new List<InventoryEntity>();
            selEntity = new InventoryEntity();

            maxQty = 0;
            txtName.Text = "";
            txtName.ReadOnly = true;
            txtQtyTotal.Text = "";
            txtQtyTotal.ReadOnly = true;
            txtQtyOutbound.Text = "";

        }
        public void addDataToUI(InventoryEntity entity)
        {
            gDatastore.Add(entity);
            resultList.DataSource = gDatastore;
            resultList.DataBind();

            clearAddFrom();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (gDatastore.Count > 0)
            {
                int success = 0;
                //Update Inventory set QTY_TOTAL
                InventoryEntity entity = new InventoryEntity();
                entity.updateMode = entity.OutBound;
                entity.inventoryEntityList = getDsUpdateQtyTotla(gDatastore);
                InventoryService inventoryService = new InventoryService();
                success += inventoryService.UpdateQtyTotle(entity);

                //Insert InventoryLog 
                InventoryLogEntity entityLog = new InventoryLogEntity();
                entityLog.updateMode = entity.OutBound;
                entityLog.inventoryLogEntityList = getDsIndertInventoryLog(gDatastore);
                InventoryLogService inventoryLogService = new InventoryLogService();
                success += inventoryLogService.InsertData(entityLog);

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
        protected List<InventoryEntity> getDsUpdateQtyTotla(List<InventoryEntity> datastore)
        {
            DateFormat dateFormat = new DateFormat();

            List<InventoryEntity> uDatastiore = new List<InventoryEntity>();
            foreach (InventoryEntity data in datastore)
            {
                data.updateMode = data.OutBound;
                data.qty_total = data.qty_total - data.qty_outbound;
                data.modify_by = int.Parse(lblRequestorID.Text);
                data.modify_date = dateFormat.EngFormatDateToSQL(DateTime.Now);
                uDatastiore.Add(data);
            }

            return uDatastiore;
        }

        protected List<InventoryLogEntity> getDsIndertInventoryLog(List<InventoryEntity> datastore)
        {
            DateFormat dateFormat = new DateFormat();

            List<InventoryLogEntity> uDatastiore = new List<InventoryLogEntity>();
            foreach (InventoryEntity data in datastore)
            {
                InventoryLogEntity entity = new InventoryLogEntity();
                entity.updateMode = data.OutBound;
                entity.inventory_id = data.inventory_id;
                entity.branch_id = data.branch_id;
                entity.name = data.name;
                entity.qty = data.qty_outbound;
                entity.sku = data.sku;
                entity.serial = data.serial;
                entity.type_id = data.type_id;
                entity.category_id = data.category_id;
                entity.create_by = int.Parse(lblRequestorID.Text);
                entity.create_date = dateFormat.EngFormatDateToSQL(DateTime.Now);
                //entity.modify_by { get; set; }
                //entity.modify_date { get; set; }
                entity.is_active = data.is_active;
                entity.is_delete = data.is_delete;

                uDatastiore.Add(entity);
            }

            return uDatastiore;
        }

    }
}