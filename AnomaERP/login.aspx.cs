using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Branch;

namespace AnomaERP
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["BranchEntity"] = null;
                Session["EntityEntity"] = null;
                Session["EmployeeEntity"] = null;
            }
            Session.Clear();
            Session.RemoveAll();
        }

        protected void btnSignin_Click(object sender, EventArgs e)

        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {

                user_loginEntity user_LoginEntity = new user_loginEntity();
                BranchService branchService = new BranchService();

                //get_all_login
                user_LoginEntity = branchService.GetAlllogin(txtUsername.Text, txtPassword.Text);

                if (user_LoginEntity != null)
                {
                    if (user_LoginEntity.Role.ToLower() == "branch")
                    {
                        BranchEntity branchEntity = new BranchEntity();

                        branchEntity.branch_id = user_LoginEntity.branch_id;
                        branchEntity.entity_id = user_LoginEntity.entity_id;
                        branchEntity.branch_name = user_LoginEntity.branch_name;
                        branchEntity.username = user_LoginEntity.username;
                        branchEntity.password = user_LoginEntity.password;

                        Session["BranchEntity"] = branchEntity;
                        Response.Redirect("/BackOffice/NursingHome/Visitor-Form/index.aspx");
                    }
                    else if (user_LoginEntity.Role.ToLower() == "entity")
                    {

                        EntityEntity entityEntity = new EntityEntity();

                        entityEntity.entity_id = user_LoginEntity.entity_id;
                        entityEntity.entity_name = user_LoginEntity.entity_name;
                        entityEntity.username = user_LoginEntity.username;
                        entityEntity.password = user_LoginEntity.password;

                        Session["EntityEntity"] = entityEntity;
                        Response.Redirect("/BackOffice/Entity-ManageMent/Entity/entity-list.aspx");
                    }
                    else if (user_LoginEntity.Role.ToLower() == "employee")
                    {

                        EmployeeEntity employeeEntity = new EmployeeEntity();

                        employeeEntity.employee_id = user_LoginEntity.employee_id;
                        employeeEntity.firstname = user_LoginEntity.firstname;
                        employeeEntity.lastname = user_LoginEntity.lastname;
                        employeeEntity.nickname = user_LoginEntity.nickname;
                        employeeEntity.username = user_LoginEntity.username;
                        employeeEntity.password = user_LoginEntity.password;

                        Session["EmployeeEntity"] = employeeEntity;
                        Response.Redirect("BackOffice/ServiceCare/schedule-management.aspx");
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript((sender as Control), this.GetType(), "alertError", "alert('ชื่อผู้ใช้งานหรือรหัสผ่านผิด กรุณาระบุใหม่อีกครั้ง');", true);
                }

            }
            else
            {
                ScriptManager.RegisterStartupScript((sender as Control), this.GetType(), "alertError", "alert('กรุณาระบุชื่อผู้ใช้งาน หรือรหัสผ่าน');", true);
            }
        }
    }
}