using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Entity;
using Service.Employee;

namespace AnomaERP.BackOffice.Role
{
    public partial class role_assign_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDataToUI(setCondition());
            }
        }

        public void setDataToUI(EmployeeEntity employeeEntity)
        {
            EmployeeService employeeService = new EmployeeService();
            List<EmployeeEntity> employeeEntities = new List<EmployeeEntity>();

            employeeEntities = employeeService.GetDataByCondition(employeeEntity);

            if (employeeEntities.Count > 0)
            {
                rptEmployeeList.DataSource = employeeEntities;
                rptEmployeeList.DataBind();
            }
            else
            {
                rptEmployeeList.DataSource = null;
                rptEmployeeList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            setDataToUI(setCondition());
        }

        public EmployeeEntity setCondition()
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();

            employeeEntity.nickname = txtSearch.Text;


            return employeeEntity;
        }


        protected void btnCreateAssignment_Click(object sender, EventArgs e)
        {
            Response.Redirect("/BackOffice/Role/role-assign-create.aspx?employee_id=0");
        }

        protected void rptEmployeeList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            EmployeeEntity employeeEntity = (EmployeeEntity)e.Item.DataItem;
            Label lblemployeeID = (Label)e.Item.FindControl("lblemployeeID");
            Label lblPositionName = (Label)e.Item.FindControl("lblPositionName");
            Label lblemployeeName = (Label)e.Item.FindControl("lblemployeeName");
            Label lblAssignmentStatus = (Label)e.Item.FindControl("lblAssignmentStatus");
            Label lblCostCenter = (Label)e.Item.FindControl("lblCostCenter");


            LinkButton lbnStatus = (LinkButton)e.Item.FindControl("lbnStatus");
            HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");
            HtmlInputCheckBox chkStatus = (HtmlInputCheckBox)e.Item.FindControl("chkStatus");

            LinkButton lbnEdit = (LinkButton)e.Item.FindControl("lbnEdit");
            LinkButton lbnDelete = (LinkButton)e.Item.FindControl("lbnDelete");

            lblemployeeID.Text = employeeEntity.employee_id.ToString();
            lblPositionName.Text = employeeEntity.position_name.ToString();
            lblemployeeName.Text = employeeEntity.firstname + " " + employeeEntity.lastname + " (" + employeeEntity.nickname + ")" ;
            lblAssignmentStatus.Text = employeeEntity.working_time_name.ToString();
            lblCostCenter.Text = "";

            lbnEdit.CommandArgument = employeeEntity.employee_id.ToString();
            lbnEdit.CommandName = "edit";

            lbnDelete.CommandArgument = employeeEntity.employee_id.ToString();
            lbnDelete.CommandName = "delete";

            lbnStatus.CommandArgument = employeeEntity.employee_id.ToString();
            hdfStatus.Value = employeeEntity.is_active.ToString();
            lbnStatus.CommandName = "status";

            if (employeeEntity.is_active == true)
            {
                chkStatus.Attributes.Add("checked", "checked");
            }
            else if (employeeEntity.is_active == false)
            {
                chkStatus.Attributes.Remove("checked");
            }

        }

        protected void rptEmployeeList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();
            EmployeeService employeeService = new EmployeeService();
            Label lblemployeeID = (Label)e.Item.FindControl("lblemployeeID");
            employeeEntity.employee_id = int.Parse(lblemployeeID.Text);

            if (e.CommandName == "status")
            {
                HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");

                if (hdfStatus.Value == "True")
                {
                    employeeEntity.is_active = false;
                }
                else if (hdfStatus.Value == "False")
                {
                    employeeEntity.is_active = true;
                }

                employeeService.UpdateStatusData(employeeEntity);
            }
            else if (e.CommandName == "edit")
            {
                Response.Redirect("/BackOffice/Role/role-assign-create.aspx?employee_id=" + e.CommandArgument);
            }
            else if (e.CommandName == "delete")
            {
                employeeEntity.is_delete = true;
            }

            setDataToUI(setCondition());
        }
    }
}