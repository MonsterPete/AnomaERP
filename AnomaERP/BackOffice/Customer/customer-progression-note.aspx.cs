using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Customer;

namespace AnomaERP.BackOffice.Customer
{
    public partial class customer_progression_note : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["visit_id"] != null && Request.QueryString["customer_id"] != null)
                {
                    if (int.Parse(Request.QueryString["visit_id"]) > 0 && int.Parse(Request.QueryString["customer_id"]) > 0)
                    {
                        GetDataProgressNote(int.Parse(Request.QueryString["visit_id"]));
                    }
                }
            }
        }

        public void GetDataProgressNote(int visit_id)
        {
            ProgressNoteEntity progressNoteEntity = new ProgressNoteEntity();
            CustomerService customerService = new CustomerService();
            progressNoteEntity = customerService.GetDataProgressNote(visit_id);
            SetDataToUI(progressNoteEntity);
        }

        public void SetDataToUI(ProgressNoteEntity progressNoteEntity)
        {
            lblProgressNoteId.Text = "0";
            if (progressNoteEntity != null)
            {
                lblProgressNoteId.Text = progressNoteEntity.progress_note_id.ToString();
                txtT_C.Text = progressNoteEntity.t_c.ToString();
                txtP_Min.Text = progressNoteEntity.p_min.ToString("N2");
                txtR_Min.Text = progressNoteEntity.r_min.ToString("N2");
                txtBP_mmHg.Text = progressNoteEntity.bp_mmhg.ToString("N2");
                txtO2Sat_Percent.Text = progressNoteEntity.o2sat_percent.ToString("N2");
                txtBW_kg.Text = progressNoteEntity.bw_kg.ToString("N2");
                txtHT_Cm.Text = progressNoteEntity.ht_cm.ToString("N2");
                txtBMI_Index.Text = progressNoteEntity.bm_index.ToString("N2");
                txtDescription.Text = progressNoteEntity.Description;
            }
        }

        protected void lbnBack_Click(object sender, EventArgs e)
        {
            string customer_id = Request.QueryString["customer_id"].ToString();
            Response.Redirect("/BackOffice/Customer/customer-visitor.aspx?customer_id=" + customer_id, false);
        }


        public ProgressNoteEntity getDataFromUI()
        {
            ProgressNoteEntity progressNoteEntity = new ProgressNoteEntity();

            progressNoteEntity.progress_note_id = int.Parse(lblProgressNoteId.Text);
            progressNoteEntity.visit_id = int.Parse(Request.QueryString["visit_id"]);
            progressNoteEntity.t_c = decimal.Parse(txtT_C.Text);
            progressNoteEntity.p_min = decimal.Parse(txtP_Min.Text);
            progressNoteEntity.r_min = decimal.Parse(txtR_Min.Text);
            progressNoteEntity.bp_mmhg = decimal.Parse(txtBP_mmHg.Text);
            progressNoteEntity.o2sat_percent = decimal.Parse(txtO2Sat_Percent.Text);
            progressNoteEntity.bw_kg = decimal.Parse(txtBW_kg.Text);
            progressNoteEntity.ht_cm = decimal.Parse(txtHT_Cm.Text);
            progressNoteEntity.bm_index = decimal.Parse(txtBMI_Index.Text);
            progressNoteEntity.Description = txtDescription.Text;

            return progressNoteEntity;
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            ProgressNoteEntity progressNoteEntity = new ProgressNoteEntity();
            progressNoteEntity = getDataFromUI();

            int success = 0;
            if (int.Parse(lblProgressNoteId.Text) > 0 )
            {
                success = customerService.UpdateProgressNote(progressNoteEntity);
            }
            else
            {
                success = customerService.InsertProgressNote(progressNoteEntity);
            }

            if (success > 0 )
            {
                string customer_id = Request.QueryString["customer_id"].ToString();
                Response.Redirect("/BackOffice/Customer/customer-visitor.aspx?customer_id=" + customer_id, false);
            }
        }
    }
}