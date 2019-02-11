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
                lblGroupID.Text = "0";
                if (Request.QueryString["group_id"] != null)
                {

                    if (int.Parse(Request.QueryString["group_id"]) > 0)
                    {
                        lblGroupID.Text = Request.QueryString["group_id"].ToString();
                        txtGroupName.Text = Request.QueryString["group_name"].ToString();
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

            positionEntities = positionService.GetDataPositionGroupByID(Group_id);            
            SetDataTorpt(positionEntities);

        }

        public void SetDataTorpt(List<PositionEntity> positionEntities)
        {
            rptPosition.DataSource = positionEntities;
            rptPosition.DataBind();
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            DateFormat dateFormat = new DateFormat();

            List<PositionEntity> positionEntities = getDataFromRpt();
            PositionService positionService = new PositionService();           

            if (positionService.InsertDataMore(positionEntities) > 0)
            {
                Response.Redirect("/BackOffice/Role/RoleSetup/position-list.aspx");

            }
            else
            {
                Response.Redirect("/BackOffice/Role/RoleSetup/position-list.aspx");

            }
        }

        protected void lblBack_Click(object sender, EventArgs e)
        {

        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            List<PositionEntity> positionEntities = getDataFromRpt();
            PositionEntity positionEntity = new PositionEntity();

            for (int i = 0; i < 1; i++)
            {
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
            }
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
            lbnActive.CommandName = "Active";
            lbnActive.CommandArgument = positionEntity.position_id.ToString();           
            lbnDelete.CommandName = "Delete";
            lbnDelete.CommandArgument = positionEntity.position_id.ToString();
        }

        protected void rptPosition_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

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
                positionEntity = positionService.GetDataByID(int.Parse(lblGroupID.Text));
                if (positionEntity != null)
                {
                    if (positionEntity.is_active == true)
                    {
                        if (rptPosition.Items[i].Visible == true)
                        {

                            positionEntities.Add(new PositionEntity
                            {
                                position_id = int.Parse(lblPositionID.Text),
                                group_id = int.Parse(lblGroupID.Text),
                                group_name = txtGroupName.Text,
                                position_name = txtPositionName.Text,
                                create_by = 1,
                                create_date = DateTime.UtcNow,
                                is_delete = false,
                                is_active = chkActive.Checked

                            });
                        }
                    }
                    else
                    {
                        if (rptPosition.Items[i].Visible == true)
                        {

                            positionEntities.Add(new PositionEntity
                            {
                                position_id = int.Parse(lblPositionID.Text),
                                group_id = int.Parse(lblGroupID.Text),
                                group_name = txtGroupName.Text,
                                position_name = txtPositionName.Text,
                                create_by = 1,
                                create_date = DateTime.UtcNow,
                                is_delete = false,
                                is_active = chkActive.Checked

                            });
                        }
                    }
                }
                else
                {
                    if (rptPosition.Items[i].Visible == true)
                    {

                        positionEntities.Add(new PositionEntity
                        {
                            position_id = int.Parse(lblPositionID.Text),
                            group_id = int.Parse(lblGroupID.Text),
                            group_name = txtGroupName.Text,
                            position_name = txtPositionName.Text,
                            create_by = 1,
                            create_date = DateTime.UtcNow,
                            is_delete = false,
                            is_active = chkActive.Checked

                        });
                    }
                }
                
            }

            return positionEntities;
        }
    }
}