﻿using Entity;
using Service.BedManagement;
using Service.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnomaERP.BackOffice.Bed_Management.Bed
{
    public partial class bed_entity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BedCustomerService bedCustomerService = new BedCustomerService();
                rptBedEntity.DataSource = bedCustomerService.SelectBedCustomerForBedEntity(setDataSearch());
                rptBedEntity.DataBind();
                CustomerService customerService = new CustomerService();
                ddlCustomer.DataSource = customerService.GetDDLCustomerForAssginBed(1);
            }
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
            LinkButton lbnAssign = (LinkButton)e.Item.FindControl("lbnAssign");

            lblBranch.Text = bedCustomerEntity.branch_name;
            lblFloor.Text = bedCustomerEntity.floor_name;
            lblRoom.Text = bedCustomerEntity.room_name;
            lblBed.Text = bedCustomerEntity.bed_name;
            lblStatus.Text = bedCustomerEntity.status_bed_id.ToString();
            if (bedCustomerEntity.is_have_customer)
            {
                lblCustomer.Text = bedCustomerEntity.fullname;
                lbnAssign.Visible = false;
            }
            else
            {
                lblCustomer.Visible = false;
            }
            lbnAssign.CommandName = "Assign";
            lbnAssign.CommandArgument = bedCustomerEntity.branch_name;
        }

        protected void rptBedEntity_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Assign")
            {
                lblStatus.Text = e.CommandArgument.ToString();
                ScriptManager.RegisterClientScriptBlock((source as Control), this.GetType(), "Pop", "openModal();", true);
            }
        }
    }
}