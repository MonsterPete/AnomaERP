using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Entity;
using Service.Role;

namespace AnomaERP.BackOffice.Role.RoleSetup
{
    public partial class position_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDataToUI(setCondition());
            }
        }

        public void setDataToUI(PositionGroupEntity positionGroupEntity)
        {
            PositionGroupService positionGroupService = new PositionGroupService();
            List<PositionGroupEntity> positionGroupEntities = new List<PositionGroupEntity>();

            positionGroupEntities = positionGroupService.GetDataByCondition(positionGroupEntity);


            rptGroupList.DataSource = positionGroupEntities;
            rptGroupList.DataBind();
        }

        public PositionGroupEntity setCondition()
        {
            PositionGroupEntity positionGroupEntity = new PositionGroupEntity();

            positionGroupEntity.group_name = txtSearch.Text;
            positionGroupEntity.entity_id = Master.entityEntity.entity_id;

            return positionGroupEntity;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            setDataToUI(setCondition());
        }

        protected void rptGroupList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            PositionGroupEntity positionGroupEntity = (PositionGroupEntity)e.Item.DataItem;

            Label lblGroupName = (Label)e.Item.FindControl("lblGroupName");         
            LinkButton lbnStatus = (LinkButton)e.Item.FindControl("lbnStatus");
            HtmlInputCheckBox chkStatus = (HtmlInputCheckBox)e.Item.FindControl("chkStatus");
            HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");
            LinkButton lbnEdit = (LinkButton)e.Item.FindControl("lbnEdit");
            LinkButton lbnName = (LinkButton)e.Item.FindControl("lbnName");
            LinkButton lbnConfigTask = (LinkButton)e.Item.FindControl("lbnConfigTask");

            lblGroupName.Text = positionGroupEntity.group_name;
            
            hdfStatus.Value = positionGroupEntity.is_active.ToString();

            if (positionGroupEntity.is_active == true)
            {
                chkStatus.Attributes.Add("checked", "checked");
            }
            else if (positionGroupEntity.is_active == false)
            {
                chkStatus.Attributes.Remove("checked");
            }
            lbnStatus.CommandName = "Status";
            lbnStatus.CommandArgument = positionGroupEntity.group_id.ToString();
            lbnEdit.CommandName = "Edit";
            lbnEdit.CommandArgument = positionGroupEntity.group_id.ToString();
            lbnConfigTask.CommandName = "TaskConfig";
            lbnConfigTask.CommandArgument = positionGroupEntity.group_id.ToString();
        }

        protected void rptGroupList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("/BackOffice/Role/RoleSetup/position-setup.aspx?group_id=" + e.CommandArgument);
            }
            else if (e.CommandName == "TaskConfig")
            {
                PositionService positionService = new PositionService();
                List<PositionEntity> positionEntities = positionService.GetDataPositionByGroupID(int.Parse(e.CommandArgument.ToString()));
                EntityTaskService entityTaskService = new EntityTaskService();
                List<EntityTaskEntity> entityTaskEntities =  entityTaskService.GetDataByGroupID(int.Parse(e.CommandArgument.ToString()));

                if (positionEntities.Count == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาเพิ่มตำแหน่ง (Position)');", true);
                    return;
                }

                if (entityTaskEntities.Count == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาเพิ่มงาน (Task)');", true);
                    return;
                }

                Response.Redirect("/BackOffice/Role/RoleSetup/role-position.aspx?group_id=" + e.CommandArgument);
            }
            else if (e.CommandName == "Status")
            {
                HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");
                PositionGroupEntity positionGroupEntity = new PositionGroupEntity();
                PositionGroupService positionGroupService = new PositionGroupService();

                if (hdfStatus.Value == "True")
                {
                    positionGroupEntity.is_active = false;
                }
                else if (hdfStatus.Value == "False")
                {
                    positionGroupEntity.is_active = true;
                }
                positionGroupEntity.group_id = Int32.Parse(e.CommandArgument.ToString());               


                if (positionGroupService.UpdateData(positionGroupEntity) > 0)
                {
                    setDataToUI(setCondition());
                }
            }
        }
    }
}