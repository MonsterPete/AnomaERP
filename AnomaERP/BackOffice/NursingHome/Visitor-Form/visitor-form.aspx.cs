﻿using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service.SiteVisit;

namespace AnomaERP.BackOffice.NursingHome
{
    public partial class visitor_form : System.Web.UI.Page
    {
        int visitor_id = 0;
        int branch_id = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.visitor_id = 0;
                if (Request.QueryString["visitor_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["visitor_ID"]) > 0)
                    {
                        this.visitor_id = int.Parse(Request.QueryString["visitor_ID"].ToString());
                    }
                }

                this.branch_id = 0;
                if (Request.QueryString["branch_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["branch_ID"]) > 0)
                    {
                        this.branch_id = int.Parse(Request.QueryString["branch_ID"].ToString());
                    }
                }
            }
        }

        private SiteVisitEntity getEntityData()
        {
            SiteVisitEntity entity = new SiteVisitEntity();
            entity.visitor_id = this.visitor_id;
            entity.branch_id = this.branch_id;
            entity.firstname = txtFirstname.Text;
            entity.lastname = txtLastname.Text;
            entity.revice_from = txtReviceFrom.Text;
            entity.phone = txtPhone.Text;
            entity.comment = "";
            entity.date_of_visit = Convert.ToDateTime(txtVisitDate.Text);
            entity.date_of_appointment = Convert.ToDateTime(txtAppointmentDate.Text);
            entity.price_listed = int.Parse(txtPriceListed.Text);
            entity.symptom = txtSymptom.Text;

            return entity;
        }
        private Boolean isValid()
        {
            Boolean valid = true;
            string date_of_visit = txtVisitDate.Text;
            string date_of_appointment = txtAppointmentDate.Text;
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string phone = txtPhone.Text;
            
            valid &= string.IsNullOrWhiteSpace(date_of_visit);
            valid &= string.IsNullOrWhiteSpace(date_of_appointment);
            valid &= string.IsNullOrWhiteSpace(firstname);
            valid &= string.IsNullOrWhiteSpace(lastname);
            valid &= string.IsNullOrWhiteSpace(phone);
            
            return valid;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                SiteVisitEntity entity = getEntityData();
                SiteVisitService siteVisitService = new SiteVisitService();
                //if (siteVisitService.InsertData(entity) > 0)
                //{
                //}
                //else
                //{
                //}
            }
            else
            {
            }
            ////if (branchBedService.InsertDataMore(branchBedEntities) > 0)
            ////{
            ////    Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/room-setup.aspx?branch_id=" + lblBranchID.Text + "&floor_id=" + lblFloorID.Text);
            ////}
            ////else
            ////{
            ////    Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/room-setup.aspx?branch_id=" + lblBranchID.Text + "&floor_id=" + lblFloorID.Text);
            ////}
        }
    }
}