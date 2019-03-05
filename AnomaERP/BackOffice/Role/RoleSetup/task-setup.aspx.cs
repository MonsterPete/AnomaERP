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

            LinkButton lbnStatus = (LinkButton)e.Item.FindControl("lbnStatus");
            HtmlInputCheckBox chkStatus = (HtmlInputCheckBox)e.Item.FindControl("chkStatus");
            HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");


            lblGroupID.Text = entityTaskEntity.group_id.ToString();
            lblTaskID.Text = entityTaskEntity.task_id.ToString();
            txtTaskName.Text = entityTaskEntity.task_name;

            hdfStatus.Value = entityTaskEntity.is_active.ToString();
            if (entityTaskEntity.is_active == true)
            {
                chkStatus.Attributes.Add("checked", "checked");
            }
            else if (entityTaskEntity.is_active == false)
            {
                chkStatus.Attributes.Remove("checked");
            }

            lbnStatus.CommandName = "active";

            lbnDelete.CommandName = "Delete";
            lbnDelete.CommandArgument = entityTaskEntity.group_id.ToString();
        }

        protected void rptTask_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            LinkButton lbnStatus = (LinkButton)e.Item.FindControl("lbnStatus");
            HtmlInputCheckBox chkStatus = (HtmlInputCheckBox)e.Item.FindControl("chkStatus");
            HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");

            if (e.CommandName == "active")
            {
                if (hdfStatus.Value.ToLower() == "true")
                {
                    hdfStatus.Value = "false";
                    chkStatus.Attributes.Remove("checked");
                }
                else if (hdfStatus.Value.ToLower() == "false")
                {
                    hdfStatus.Value = "true";
                    chkStatus.Attributes.Add("checked", "checked");
                }
            }
        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            List<EntityTaskEntity> entityTaskEntities = getDataFromRpt();
            EntityTaskEntity positionEntity = new EntityTaskEntity();

            DateFormat dateFormat = new DateFormat();
            for (int i = 0; i < 1; i++)
            {
                entityTaskEntities.Add(new EntityTaskEntity
                {
                    task_id = 0,
                    group_id = int.Parse(ddlGroupName.SelectedValue),
                    task_name = "",
                    description = "",
                    entity_id = Master.entityEntity.entity_id,
                    create_by = Master.entityEntity.entity_id,
                    create_date = dateFormat.EngFormatDateToSQL(DateTime.Now),
                    modify_by = Master.entityEntity.entity_id,
                    modify_date = dateFormat.EngFormatDateToSQL(DateTime.Now),
                    is_active = true

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
                HiddenField hdfStatus = (HiddenField)rptTask.Items[i].FindControl("hdfStatus");

                EntityTaskEntity entityTaskEntity = new EntityTaskEntity();
                EntityTaskService entityTaskService = new EntityTaskService();

                    if (!string.IsNullOrEmpty(txtTaskName.Text))
                    {
                        entityTaskEntities.Add(new EntityTaskEntity
                        {
                            task_id = int.Parse(lblTaskID.Text),
                            group_id = int.Parse(ddlGroupName.SelectedValue),
                            task_name = txtTaskName.Text,
                            description = txtTaskName.Text,
                            entity_id = Master.entityEntity.entity_id,
                            create_by = Master.entityEntity.entity_id,
                            create_date = dateFormat.EngFormatDateToSQL(DateTime.Now),
                            modify_by = Master.entityEntity.entity_id,
                            modify_date = dateFormat.EngFormatDateToSQL(DateTime.Now),
                            is_active = Boolean.Parse(hdfStatus.Value)

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
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalSuccess();", true);
                SetDataToUI(int.Parse(ddlGroupName.SelectedValue));

            }
        }

        protected void lblBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/BackOffice/Role/RoleSetup/position-list.aspx");
        }
    }
}