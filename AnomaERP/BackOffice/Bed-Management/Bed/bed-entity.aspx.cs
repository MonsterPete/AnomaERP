using Entity;
using Service.BedManagement;
using Service.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AnomaERP.BackOffice.Bed_Management.Bed
{
    public partial class bed_entity : System.Web.UI.Page
    {
        static int user_id = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDataToUI();

                SetDllCustomer();
            }
        }

        private void SetDllCustomer()
        {
            CustomerService customerService = new CustomerService();

            ddlCustomer.DataSource = customerService.GetDDLCustomerForAssginBed(1);
            ddlCustomer.DataTextField = "fullname";
            ddlCustomer.DataValueField = "customer_id";
            ddlCustomer.DataBind();
        }

        private void setDataToUI()
        {
            BedCustomerService bedCustomerService = new BedCustomerService();
            rptBedEntity.DataSource = bedCustomerService.SelectBedCustomerForBedEntity(setDataSearch());
            rptBedEntity.DataBind();
        }

        private BedCustomerEntity setDataSearch()
        {
            BedCustomerEntity bedCustomerEntity = new BedCustomerEntity();
            if (!string.IsNullOrEmpty(txtBranch.Text))
            {
                bedCustomerEntity.branch_name = txtBranch.Text;
            }
            if (!string.IsNullOrEmpty(txtCustomerName.Text))
            {
                bedCustomerEntity.fullname = txtCustomerName.Text;
            }
            if (!string.IsNullOrEmpty(txtFloor.Text))
            {
                bedCustomerEntity.floor_name = txtFloor.Text;
            }
            return bedCustomerEntity;
        }

        protected void rptBedEntity_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            BedCustomerEntity bedCustomerEntity = (BedCustomerEntity)e.Item.DataItem;

            Label lblBranch = (Label)e.Item.FindControl("lblBranch");
            Label lblFloor = (Label)e.Item.FindControl("lblFloor");
            Label lblRoom = (Label)e.Item.FindControl("lblRoom");
            Label lblBed = (Label)e.Item.FindControl("lblBed");
            Label lblCustomer = (Label)e.Item.FindControl("lblCustomer");
            Label lblStatus = (Label)e.Item.FindControl("lblStatus");
            #region Tools
            LinkButton lbnAssign = (LinkButton)e.Item.FindControl("lbnAssign");
            HtmlGenericControl manupnl = (HtmlGenericControl)e.Item.FindControl("manupnl");
            HtmlGenericControl AccessoryTool = (HtmlGenericControl)e.Item.FindControl("AccessoryTool");
            LinkButton lbnCustomerGoOutBed = (LinkButton)e.Item.FindControl("lbnCustomerGoOutBed");
            LinkButton lbnAdmit = (LinkButton)e.Item.FindControl("lbnAdmit");
            LinkButton lbnDeleteCustomer = (LinkButton)e.Item.FindControl("lbnDeleteCustomer");
            LinkButton lbnCustomerAddAccessory = (LinkButton)e.Item.FindControl("lbnCustomerAddAccessory");
            LinkButton lbnCustomerDeleteAccessory = (LinkButton)e.Item.FindControl("lbnCustomerDeleteAccessory");
            #endregion

            lblBranch.Text = bedCustomerEntity.branch_name;
            lblFloor.Text = bedCustomerEntity.floor_name;
            lblRoom.Text = bedCustomerEntity.room_name;
            lblBed.Text = bedCustomerEntity.bed_name;

            if (bedCustomerEntity.is_have_customer)
            {
                lblCustomer.Text = bedCustomerEntity.fullname;
                lbnAssign.Visible = false;
            }
            else
            {
                lblCustomer.Visible = false;
                manupnl.Visible = false;
                AccessoryTool.Visible = false;
            }
            
            #region Tool
            lbnAssign.CommandName = "Assign";
            lbnAssign.CommandArgument = bedCustomerEntity.bed_id.ToString() + "||" + bedCustomerEntity.bed_name;

            lbnCustomerGoOutBed.CommandName = "GoOutBed";
            lbnCustomerGoOutBed.CommandArgument = bedCustomerEntity.bed_customer_id + "||" + bedCustomerEntity.customer_id + "||" + bedCustomerEntity.bed_id;

            lbnAdmit.CommandName = "Admit";
            lbnAdmit.CommandArgument = bedCustomerEntity.bed_customer_id + "||" + bedCustomerEntity.customer_id + "||" + bedCustomerEntity.bed_id;

            lbnDeleteCustomer.CommandName = "DeleteCustomer";
            lbnDeleteCustomer.CommandArgument = bedCustomerEntity.bed_customer_id + "||" + bedCustomerEntity.customer_id + "||" + bedCustomerEntity.bed_id;


            lbnCustomerAddAccessory.CommandName = "AddAccessory";
            lbnCustomerAddAccessory.CommandArgument = bedCustomerEntity.bed_id.ToString();

            lbnCustomerDeleteAccessory.CommandName = "DeleteAccessory";
            lbnCustomerDeleteAccessory.CommandArgument = bedCustomerEntity.bed_id.ToString();
            #endregion
        }

        protected void rptBedEntity_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Assign")
            {
                string[] str1 = e.CommandArgument.ToString().Split("||".ToCharArray());
                string name = str1[2];
                string id = str1[0];
                hdfBedId.Value = id;
                hdfBedName.Value = name;
                ScriptManager.RegisterClientScriptBlock((source as Control), this.GetType(), "Pop", "openModal();", true);
            }
            else if (e.CommandName == "AddAccessory")
            {
                Response.Redirect("/BackOffice/Bed-Management/Bed/bed-add-accessory.aspx?bed_id=" + e.CommandArgument);
            }


            else if (e.CommandName == "DeleteAccessory")
            {
                Response.Redirect("/BackOffice/Bed-Management/Bed/bed-delete-accessory.aspx?bed_id=" + e.CommandArgument);
            }
            else
            {
                string[] str1 = e.CommandArgument.ToString().Split("||".ToCharArray());
                hdfBedId.Value = str1[4];
                hdfCustomerId.Value = str1[2];
                hdfBedCustomerId.Value = str1[0];

                if (e.CommandName == "GoOutBed")
                {
                    ScriptManager.RegisterClientScriptBlock((source as Control), this.GetType(), "Pop", "openModalGoOut();", true);
                }
                else if (e.CommandName == "Admit")
                {
                    ScriptManager.RegisterClientScriptBlock((source as Control), this.GetType(), "Pop", "openModalAdmit();", true);
                }
                else if (e.CommandName == "DeleteCustomer")
                {
                    ScriptManager.RegisterClientScriptBlock((source as Control), this.GetType(), "Pop", "openModalDeleteCustomer();", true);
                }
            }
        }

        protected void lbnComfirm_Click(object sender, EventArgs e)
        {
            BedCustomerService bedCustomerService = new BedCustomerService();
            bedCustomerService.InsertDataAndUpTBDateBedAndTBCustomer(preparDataInsert());
            setDataToUI();
            SetDllCustomer();
        }

        private BedCustomerEntity preparDataInsert()
        {
            BedCustomerEntity bedCustomerEntity = new BedCustomerEntity();
            bedCustomerEntity.bed_id = int.Parse(hdfBedId.Value);
            bedCustomerEntity.customer_id = int.Parse(ddlCustomer.SelectedValue);
            bedCustomerEntity.create_by = user_id;
            bedCustomerEntity.create_date = DateTime.Now;

            return bedCustomerEntity;
        }

        protected void lbnDeleteCustomer_Click(object sender, EventArgs e)
        {
            BedCustomerEntity bedCustomerEntity = new BedCustomerEntity();
            bedCustomerEntity.bed_customer_id = int.Parse(hdfBedCustomerId.Value);
            bedCustomerEntity.bed_id = int.Parse(hdfBedId.Value);
            bedCustomerEntity.customer_id = int.Parse(hdfCustomerId.Value);
            bedCustomerEntity.create_by = user_id;
            bedCustomerEntity.create_date = DateTime.Now;

            BedCustomerService bedCustomerService = new BedCustomerService();
            bedCustomerService.UpdateDeleteDataAndUpDeleteTBDateBedAndTBCustomer(bedCustomerEntity);
            setDataToUI();
            SetDllCustomer();
        }

        protected void lbnAdmit_Click(object sender, EventArgs e)
        {
            BedCustomerEntity bedCustomerEntity = new BedCustomerEntity();
            bedCustomerEntity.bed_customer_id = int.Parse(hdfBedCustomerId.Value);
            bedCustomerEntity.bed_id = int.Parse(hdfBedId.Value);
            bedCustomerEntity.customer_id = int.Parse(hdfCustomerId.Value);
            bedCustomerEntity.customer_id = int.Parse(hdfCustomerId.Value);
            bedCustomerEntity.create_by = user_id;
            bedCustomerEntity.create_date = DateTime.Now;
            bedCustomerEntity.is_admit = true;

            BedCustomerService bedCustomerService = new BedCustomerService();
            bedCustomerService.UpdateAdmitCustomer(bedCustomerEntity);
            setDataToUI();
            SetDllCustomer();
        }

        protected void lbnGoOutBed_Click(object sender, EventArgs e)
        {
            BedCustomerEntity bedCustomerEntity = new BedCustomerEntity();
            bedCustomerEntity.bed_customer_id = int.Parse(hdfBedCustomerId.Value);
            bedCustomerEntity.bed_id = int.Parse(hdfBedId.Value);
            bedCustomerEntity.customer_id = int.Parse(hdfCustomerId.Value);
            bedCustomerEntity.create_by = user_id;
            bedCustomerEntity.create_date = DateTime.Now;

            BedCustomerService bedCustomerService = new BedCustomerService();
            bedCustomerService.UpdateDeleteDataAndUpTBDateBedAndTBCustomer(bedCustomerEntity);
            setDataToUI();
            SetDllCustomer();
        }
    }
}