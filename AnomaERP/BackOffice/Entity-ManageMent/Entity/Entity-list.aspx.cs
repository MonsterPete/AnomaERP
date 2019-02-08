using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Entity;
using Service.Entity;

namespace AnomaERP.BackOffice.Entity
{
    public partial class Entity_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDataToUI(setCondition());
            }
        }

        protected void rptEntityList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            EntityEntity entityEntity = (EntityEntity)e.Item.DataItem;

            Label lblID = (Label)e.Item.FindControl("lblID");
            Label lblEntityName = (Label)e.Item.FindControl("lblEntityName");
            Label lblInfor = (Label)e.Item.FindControl("lblInfor");
            LinkButton lbnEdit = (LinkButton)e.Item.FindControl("lbnEdit");
            LinkButton lbnStatus = (LinkButton)e.Item.FindControl("lbnStatus");
            HtmlInputCheckBox chkStatus = (HtmlInputCheckBox)e.Item.FindControl("chkStatus");
            HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");

            lblID.Text = entityEntity.entity_id.ToString();
            lblEntityName.Text = entityEntity.entity_name;
            lblInfor.Text = entityEntity.address;
            hdfStatus.Value = entityEntity.is_active.ToString();
            if (entityEntity.is_active == true)
            {
                chkStatus.Attributes.Add("checked", "checked");
            }
            else if (entityEntity.is_active == false)
            {
                chkStatus.Attributes.Remove("checked");
            }
            lbnStatus.CommandName = "Status";
            lbnEdit.CommandName = "Edit";
            lbnEdit.CommandArgument = entityEntity.entity_id.ToString();
            lbnStatus.CommandArgument = entityEntity.entity_id.ToString();
            // ddlStatus.SelectedValue = entityEntity.is_active.ToString();
            /// lblStatus = entityEntity.is_active.ToString();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            setDataToUI(setCondition());
        }

        public void setDataToUI(EntityEntity entityEntity)
        {
            EntityService entityService = new EntityService();
            List<EntityEntity> entityEntities = new List<EntityEntity>();

            entityEntities = entityService.GetDataByCondition(entityEntity);            

            rptEntityList.DataSource = entityEntities;
            rptEntityList.DataBind();           
        }

       

        public EntityEntity setCondition()
        {
            EntityEntity entityEntity = new EntityEntity();

            entityEntity.entity_name = txtSearch.Text;

            return entityEntity;
        }

        protected void rptEntityList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("/BackOffice/Entity-Management/Entity/Entity-create.aspx?entity_id=" + e.CommandArgument);
            }
            else if (e.CommandName == "Status")
            {
                HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");
                EntityEntity entityEntity = new EntityEntity();
                EntityService entityService = new EntityService();

                if (hdfStatus.Value == "True")
                {
                    entityEntity.is_active = false;
                }
                else if (hdfStatus.Value == "False")
                {
                    entityEntity.is_active = true;
                }
                entityEntity.entity_id = Int32.Parse(e.CommandArgument.ToString());
                entityEntity.modify_date = DateTime.UtcNow;
                entityEntity.create_date = DateTime.UtcNow;

                if (entityService.UpdateData(entityEntity) > 0)
                {
                    setDataToUI(setCondition());
                    Response.Redirect("/BackOffice/Entity-Management/Entity/Entity-list.aspx");
                }
                
            }
        }
    }
}