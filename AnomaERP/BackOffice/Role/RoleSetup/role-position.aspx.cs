using Entity;
using Service.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Definitions;

namespace AnomaERP.BackOffice.Role.RoleSetup
{
    public partial class role_position : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["ConfigRolePosition"] = null;
                PositionService positionService = new PositionService();
                setDataToRptPosition(positionService.GetDataPositionByGroupID(int.Parse(Request.QueryString["groupId"].ToString())));
                EntityTaskService entityTaskService = new EntityTaskService();
                setDataToRptTask(entityTaskService.GetDataByGroupID(int.Parse(Request.QueryString["groupId"].ToString())));
            }
        }

        private void setDataToRptPosition(List<PositionEntity> positionEntities)
        {
            Session["ConfigRolePosition"] = positionEntities;
            RptPosition.DataSource = positionEntities;
            RptPosition.DataBind();
        }

        protected void RptPosition_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            PositionEntity positionEntities = (PositionEntity)e.Item.DataItem;

            Label lblPositionName = (Label)e.Item.FindControl("lblPositionName");
            lblPositionName.Text = positionEntities.position_name;
        }

        private void setDataToRptTask(List<EntityTaskEntity> entityTaskEntities)
        {
            RptTask.DataSource = entityTaskEntities;
            RptTask.DataBind();
        }

        protected void RptTask_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            EntityTaskEntity entityTaskEntity = (EntityTaskEntity)e.Item.DataItem;

            TextBox txtTask = (TextBox)e.Item.FindControl("txtTask");
            txtTask.Text = entityTaskEntity.task_name;

            List<PositionEntity> positionEntities = (List<PositionEntity>)Session["ConfigRolePosition"];
            TaskGroupService taskGroupService = new TaskGroupService();
            List<TaskGroupEntity> taskGroupEntity = taskGroupService.GetDataByTaskGroupByTaskId(entityTaskEntity.task_id);
            List<TaskGroupEntity> taskGroupEntityForRpt = new List<TaskGroupEntity>();
            for (int i=0; i< positionEntities.Count;i++)
            {
                int groupTaskId = 0;
                bool activeStatus = false;
                for (int j=0; j< taskGroupEntity.Count;j++)
                {
                    if (taskGroupEntity[j].position_id == positionEntities[i].position_id)
                    {
                        groupTaskId = taskGroupEntity[j].task_group_id;
                        activeStatus = taskGroupEntity[j].is_active;
                    }
                }
                taskGroupEntityForRpt.Add(new TaskGroupEntity
                {
                    position_id = positionEntities[i].position_id,
                    task_id = entityTaskEntity.task_id,
                    task_group_id = groupTaskId,
                    is_active = activeStatus
                });
            }

            Repeater RptTaskPosition = (Repeater)e.Item.FindControl("RptTaskPosition");
            RptTaskPosition.DataSource = taskGroupEntityForRpt;
            RptTaskPosition.DataBind();
        }

        private void setDataToRptTaskPosition(List<PositionEntity> positionEntities)
        {
            RptPosition.DataSource = positionEntities;
            RptPosition.DataBind();
        }

        protected void RptTaskPosition_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            TaskGroupEntity taskGroupEntity = (TaskGroupEntity)e.Item.DataItem;

            HtmlInputCheckBox chkTask = (HtmlInputCheckBox)e.Item.FindControl("chkTask");
            HiddenField hdfPositionId = (HiddenField)e.Item.FindControl("hdfPositionId");
            HiddenField hdfTaskId = (HiddenField)e.Item.FindControl("hdfTaskId");
            HiddenField hdfTaskPositionId = (HiddenField)e.Item.FindControl("hdfTaskPositionId");

            chkTask.Checked = taskGroupEntity.is_active;
            hdfPositionId.Value = taskGroupEntity.position_id.ToString();
            hdfTaskId.Value = taskGroupEntity.task_id.ToString();
            hdfTaskPositionId.Value = taskGroupEntity.task_group_id.ToString();
        }


        public List<TaskGroupEntity> getDataFromRptTaskPosition()
        {           
            List<TaskGroupEntity> taskGroupEntities = new List<TaskGroupEntity>();

            for (int i = 0; i < RptTask.Items.Count; i++)
            {
                Repeater RptTaskPosition = (Repeater)RptTask.Items[i].FindControl("RptTaskPosition");

                for (int j = 0; j < RptTaskPosition.Items.Count; j++)
                {
                    HtmlInputCheckBox chkTask = (HtmlInputCheckBox)RptTaskPosition.Items[j].FindControl("chkTask");
                    HiddenField hdfPositionId = (HiddenField)RptTaskPosition.Items[j].FindControl("hdfPositionId");
                    HiddenField hdfTaskId = (HiddenField)RptTaskPosition.Items[j].FindControl("hdfTaskId");
                    HiddenField hdfTaskPositionId = (HiddenField)RptTaskPosition.Items[j].FindControl("hdfTaskPositionId");

                    bool delete = false;
                    if (RptTaskPosition.Items[j].Visible == false)
                    {
                        delete = true;
                    }

                    DateFormat dateFormat = new DateFormat();
                    taskGroupEntities.Add(new TaskGroupEntity
                    {
                        task_group_id = int.Parse(hdfTaskPositionId.Value),
                        position_id = int.Parse(hdfPositionId.Value),
                        task_id = int.Parse(hdfTaskId.Value),
                        create_by = 1,
                        create_date = dateFormat.EngFormatDateToSQL(DateTime.Now),
                        is_active = chkTask.Checked,      
                        is_delete = delete
                    });
                }
            }

            return taskGroupEntities;
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            int success = 0;
            List<TaskGroupEntity> taskGroupEntities = new List<TaskGroupEntity>();
            TaskGroupService taskGroupService = new TaskGroupService();
            taskGroupEntities = getDataFromRptTaskPosition();
            success = taskGroupService.InsertAndUpdateDataMore(taskGroupEntities);

            if (success > 0 )
            {
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('successs');", true);
            }

        }

        protected void lbnBack_Click(object sender, EventArgs e)
        {

        }
    }
}