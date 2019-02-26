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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblVisitorID.Text = "0";
                if (Request.QueryString["visitor_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["visitor_ID"]) > 0)
                    {
                        lblVisitorID.Text = Request.QueryString["visitor_ID"].ToString();
                        SetEntityData(int.Parse(lblVisitorID.Text));
                    }
                }

                lblBranchID.Text = "1"; //Suma fix for Test
                if (Request.QueryString["branch_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["branch_ID"]) > 0)
                    {
                        lblBranchID.Text = Request.QueryString["branch_ID"].ToString();
                    }
                }
            }
        }
        private void SetEntityData(int visitor_id)
        {
            SiteVisitEntity entity = null;
            SiteVisitService siteVisitService = new SiteVisitService();
            entity = siteVisitService.GetDataByID(visitor_id);

            lblVisitorID.Text = entity.visitor_id.ToString();
            lblBranchID.Text = entity.branch_id.ToString();
            txtFirstname.Text = entity.firstname;
            txtFirstname.Text = entity.firstname;
            txtLastname.Text = entity.lastname;
            txtReviceFrom.Text = entity.revice_from.ToString();
            txtPhone.Text = entity.phone;

            txtVisitDate.Text = entity.date_of_visit.ToString("yyyy-MM-dd");
            txtAppointmentDate.Text = entity.date_of_appointment.ToString("yyyy-MM-dd");

            txtPriceListed.Text = entity.price_listed.ToString();
            txtSymptom.Text = entity.symptom;

            if (entity.reservation == true)
            {
                rdoReservation.Checked = true;
            }
            else if (entity.reservation == false)
            {
                rdoUnReservation.Checked = true;
            }
        }

        private SiteVisitEntity getEntityData()
        {
            DateFormat dateFormat = new DateFormat();
            SiteVisitEntity entity = new SiteVisitEntity();
            entity.visitor_id = int.Parse(lblVisitorID.Text);
            entity.branch_id = int.Parse(lblBranchID.Text);
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
            Boolean unValid = false, valid = true;
            String date_of_visit = txtVisitDate.Text;
            String date_of_appointment = txtAppointmentDate.Text;
            String firstname = txtFirstname.Text;
            String lastname = txtLastname.Text;
            String phone = txtPhone.Text;

            unValid |= String.IsNullOrEmpty(date_of_visit);
            unValid |= String.IsNullOrEmpty(date_of_appointment);
            unValid |= String.IsNullOrEmpty(firstname);
            unValid |= String.IsNullOrEmpty(lastname);
            unValid |= String.IsNullOrEmpty(phone);

            valid = !unValid;
            return valid;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Suma Alert Confirm
            if (isValid() == true)
            {
                SiteVisitEntity entity = getEntityData();
                SiteVisitService siteVisitService = new SiteVisitService();

                int success = 0;
                if (int.Parse(lblVisitorID.Text) > 0)
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
            else
            {
                //Suma Alert !isValid
            }
        }
    }
}