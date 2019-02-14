using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Employee;
using Definitions;
using Service.Role;
using Service.Working_time;

namespace AnomaERP.BackOffice.Role
{
    public partial class role_assign_create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblEmployeeID.Text = "0";
                if (Request.QueryString["employee_id"] != null)
                {
                    if (int.Parse(Request.QueryString["employee_id"]) > 0)
                    {
                        lblEmployeeID.Text = Request.QueryString["employee_id"].ToString();
                        SetDataToUI(int.Parse(lblEmployeeID.Text));
                    }
                }
                GetDataToddlPosition();
                GetDataToddlWorking_time();
                txtPassword.Attributes.Add("type", "password");
            }
        }

        public void SetDataToUI(int employee_id)
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();
            EmployeeService employeeService = new EmployeeService();

            employeeEntity = employeeService.GetDataByID(employee_id);

            lblEmployeeID.Text = employeeEntity.employee_id.ToString();
            txtUsername.Text = employeeEntity.username.ToString();
            txtPassword.Text = employeeEntity.password.ToString();
            txtEmail.Text = employeeEntity.email.ToString();
            txtPhone.Text = employeeEntity.phone.ToString();
            txtFirstname.Text = employeeEntity.firstname.ToString();
            txtLastname.Text = employeeEntity.lastname.ToString();
            txtNickname.Text = employeeEntity.nickname.ToString();

            ddlGender.SelectedValue = employeeEntity.gender.ToString();
            txtDateOdBirth.Text = employeeEntity.date_of_birth.ToString("yyyy-MM-dd");
            txtCitizenID.Text = employeeEntity.citizen_id.ToString();
            ddlPosition.SelectedValue = employeeEntity.position_id.ToString();
            ddlWorkingTime.SelectedValue = employeeEntity.working_time_id.ToString();

            if (employeeEntity.dateWorkEntity != null)
            {
                if (employeeEntity.dateWorkEntity.monday == true)
                {
                    chkMonday.Checked = true;
                }

                if (employeeEntity.dateWorkEntity.tuesday == true)
                {
                    chkTuesday.Checked = true;
                }

                if (employeeEntity.dateWorkEntity.wednesday == true)
                {
                    chkWednesday.Checked = true;
                }

                if (employeeEntity.dateWorkEntity.thuresday == true)
                {
                    chkThuresday.Checked = true;
                }

                if (employeeEntity.dateWorkEntity.friday == true)
                {
                    chkFriday.Checked = true;
                }

                if (employeeEntity.dateWorkEntity.saturday == true)
                {
                    chkSaturday.Checked = true;
                }

                if (employeeEntity.dateWorkEntity.sunday == true)
                {
                    chkSunday.Checked = true;
                }
            }


            if (employeeEntity.shifTimeEntity != null)
            {
                if (employeeEntity.shifTimeEntity.start_time_1 != null)
                {
                    txtStartTime1.Text = employeeEntity.shifTimeEntity.start_time_1.ToString();
                }

                if (employeeEntity.shifTimeEntity.end_time_1 != null)
                {
                    txtEndTime1.Text = employeeEntity.shifTimeEntity.end_time_1.ToString();
                }

                if (employeeEntity.shifTimeEntity.start_time_2 != null)
                {
                    txtStartTime2.Text = employeeEntity.shifTimeEntity.start_time_2.ToString();
                }

                if (employeeEntity.shifTimeEntity.end_time_2 != null)
                {
                    txtEndTime2.Text = employeeEntity.shifTimeEntity.end_time_2.ToString();
                }

                if (employeeEntity.shifTimeEntity.start_time_3 != null)
                {
                    txtStartTime3.Text = employeeEntity.shifTimeEntity.start_time_3.ToString();
                }

                if (employeeEntity.shifTimeEntity.end_time_3 != null)
                {
                    txtEndTime3.Text = employeeEntity.shifTimeEntity.end_time_3.ToString();
                }
            }        
        }

        protected void lblBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BackOffice/Role/role-assign-list.aspx");
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();
            EmployeeService employeeService = new EmployeeService();

            employeeEntity.employee_id = int.Parse(lblEmployeeID.Text);
            employeeEntity.username = txtUsername.Text;
            employeeEntity.password = txtPassword.Text;
            employeeEntity.email = txtEmail.Text;
            employeeEntity.phone = txtPhone.Text;
            employeeEntity.firstname = txtFirstname.Text;
            employeeEntity.lastname = txtLastname.Text;
            employeeEntity.nickname = txtNickname.Text;
            employeeEntity.gender = ddlGender.SelectedValue;

            DateFormat dateFormat = new DateFormat();

            if (string.IsNullOrEmpty(txtDateOdBirth.Text) == false)
            {
                employeeEntity.date_of_birth = dateFormat.EngFormatDateToSQL(DateTime.Parse(txtDateOdBirth.Text));
            }
            else
            {
                employeeEntity.date_of_birth = dateFormat.EngFormatDateToSQL(DateTime.Now);
            }

            employeeEntity.citizen_id = txtCitizenID.Text;
            employeeEntity.position_id = int.Parse(ddlPosition.SelectedValue);
            employeeEntity.working_time_id = int.Parse(ddlWorkingTime.SelectedValue);


            DateWorkEntity dateWorkEntity = new DateWorkEntity();
            if (chkMonday.Checked)
            {
                dateWorkEntity.monday = true;
            }

            if (chkTuesday.Checked)
            {
                dateWorkEntity.tuesday = true;
            }

            if (chkWednesday.Checked)
            {
               dateWorkEntity.wednesday = true;
            }

            if (chkThuresday.Checked)
            {
                dateWorkEntity.thuresday = true;
            }

            if (chkFriday.Checked)
            {
                dateWorkEntity.friday = true;
            }

            if (chkSaturday.Checked)
            {
                dateWorkEntity.saturday = true;
            }

            if (chkSunday.Checked)
            {
                dateWorkEntity.sunday = true;
            }

            dateWorkEntity.is_active = true;
            dateWorkEntity.is_delete = false;

            string date = "";

            ShifTimeEntity shifTimeEntity = new ShifTimeEntity();
            if (string.IsNullOrEmpty(txtStartTime1.Text) == false)
            {
                date = txtStartTime1.Text;
                shifTimeEntity.start_time_1 = TimeSpan.Parse(date); 
            }
            else
            {
                shifTimeEntity.start_time_1 = DateTime.Now.TimeOfDay;
            }

            if (string.IsNullOrEmpty(txtEndTime1.Text) == false)
            {
                date = txtEndTime1.Text;
                shifTimeEntity.end_time_1 = TimeSpan.Parse(date);
            }
            else
            {
                shifTimeEntity.end_time_1 = DateTime.Now.TimeOfDay;
            }


            if (string.IsNullOrEmpty(txtStartTime2.Text) == false)
            {
                date = txtStartTime2.Text;
                shifTimeEntity.start_time_2 = TimeSpan.Parse(date);
            }
            else
            {
                shifTimeEntity.start_time_2 = DateTime.Now.TimeOfDay;
            }

            if (string.IsNullOrEmpty(txtEndTime2.Text) == false)
            {
                date = txtEndTime2.Text;
                shifTimeEntity.end_time_2 = TimeSpan.Parse(date);
            }
            else
            {
                shifTimeEntity.end_time_2 = DateTime.Now.TimeOfDay;
            }

            if (string.IsNullOrEmpty(txtStartTime3.Text) == false)
            {
                date = txtStartTime3.Text;
                shifTimeEntity.start_time_3 = TimeSpan.Parse(date);
            }
            else
            {
                shifTimeEntity.start_time_3 = DateTime.Now.TimeOfDay;
            }

            if (string.IsNullOrEmpty(txtEndTime3.Text) == false)
            {
                date = txtEndTime3.Text;
                shifTimeEntity.end_time_3 = TimeSpan.Parse(date);

            }
            else
            {
                 shifTimeEntity.end_time_3 = DateTime.Now.TimeOfDay;

            }

            shifTimeEntity.is_active = true;
            shifTimeEntity.is_delete = false;

            employeeEntity.create_by = 1; 
            employeeEntity.create_date = dateFormat.EngFormatDateToSQL(DateTime.Now);
            employeeEntity.is_active = true;
            employeeEntity.is_delete = false;

            employeeEntity.dateWorkEntity = dateWorkEntity;
            employeeEntity.shifTimeEntity = shifTimeEntity;

            int success = 0;
            if (int.Parse( lblEmployeeID.Text) > 0 )
            {
                success = employeeService.UpdateData(employeeEntity);
            }
            else
            {
                success = employeeService.InsertData(employeeEntity);
            }

            if (success > 0)
            {
                Response.Redirect("~/BackOffice/Role/role-assign-list.aspx");
            }
        }


        public void GetDataToddlPosition()
        {
            List<PositionEntity> positionEntities = new List<PositionEntity>();
            PositionService positionService = new PositionService();

            positionEntities = positionService.GetDataAll();

            ddlPosition.DataSource = positionEntities;
            ddlPosition.DataTextField = "position_name";
            ddlPosition.DataValueField = "position_id";
            ddlPosition.DataBind();
        }

        public void GetDataToddlWorking_time()
        {
            List<WorkingTimeEntity> workingTimeEntities = new List<WorkingTimeEntity>();
            Working_timeService working_TimeService = new Working_timeService();

            workingTimeEntities = working_TimeService.GetDataAll();

            ddlWorkingTime.DataSource = workingTimeEntities;
            ddlWorkingTime.DataTextField = "working_time_name";
            ddlWorkingTime.DataValueField = "working_time_id";
            ddlWorkingTime.DataBind();
        }
    }
}