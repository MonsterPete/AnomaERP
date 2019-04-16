using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Definitions;
using Entity;
using Entity.Customer;
using Service;
using Service.Customer;

namespace AnomaERP.BackOffice.Customer
{
    public partial class customer_visitor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CustomerService customerService = new CustomerService();
                CustomerEntity customerEntity = new CustomerEntity();
                customerEntity = customerService.GetDataByID(int.Parse(Request.QueryString["customer_id"].ToString()));
                lblCustomerName.Text = customerEntity.firstname + "   " + customerEntity.lastname;
                lblHNCode.Text = customerEntity.HN_no;
                lblIdCard.Text = customerEntity.id_card;
                lblPhone.Text = customerEntity.tel;
                lblShowDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                setDataToRpt();
            }
        }

        private void setDataToRpt()
        {
            List<VisitEntity> visitEntities = new List<VisitEntity>();
            VisitService visitService = new VisitService();
            visitEntities = visitService.GetDataListByCustomerID(int.Parse(Request.QueryString["customer_id"].ToString()));
            rptCustomerList.DataSource = visitEntities;
            rptCustomerList.DataBind();
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            VisitEntity visitEntity = new VisitEntity();
            VisitService visitService = new VisitService();
            visitEntity.customer_id = int.Parse(Request.QueryString["customer_id"].ToString());
            visitEntity.branch_id = Master.branchEntity.branch_id;
            if (AN.Checked)
            {
                visitEntity.running_number_id = 3;
                visitEntity.visit_type = 3;
            }
            if (VN.Checked)
            {
                visitEntity.running_number_id = 4;
                visitEntity.visit_type = 4;
            }

            visitService.InsertData(visitEntity);
            setDataToRpt();
        }

        protected void rptCustomerList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            VisitEntity visitEntity = (VisitEntity)e.Item.DataItem;

            Label lblVisitorCode = (Label)e.Item.FindControl("lblVisitorCode");
            Label lblDate = (Label)e.Item.FindControl("lblDate");
            Label lblTime = (Label)e.Item.FindControl("lblTime");
            HtmlInputRadioButton rptAN = (HtmlInputRadioButton)e.Item.FindControl("rptAN");
            HtmlInputRadioButton rptVN = (HtmlInputRadioButton)e.Item.FindControl("rptVN");

            lblVisitorCode.Text = visitEntity.visit_code;
            lblDate.Text = visitEntity.create_date.ToString("dd-MM-yyyy");
            lblTime.Text = visitEntity.create_date.ToString("HH-mm");
            if (visitEntity.visit_type == 3)
            {
                rptAN.Checked = true;
            }
            else
            {
                rptVN.Checked = true;
            }
            rptAN.Disabled = true;
            rptVN.Disabled = true;
        }
    }
}