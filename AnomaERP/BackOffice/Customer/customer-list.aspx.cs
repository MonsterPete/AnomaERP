using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service.Customer;
using Entity;

namespace AnomaERP.BackOffice.Customer
{
    public partial class customer_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDataToUI(setCondition());
            }
        }

        public void setDataToUI(CustomerEntity customerEntity)
        {
            CustomerService customerService = new CustomerService();
            List<CustomerEntity> customerEntities = new List<CustomerEntity>();

            customerEntities = customerService.GetCustomerRegistationByCondition(customerEntity);
            rptCustomerList.DataSource = customerEntities;
            rptCustomerList.DataBind();
        }

        public CustomerEntity setCondition()
        {
            CustomerEntity customerEntity = new CustomerEntity();

            customerEntity.firstname = txtSearch.Text.Trim().Replace("-", "");
            customerEntity.branch_id = Master.branchEntity.branch_id;

            if (ddlStatus.SelectedValue != "")
            {
                customerEntity.is_active = Boolean.Parse(ddlStatus.SelectedValue);
            }
            else
            {
                customerEntity.is_active = null;
            }

            return customerEntity;
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            setDataToUI(setCondition());
        }

        protected void rptCustomerList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            CustomerEntity customerEntity = (CustomerEntity)e.Item.DataItem;

            Label lblCustomerID = (Label)e.Item.FindControl("lblCustomerID");
            Label lblHnNo = (Label)e.Item.FindControl("lblHnNo");
            Label lblCustomerName = (Label)e.Item.FindControl("lblCustomerName");
            Label lblPhoneNo = (Label)e.Item.FindControl("lblPhoneNo");
            Label lblIdCard = (Label)e.Item.FindControl("lblIdCard");
            LinkButton lblStatus = (LinkButton)e.Item.FindControl("lblStatus");
            LinkButton lbnEdit = (LinkButton)e.Item.FindControl("lbnEdit");
            LinkButton lbnVisitor = (LinkButton)e.Item.FindControl("lbnVisitor");

            lblCustomerID.Text = customerEntity.customer_id.ToString();
            lblHnNo.Text = customerEntity.HN_no;
            lblCustomerName.Text = customerEntity.firstname + ' ' + customerEntity.lastname;
            lblPhoneNo.Text = customerEntity.tel;
            lblIdCard.Text = customerEntity.id_card;

            if (customerEntity.is_active == true)
            {
                lblStatus.Text = "Active";
            }
            else
            {
                lblStatus.Text = "InActive";
            }

            lblStatus.CommandArgument = customerEntity.customer_id.ToString();
            lblStatus.CommandName = "status";

            lbnEdit.CommandArgument = customerEntity.customer_id.ToString();
            lbnEdit.CommandName = "Edit";
            lbnVisitor.CommandArgument = customerEntity.customer_id.ToString();
            lbnVisitor.CommandName = "Visitor";
        }

        protected void rptCustomerList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("/BackOffice/Customer/customer-information.aspx?customer_id=" + e.CommandArgument);
            }
            else if (e.CommandName == "Visitor")
            {
                Response.Redirect("/BackOffice/Customer/customer-visitor.aspx?customer_id=" + e.CommandArgument);
            }

            LinkButton lblStatus = (LinkButton)e.Item.FindControl("lblStatus");
            CustomerEntity customerEntity = new CustomerEntity();
            CustomerService customerService = new CustomerService();
            customerEntity.customer_id = int.Parse(e.CommandArgument.ToString());

            if (e.CommandName == "status")
            {
                Session["customerEntity"] = null;
                if (lblStatus.Text == "Active")
                {
                    customerEntity.is_active = false;
                }
                else
                {
                    customerEntity.is_active = true;
                }

                Session["customerEntity"] = customerEntity;
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "none", "<script>$('#myModal').modal('show');</script>", false);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerEntity customerEntity = new CustomerEntity();
            CustomerService customerService = new CustomerService();

            customerEntity = (CustomerEntity)Session["customerEntity"];
            if (customerService.UpdateCustomerStatus(customerEntity) > 0)
            {
                setDataToUI(setCondition());
            }
        }
    }
}