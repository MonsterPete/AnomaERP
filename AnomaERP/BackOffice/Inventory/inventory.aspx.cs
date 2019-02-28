using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Branch;
using Service.Category;
using Service.Inventory;

namespace AnomaERP.BackOffice.Inventory
{
    public partial class inventory : System.Web.UI.Page
    {
        private static String defaultDDL_NoData = "ALL";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //***Set Branch
                lblEntityID.Text = "1"; //Suma fix for Test
                if (Request.QueryString["entity_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["entity_ID"]) > 0)
                    {
                        lblEntityID.Text = Request.QueryString["entity_ID"].ToString();
                    }
                }
                //***Set DropDownList
                setDropDownList();

                setDataToUI(setCondition());
            }
        }

        protected void setDropDownList()
        {
            ddlBranch.Items.Clear();
            ddlCategory.Items.Clear();
            ddlBranch.Items.Add(new ListItem(defaultDDL_NoData, defaultDDL_NoData));
            ddlCategory.Items.Add(new ListItem(defaultDDL_NoData, defaultDDL_NoData));

            //init DDL Branch
            BranchService bService = new BranchService();
            List<BranchEntity> bEntityList = bService.GetDataByEntity(int.Parse(lblEntityID.Text));
            foreach (BranchEntity b in bEntityList)
            {
                ddlBranch.Items.Add(new ListItem(b.branch_name, b.branch_id.ToString()));
            }

            //init DDL Category
            CategoryService cService = new CategoryService();
            List<CategoryEntity> cEntityList = cService.GetDataAll();
            foreach (CategoryEntity c in cEntityList)
            {
                ddlCategory.Items.Add(new ListItem(c.category_name, c.category_id.ToString()));
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            setDataToUI(setCondition());
        }

        public void setDataToUI(InventoryEntity entity)
        {
            InventoryService service = new InventoryService();
            List<InventoryEntity> entityList = new List<InventoryEntity>();

            entityList = service.GetDataByCondition(entity);

            resultList.DataSource = entityList;
            resultList.DataBind();
        }

        public InventoryEntity setCondition()
        {
            InventoryEntity entity = new InventoryEntity();
            entity.sch_word = txtSearch.Text.Trim();
            if(ddlBranch.SelectedItem.Value == defaultDDL_NoData)
            {
                entity.sch_branch_id = null;
            }
            else
            {
                entity.sch_branch_id = int.Parse(ddlBranch.SelectedItem.Value);
            }

            if (ddlCategory.SelectedItem.Value == defaultDDL_NoData)
            {
                entity.sch_category_id = null;
            }
            else
            {
                entity.sch_category_id = int.Parse(ddlCategory.SelectedItem.Value);
            }
            
            return entity;
        }

        protected void rptList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            InventoryEntity entity = (InventoryEntity)e.Item.DataItem;

            Label lblSku = (Label)e.Item.FindControl("lblSku");
            Label lblSerial = (Label)e.Item.FindControl("lblSerial");
            Label lblName = (Label)e.Item.FindControl("lblName");
            Label lblType = (Label)e.Item.FindControl("lblType");
            Label lblQty = (Label)e.Item.FindControl("lblQty");
            Label lblOnHand = (Label)e.Item.FindControl("lblOnHand");

            lblSku.Text = entity.sku;
            lblSerial.Text = entity.serial;
            lblName.Text = entity.name;
            lblType.Text = entity.type_name;
            lblQty.Text = entity.qty_total.ToString();
            lblOnHand.Text = entity.qty_on_hand.ToString();
        }

        protected void rptList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
        }
        /* -- get control id from AJAX Postback -- */
        ////String postBackControlID = getPostBackControlID();
        ////private string getPostBackControlID()
        ////{
        ////    Control control = null;
        ////    //first we will check the "__EVENTTARGET" because if post back made by       the controls
        ////    //which used "_doPostBack" function also available in Request.Form collection.
        ////    string ctrlname = Page.Request.Params["__EVENTTARGET"];
        ////    if (ctrlname != null && ctrlname != String.Empty)
        ////    {
        ////        control = Page.FindControl(ctrlname);
        ////    }
        ////    // if __EVENTTARGET is null, the control is a button type and we need to
        ////    // iterate over the form collection to find it
        ////    else
        ////    {
        ////        string ctrlStr = String.Empty;
        ////        Control c = null;
        ////        foreach (string ctl in Page.Request.Form)
        ////        {
        ////            //handle ImageButton they having an additional "quasi-property" in their Id which identifies
        ////            //mouse x and y coordinates
        ////            if (ctl.EndsWith(".x") || ctl.EndsWith(".y"))
        ////            {
        ////                ctrlStr = ctl.Substring(0, ctl.Length - 2);
        ////                c = Page.FindControl(ctrlStr);
        ////            }
        ////            else
        ////            {
        ////                c = Page.FindControl(ctl);
        ////            }
        ////            if (c is System.Web.UI.WebControls.Button ||
        ////                     c is System.Web.UI.WebControls.ImageButton)
        ////            {
        ////                control = c;
        ////                break;
        ////            }
        ////        }
        ////    }
        ////    if (control != null)
        ////    {
        ////        return control.ID;
        ////    }

        ////    else
        ////    {
        ////        return "";
        ////    }
        ////}
    }
}