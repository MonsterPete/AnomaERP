using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.SiteVisit;


namespace AnomaERP.BackOffice.NursingHome
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDataToUI(setCondition());
            }
        }

        protected void rptList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            SiteVisitEntity entity = (SiteVisitEntity)e.Item.DataItem;

            //Label lblVisitorID = (Label)e.Item.FindControl("lblVisitorID");
            Label lblAppointmentDate = (Label)e.Item.FindControl("lblAppointmentDate");
            Label lblVisitDate = (Label)e.Item.FindControl("lblVisitDate");
            Label lblFullName = (Label)e.Item.FindControl("lblFullName");
            Label lblPhone = (Label)e.Item.FindControl("lblPhone");
            Label lblReserve = (Label)e.Item.FindControl("lblReserve");

            LinkButton lbnEdit = (LinkButton)e.Item.FindControl("lbnEdit");
            LinkButton lbnRemove = (LinkButton)e.Item.FindControl("lbnRemove");

            //HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");

            //lblVisitorID.Text = entity.row_index.ToString();
            lblAppointmentDate.Text = entity.date_of_appointment.ToString("dd'/'MM'/'yyyy");
            lblVisitDate.Text = entity.date_of_visit.ToString("dd'/'MM'/'yyyy");
            lblFullName.Text = entity.firstname + " " + entity.lastname;
            lblPhone.Text = entity.phone;

            lblReserve.Text = (entity.reservation == true) ? "Reserved" : "No Reserved";
            //hdfStatus.Value = entity.is_active.ToString();

            lbnEdit.CommandName = "Edit";
            lbnEdit.CommandArgument = entity.visitor_id.ToString();
            lbnRemove.CommandName = "Remove";
            lbnRemove.CommandArgument = entity.visitor_id.ToString();
        }

        protected void rptList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("/BackOffice/NursingHome/Visitor-Form/visitor-form.aspx?visitor_id=" + e.CommandArgument);
            }
            else if (e.CommandName == "Remove")
            {
                SiteVisitEntity entity = new SiteVisitEntity();
                SiteVisitService service = new SiteVisitService();

                entity.visitor_id = Int32.Parse(e.CommandArgument.ToString());

                if (service.RemoveData(entity) > 0)
                {
                    setDataToUI(setCondition());
                }
            }
        }

        public void setDataToUI(SiteVisitEntity entity)
        {
            SiteVisitService service = new SiteVisitService();
            List<SiteVisitEntity> entityList = new List<SiteVisitEntity>();

            entityList = service.GetDataByCondition(entity);
            
            resultList.DataSource = entityList;
            resultList.DataBind();
        }

        public SiteVisitEntity setCondition()
        {
            SiteVisitEntity entity = new SiteVisitEntity();
            
            String txtReserved = fltReserved.Text;
            Boolean reserved = (txtReserved == "Reserved") ? true : false;

            entity.sch_customer_name = txtSearch.Text;
            entity.sch_reservation = reserved;
            return entity;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            setDataToUI(setCondition());
        }
    }
}