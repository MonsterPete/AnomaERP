using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service.SiteVisit;
using Definitions;

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
            DateFormat dateFormat = new DateFormat();
            SiteVisitEntity entity = new SiteVisitEntity();
            entity.visitor_id = this.visitor_id;
            entity.branch_id = this.branch_id;
            entity.firstname = txtFirstname.Text;
            entity.lastname = txtLastname.Text;
            entity.revice_from = txtReviceFrom.Text;
            entity.phone = txtPhone.Text;
            entity.comment = "";
            entity.date_of_visit = dateFormat.EngFormatDateToSQL(DateTime.Parse(txtVisitDate.Text));
            entity.date_of_appointment = dateFormat.EngFormatDateToSQL(DateTime.Parse(txtAppointmentDate.Text));
            entity.price_listed = int.Parse(txtPriceListed.Text);
            entity.symptom = txtSymptom.Text;

            if (rdoReservation.Checked == true)
            {
                entity.reservation = true;
            }
            else if (rdoUnReservation.Checked == true)
            {
                entity.reservation = false;
            }

            return entity;
        }
        private Boolean isValid()
        {
            Boolean unValid = true, valid = true;
            string date_of_visit = txtVisitDate.Text;
            string date_of_appointment = txtAppointmentDate.Text;
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string phone = txtPhone.Text;

            unValid &= string.IsNullOrWhiteSpace(date_of_visit);
            unValid &= string.IsNullOrWhiteSpace(date_of_appointment);
            unValid &= string.IsNullOrWhiteSpace(firstname);
            unValid &= string.IsNullOrWhiteSpace(lastname);
            unValid &= string.IsNullOrWhiteSpace(phone);

            valid = !unValid;
            return valid;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                SiteVisitEntity entity = getEntityData();
                SiteVisitService siteVisitService = new SiteVisitService();
                
                int success = 0;
                if (this.visitor_id > 0)
                {
                    success = siteVisitService.UpdateData(entity);
                }
                else
                {
                    success = siteVisitService.InsertData(entity);
                }

                if (success > 0)
                {
                    Response.Redirect("/BackOffice/NursingHome/Visitor-Form/index.aspx", true);
                }
            }
            else //Dont't have Require Field
            {
            }
        }
    }
}