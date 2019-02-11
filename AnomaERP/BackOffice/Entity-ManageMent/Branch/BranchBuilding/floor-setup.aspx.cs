using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Definitions;
using Entity;
using Service.Branch.BranchBuilding;

namespace AnomaERP.BackOffice.Entity_ManageMent.Branch.BranchBuilding
{
    public partial class floor_setup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblBranchID.Text = "0";
                if (Request.QueryString["branch_id"] != null)
                {

                    if (int.Parse(Request.QueryString["branch_id"]) > 0)
                    {
                        lblBranchID.Text = Request.QueryString["branch_id"].ToString();
                        SetDataToUI(int.Parse(lblBranchID.Text));
                    }
                }
            }
            
        }

        protected void rptFloor_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            BranchFloorEntity branchFloorEntity = (BranchFloorEntity)e.Item.DataItem;
            Label lblFloorID = (Label)e.Item.FindControl("lblFloorID");
            Label lblBranchID = (Label)e.Item.FindControl("lblBranchID");
            TextBox txtFloorName = (TextBox)e.Item.FindControl("txtFloorName");
            LinkButton lbnActive = (LinkButton)e.Item.FindControl("lbnActive");
            HtmlInputCheckBox chkActive = (HtmlInputCheckBox)e.Item.FindControl("chkActive");
            HiddenField hdfActive = (HiddenField)e.Item.FindControl("hdfActive");
            LinkButton lbnDelete = (LinkButton)e.Item.FindControl("lbnDelete");
            LinkButton lbnRoom = (LinkButton)e.Item.FindControl("lbnRoom");

            lblFloorID.Text = branchFloorEntity.floor_id.ToString();
            lblBranchID.Text = branchFloorEntity.branch_id.ToString();           
            txtFloorName.Text = branchFloorEntity.floor_name;
            hdfActive.Value = branchFloorEntity.is_active.ToString();

            if (branchFloorEntity.is_active == true)
            {
                chkActive.Attributes.Add("checked", "checked");
            }
            else if (branchFloorEntity.is_active == false)
            {
                chkActive.Attributes.Remove("checked");
            }
            lbnActive.CommandName = "Active";
            lbnActive.CommandArgument = branchFloorEntity.floor_id.ToString();
            lbnRoom.CommandName = "Room";
            lbnRoom.CommandArgument = branchFloorEntity.floor_id.ToString();
            lbnDelete.CommandName = "Delete";
            lbnDelete.CommandArgument = branchFloorEntity.floor_id.ToString();

        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            List<BranchFloorEntity> branchFloorEntities = getDataFromRpt();
            BranchFloorEntity branchFloorEntity = new BranchFloorEntity();

            for (int i = 0; i < 1; i++)
            {               
                branchFloorEntities.Add(new BranchFloorEntity
                {
                    floor_id = 0,
                    branch_id = int.Parse(lblBranchID.Text),
                    floor_name = "",
                    create_date = DateTime.UtcNow,
                    is_delete = false,
                    is_active = true

                });
            }       
            SetDataTorpt(branchFloorEntities);
        }

        private List<BranchFloorEntity> getDataFromRpt()
        {
            DateFormat dateFormat = new DateFormat();

            List<BranchFloorEntity> branchFloorEntities = new List<BranchFloorEntity>();

            for (int i = 0; i < rptFloor.Items.Count; i++)
            {

                Label lblFloorID = (Label)rptFloor.Items[i].FindControl("lblFloorID");
                Label lblBranchID = (Label)rptFloor.Items[i].FindControl("lblBranchID");
                TextBox txtFloorName = (TextBox)rptFloor.Items[i].FindControl("txtFloorName");
                HtmlInputCheckBox chkActive = (HtmlInputCheckBox)rptFloor.Items[i].FindControl("chkActive");
                HiddenField hdfActive = (HiddenField)rptFloor.Items[i].FindControl("hdfActive");
                BranchFloorEntity branchFloorEntity = new BranchFloorEntity();
                BranchFloorService branchFloorService = new BranchFloorService();
                branchFloorEntity = branchFloorService.GetDataByID(int.Parse(lblBranchID.Text));
                if (branchFloorEntity != null)
                {
                    if (branchFloorEntity.is_active == true)
                    {
                        
                            branchFloorEntities.Add(new BranchFloorEntity
                            {
                                floor_id = int.Parse(lblFloorID.Text),
                                branch_id = int.Parse(lblBranchID.Text),
                                floor_name = txtFloorName.Text,
                                create_date = DateTime.UtcNow,
                                is_delete = false,
                                is_active = chkActive.Checked

                            });                       
                    }
                    else
                    {                       
                            branchFloorEntities.Add(new BranchFloorEntity
                            {
                                floor_id = int.Parse(lblFloorID.Text),
                                branch_id = int.Parse(lblBranchID.Text),
                                floor_name = txtFloorName.Text,
                                create_date = DateTime.UtcNow,
                                is_delete = false,
                                is_active = chkActive.Checked

                            });                        
                    }
                }
                else
                {
                    branchFloorEntities.Add(new BranchFloorEntity
                    {
                        floor_id = int.Parse(lblFloorID.Text),
                        branch_id = int.Parse(lblBranchID.Text),
                        floor_name = txtFloorName.Text,
                        create_date = DateTime.UtcNow,
                        is_delete = false,
                        is_active = chkActive.Checked

                    });
                }
            }

            return branchFloorEntities;
        }

        public void SetDataTorpt(List<BranchFloorEntity> branchFloorEntities)
        {
            rptFloor.DataSource = branchFloorEntities;
            rptFloor.DataBind();
        }

        public void SetDataToUI(int Branch_id)
        {
            BranchFloorService branchFloorService = new BranchFloorService();
            List<BranchFloorEntity> branchFloorEntity = new List<BranchFloorEntity>();

            branchFloorEntity = branchFloorService.GetDataBranchFloorByID(Branch_id);            
            SetDataTorpt(branchFloorEntity);

        }

        protected void rptFloor_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Active")
            {
                HiddenField hdfActive = (HiddenField)e.Item.FindControl("hdfActive");
                BranchFloorEntity branchFloorEntity = new BranchFloorEntity();
                BranchFloorService branchFloorService = new BranchFloorService();

                if (hdfActive.Value == "True")
                {
                    branchFloorEntity.is_active = false;
                }
                else if (hdfActive.Value == "False")
                {
                    branchFloorEntity.is_active = true;
                }
                branchFloorEntity.floor_id = Int32.Parse(e.CommandArgument.ToString());
               

                if (branchFloorService.UpdateData(branchFloorEntity) > 0)
                {                    
                    SetDataToUI(int.Parse(lblBranchID.Text));
                }
            }
            else if(e.CommandName == "Room")
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/room-setup.aspx?floor_id=" + e.CommandArgument+"&branch_id="+ lblBranchID.Text);
            }
            else if (e.CommandName == "Delete")
            {
                BranchFloorEntity branchFloorEntity = new BranchFloorEntity();
                BranchFloorService branchFloorService = new BranchFloorService();
                branchFloorEntity.floor_id = Int32.Parse(e.CommandArgument.ToString());
                if (branchFloorService.DeleteData(branchFloorEntity) > 0)
                {
                    SetDataToUI(int.Parse(lblBranchID.Text));
                }
            }
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {

            DateFormat dateFormat = new DateFormat();

            List<BranchFloorEntity> branchFloorEntities = getDataFromRpt();
            BranchFloorService branchFloorService = new BranchFloorService();
            BranchFloorEntity branchFloorEntity = new BranchFloorEntity();            

            if (branchFloorService.InsertDataMore(branchFloorEntities) > 0)
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/branch-list.aspx");
                
            }
            else
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/branch-list.aspx");

            }

        }

        protected void lblBack_Click(object sender, EventArgs e)
        {

        }
    }
}