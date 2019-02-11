using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Definitions;
using Entity;
using Service.Role;

namespace AnomaERP.BackOffice.Role.RoleSetup
{
    public partial class task_setup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDataToDDLGroupName();
                SetDataToUI(int.Parse(ddlGroupName.SelectedValue));
            }
        }

        protected void ddlGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDataToUI(int.Parse(ddlGroupName.SelectedValue));
        }

        public void SetDataToUI(int Group_id)
        {
            EntityTaskService entityTaskService = new EntityTaskService();
            List<EntityTaskEntity> entityTaskEntities = new List<EntityTaskEntity>();

            entityTaskEntities = entityTaskService.GetDataTaskByID(Group_id);
            SetDataTorpt(entityTaskEntities);

        }

        public void SetDataTorpt(List<EntityTaskEntity> entityTaskEntities)
        {
            rptTask.DataSource = entityTaskEntities;
            rptTask.DataBind();
        }

        private void setDataToDDLGroupName()
        {
            List<PositionGroupEntity> positionGroupEntities = new List<PositionGroupEntity>();
            PositionGroupService positionGroupService = new PositionGroupService();

            positionGroupEntities = positionGroupService.GetDataAll();
            ddlGroupName.DataSource = positionGroupEntities;
            ddlGroupName.DataTextField = "group_name";
            ddlGroupName.DataValueField = "group_id";
            ddlGroupName.DataBind();
        }

        protected void rptTask_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            EntityTaskEntity entityTaskEntity = (EntityTaskEntity)e.Item.DataItem;           
            Label lblTaskID = (Label)e.Item.FindControl("lblTaskID");
            TextBox txtTaskName = (TextBox)e.Item.FindControl("txtTaskName");            
            LinkButton lbnDelete = (LinkButton)e.Item.FindControl("lbnDelete");
           
            lblGroupID.Text = entityTaskEntity.group_id.ToString();
            lblTaskID.Text = entityTaskEntity.task_id.ToString();
            txtTaskName.Text = entityTaskEntity.task_name;
           
            lbnDelete.CommandName = "Delete";
            lbnDelete.CommandArgument = entityTaskEntity.group_id.ToString();
        }

        protected void rptTask_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            List<EntityTaskEntity> entityTaskEntities = getDataFromRpt();
            EntityTaskEntity positionEntity = new EntityTaskEntity();

            for (int i = 0; i < 1; i++)
            {
                entityTaskEntities.Add(new EntityTaskEntity
                {
                    task_id = 0,
                    group_id = int.Parse(ddlGroupName.SelectedValue),
                    task_name = "",
                    description = "",
                    entity_id = 1,
                    create_by = 1,
                    create_date = DateTime.UtcNow,
                    modify_by = 1,
                    modify_date = DateTime.UtcNow

                });
            }
            SetDataTorpt(entityTaskEntities);
        }

        private List<EntityTaskEntity> getDataFromRpt()
        {
            DateFormat dateFormat = new DateFormat();

            List<EntityTaskEntity> entityTaskEntities = new List<EntityTaskEntity>();

            for (int i = 0; i < rptTask.Items.Count; i++)
            {               
                Label lblTaskID = (Label)rptTask.Items[i].FindControl("lblTaskID");                
                TextBox txtTaskName = (TextBox)rptTask.Items[i].FindControl("txtTaskName");

                EntityTaskEntity entityTaskEntity = new EntityTaskEntity();
                EntityTaskService entityTaskService = new EntityTaskService();
                entityTaskEntity = entityTaskService.GetDataByID(int.Parse(ddlGroupName.SelectedValue));
                if (entityTaskEntity != null)
                {                                           
                     entityTaskEntities.Add(new EntityTaskEntity
                     {
                                task_id = int.Parse(lblTaskID.Text),
                                group_id = int.Parse(ddlGroupName.SelectedValue),
                                task_name = txtTaskName.Text,
                                description = txtTaskName.Text,
                                entity_id = 1,
                                create_by = 1,
                                create_date = DateTime.UtcNow,
                                modify_by = 1,
                                modify_date = DateTime.UtcNow

                     });
                }
                    
                else
                {
                    
                            entityTaskEntities.Add(new EntityTaskEntity
                            {
                                task_id = int.Parse(lblTaskID.Text),
                                group_id = int.Parse(ddlGroupName.SelectedValue),
                                task_name = txtTaskName.Text,
                                description = txtTaskName.Text,
                                entity_id = 1,
                                create_by = 1,
                                create_date = DateTime.UtcNow,
                                modify_by = 1,
                                modify_date = DateTime.UtcNow

                            });
                    
                }

            }

            return entityTaskEntities;
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            DateFormat dateFormat = new DateFormat();

            List<EntityTaskEntity> entityTaskEntities = getDataFromRpt();
            EntityTaskService entityTaskService = new EntityTaskService();

            if (entityTaskService.InsertDataMore(entityTaskEntities) > 0)
            {
                //Response.Redirect("/BackOffice/Role/RoleSetup/position-list.aspx");
                setDataToDDLGroupName();
                SetDataToUI(int.Parse(ddlGroupName.SelectedValue));
            }
            else
            {
                //Response.Redirect("/BackOffice/Role/RoleSetup/position-list.aspx");
                setDataToDDLGroupName();
                SetDataToUI(int.Parse(ddlGroupName.SelectedValue));
            }
        }

        protected void lblBack_Click(object sender, EventArgs e)
        {

        }
    }
}