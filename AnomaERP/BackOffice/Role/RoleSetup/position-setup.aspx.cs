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
    public partial class position_setup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hdfEntityId.Value = Master.entityEntity.entity_id.ToString(); ;
                lblGroupID.Text = "0";
                if (Request.QueryString["group_id"] != null)
                {

                    if (int.Parse(Request.QueryString["group_id"]) > 0)
                    {
                        lblGroupID.Text = Request.QueryString["group_id"].ToString();
                        SetDataToUI(int.Parse(lblGroupID.Text));
                    }
                }
            }
        }

        public void SetDataToUI(int Group_id)
        {
            PositionService positionService = new PositionService();
            List<PositionEntity> positionEntities = new List<PositionEntity>();
            PositionEntity positionEntity = new PositionEntity();
            positionEntity = positionService.GetDataByID(Group_id);
            positionEntities = positionService.GetDataPositionByGroupID(Group_id);
            txtGroupName.Text = positionEntity.group_name;
            SetDataTorpt(positionEntities);

        }

        public void SetDataTorpt(List<PositionEntity> positionEntities)
        {
            rptPosition.DataSource = positionEntities;
            rptPosition.DataBind();
        }

        public bool validate()
        {
            
            return true;
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGroupName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุกลุ่มตำแหน่ง (Group position)');", true);
                return;
            }

            if (getDataFromRpt().Count == 0 )
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาเพิ่มตำแหน่ง (Position)');", true);
                return;
            }

            DateFormat dateFormat = new DateFormat();

            List<PositionEntity> positionEntities = getDataFromRpt();
            PositionService positionService = new PositionService();

            if (positionService.InsertDataMore(positionEntities) > 0)
            {
                Response.Redirect("/BackOffice/Role/RoleSetup/position-list.aspx");
            }
        }

        protected void lblBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/BackOffice/Role/RoleSetup/position-list.aspx");
        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            List<PositionEntity> positionEntities = getDataFromRpt();
            PositionEntity positionEntity = new PositionEntity();

            positionEntities.Add(new PositionEntity
            {
                position_id = 0,
                group_id = int.Parse(lblGroupID.Text),
                group_name = "",
                create_by = 1,
                create_date = DateTime.UtcNow,
                is_delete = false,
                is_active = true

            });

            SetDataTorpt(positionEntities);
        }

        protected void rptPosition_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            PositionEntity positionEntity = (PositionEntity)e.Item.DataItem;
            Label lblPositionID = (Label)e.Item.FindControl("lblPositionID");
            Label lblGroupID = (Label)e.Item.FindControl("lblGroupID");
            Label lblGroupName = (Label)e.Item.FindControl("lblGroupName");
            TextBox txtPositionName = (TextBox)e.Item.FindControl("txtPositionName");


            LinkButton lbnActive = (LinkButton)e.Item.FindControl("lbnActive");
            HtmlInputCheckBox chkActive = (HtmlInputCheckBox)e.Item.FindControl("chkActive");
            HiddenField hdfActive = (HiddenField)e.Item.FindControl("hdfActive");


            LinkButton lbnDelete = (LinkButton)e.Item.FindControl("lbnDelete");

            lblPositionID.Text = positionEntity.position_id.ToString();
            lblGroupID.Text = positionEntity.group_id.ToString();
            lblGroupName.Text = positionEntity.group_name;
            txtPositionName.Text = positionEntity.position_name;

            hdfActive.Value = positionEntity.is_active.ToString();
            if (positionEntity.is_active == true)
            {
                chkActive.Attributes.Add("checked", "checked");
            }
            else if (positionEntity.is_active == false)
            {
                chkActive.Attributes.Remove("checked");
            }

            if (positionEntity.is_delete)
            {
                e.Item.Visible = false;
            }

            lbnActive.CommandName = "Active";
            lbnActive.CommandArgument = positionEntity.position_id.ToString();
            lbnDelete.CommandName = "Delete";
            lbnDelete.CommandArgument = positionEntity.position_id.ToString();
        }

        protected void rptPosition_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                e.Item.Visible = false;
            }

            LinkButton lbnActive = (LinkButton)e.Item.FindControl("lbnActive");
            HtmlInputCheckBox chkActive = (HtmlInputCheckBox)e.Item.FindControl("chkActive");
            HiddenField hdfActive = (HiddenField)e.Item.FindControl("hdfActive");


            if (e.CommandName == "Active")
            {
                if (hdfActive.Value.ToLower() == "true")
                {
                    hdfActive.Value = "false";
                    chkActive.Attributes.Remove("checked");
                }
                else if (hdfActive.Value.ToLower() == "false")
                {
                    hdfActive.Value = "true";
                    chkActive.Attributes.Add("checked", "checked");
                }
            }
        }

        private List<PositionEntity> getDataFromRpt()
        {
            DateFormat dateFormat = new DateFormat();

            List<PositionEntity> positionEntities = new List<PositionEntity>();

            for (int i = 0; i < rptPosition.Items.Count; i++)
            {
                Label lblPositionID = (Label)rptPosition.Items[i].FindControl("lblPositionID");
                Label lblGroupID = (Label)rptPosition.Items[i].FindControl("lblGroupID");
                Label lblGroupName = (Label)rptPosition.Items[i].FindControl("lblGroupName");
                TextBox txtPositionName = (TextBox)rptPosition.Items[i].FindControl("txtPositionName");
                HtmlInputCheckBox chkActive = (HtmlInputCheckBox)rptPosition.Items[i].FindControl("chkActive");
                HiddenField hdfActive = (HiddenField)rptPosition.Items[i].FindControl("hdfActive");

                PositionEntity positionEntity = new PositionEntity();
                PositionService positionService = new PositionService();

                if (rptPosition.Items[i].Visible == true)
                {
                    positionEntities.Add(new PositionEntity
                    {
                        position_id = int.Parse(lblPositionID.Text),
                        group_id = int.Parse(lblGroupID.Text),
                        entity_id = int.Parse(hdfEntityId.Value),
                        group_name = txtGroupName.Text,
                        position_name = txtPositionName.Text,
                        create_by = 1,
                        create_date = DateTime.UtcNow,
                        is_delete = false,
                        is_active = Boolean.Parse(hdfActive.Value)

                    });
                }
                else
                {
                    positionEntities.Add(new PositionEntity
                    {
                        position_id = int.Parse(lblPositionID.Text),
                        group_id = int.Parse(lblGroupID.Text),
                        entity_id = int.Parse(hdfEntityId.Value),
                        group_name = txtGroupName.Text,
                        position_name = txtPositionName.Text,
                        create_by = 1,
                        create_date = DateTime.UtcNow,
                        is_delete = true,
                        is_active = Boolean.Parse(hdfActive.Value)
                    });
                }
            }
            return positionEntities;
        }
    }
}