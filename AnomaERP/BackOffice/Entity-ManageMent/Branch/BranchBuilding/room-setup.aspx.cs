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
    public partial class room_setup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblBranchID.Text = "0";
                lblFloorID.Text = "0";
                if (Request.QueryString["branch_id"] != null)
                {

                    if (int.Parse(Request.QueryString["branch_id"]) > 0)
                    {
                        BranchFloorService branchFloorService = new BranchFloorService();
                        BranchFloorEntity branchFloorEntity = new BranchFloorEntity();
                        lblBranchID.Text = Request.QueryString["branch_id"].ToString();
                        lblFloorID.Text = Request.QueryString["floor_id"].ToString();
                        branchFloorEntity.floor_id = int.Parse(lblFloorID.Text);
                        lblFloor.Text = branchFloorService.GetDataByCondition(branchFloorEntity)[0].floor_name;
                        SetDataToUI(int.Parse(lblFloorID.Text));
                    }
                }
            }
        }

        public void SetDataToUI(int Floor_id)
        {
            BranchRoomService branchRoomService = new BranchRoomService();
            List<BranchRoomEntity> branchRoomEntities = new List<BranchRoomEntity>();

            branchRoomEntities = branchRoomService.GetDataBranchRoomByID(Floor_id);
            SetDataTorpt(branchRoomEntities);

        }

        public void SetDataTorpt(List<BranchRoomEntity> branchRoomEntities)
        {
            rptRoom.DataSource = branchRoomEntities;
            rptRoom.DataBind();
        }

        protected void rptRoom_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            BranchRoomEntity branchRoomEntity = (BranchRoomEntity)e.Item.DataItem;
            Label lblFloorID = (Label)e.Item.FindControl("lblFloorID");
            Label lblBranchID = (Label)e.Item.FindControl("lblBranchID");
            Label lblRoomID = (Label)e.Item.FindControl("lblRoomID");
            TextBox txtRoomName = (TextBox)e.Item.FindControl("txtRoomName");
            LinkButton lbnActive = (LinkButton)e.Item.FindControl("lbnActive");
            HtmlInputCheckBox chkActive = (HtmlInputCheckBox)e.Item.FindControl("chkActive");
            HiddenField hdfActive = (HiddenField)e.Item.FindControl("hdfActive");
            LinkButton lbnDelete = (LinkButton)e.Item.FindControl("lbnDelete");
            LinkButton lbnRoom = (LinkButton)e.Item.FindControl("lbnRoom");

            lblFloorID.Text = branchRoomEntity.floor_id.ToString();
            lblRoomID.Text = branchRoomEntity.room_id.ToString();
            lblBranchID.Text = lblBranchID.Text;
            txtRoomName.Text = branchRoomEntity.room_name;
            hdfActive.Value = branchRoomEntity.is_active.ToString();

            if (branchRoomEntity.is_active == true)
            {
                chkActive.Attributes.Add("checked", "checked");
            }
            else if (branchRoomEntity.is_active == false)
            {
                chkActive.Attributes.Remove("checked");
            }
            lbnActive.CommandName = "Active";
            lbnActive.CommandArgument = branchRoomEntity.room_id.ToString();
            lbnRoom.CommandName = "Room";
            lbnRoom.CommandArgument = branchRoomEntity.room_id.ToString();
            lbnDelete.CommandName = "Delete";
            lbnDelete.CommandArgument = branchRoomEntity.room_id.ToString();
        }

        protected void rptRoom_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Active")
            {
                HiddenField hdfActive = (HiddenField)e.Item.FindControl("hdfActive");
                BranchRoomEntity branchRoomEntity = new BranchRoomEntity();
                BranchRoomService branchRoomService = new BranchRoomService();

                if (hdfActive.Value == "True")
                {
                    branchRoomEntity.is_active = false;
                }
                else if (hdfActive.Value == "False")
                {
                    branchRoomEntity.is_active = true;
                }
                branchRoomEntity.room_id = Int32.Parse(e.CommandArgument.ToString());


                if (branchRoomService.UpdateData(branchRoomEntity) > 0)
                {
                    //setDataToUI(setCondition());
                    //Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/floor-setup.aspx/branch_id=" + lblBranchID.Text);
                    SetDataToUI(int.Parse(lblFloorID.Text));
                }
            }
            else if (e.CommandName == "Room")
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/bed-setup.aspx?room_id=" + e.CommandArgument + "&branch_id=" + lblBranchID.Text + "&floor_id=" + lblFloorID.Text);
            }
            else if (e.CommandName == "Delete")
            {
                BranchRoomEntity branchRoomEntity = new BranchRoomEntity();
                BranchRoomService branchRoomService = new BranchRoomService();

                branchRoomEntity.room_id = Int32.Parse(e.CommandArgument.ToString());
                if (branchRoomService.DeleteData(branchRoomEntity) > 0)
                {
                    SetDataToUI(int.Parse(lblBranchID.Text));
                }
            }

        }

        private List<BranchRoomEntity> getDataFromRpt()
        {
            DateFormat dateFormat = new DateFormat();

            List<BranchRoomEntity> branchRoomEntities = new List<BranchRoomEntity>();

            for (int i = 0; i < rptRoom.Items.Count; i++)
            {
                Label lblFloorID = (Label)rptRoom.Items[i].FindControl("lblFloorID");
                Label lblBranchID = (Label)rptRoom.Items[i].FindControl("lblBranchID");
                Label lblRoomID = (Label)rptRoom.Items[i].FindControl("lblRoomID");
                TextBox txtRoomName = (TextBox)rptRoom.Items[i].FindControl("txtRoomName");
                HtmlInputCheckBox chkActive = (HtmlInputCheckBox)rptRoom.Items[i].FindControl("chkActive");
                HiddenField hdfActive = (HiddenField)rptRoom.Items[i].FindControl("hdfActive");

                BranchRoomEntity branchRoomEntity = new BranchRoomEntity();
                BranchRoomService branchRoomService = new BranchRoomService();
                branchRoomEntity = branchRoomService.GetDataByID(int.Parse(lblFloorID.Text));
                if (branchRoomEntity != null)
                {
                    if (branchRoomEntity.is_active == true)
                    {
                        branchRoomEntities.Add(new BranchRoomEntity
                        {
                            floor_id = int.Parse(lblFloorID.Text),
                            room_id = int.Parse(lblRoomID.Text),
                            room_name = txtRoomName.Text,
                            create_date = DateTime.UtcNow,
                            is_delete = false,
                            is_active = chkActive.Checked

                        });
                    }
                    else
                    {
                        branchRoomEntities.Add(new BranchRoomEntity
                        {
                            floor_id = int.Parse(lblFloorID.Text),
                            room_id = int.Parse(lblRoomID.Text),
                            room_name = txtRoomName.Text,
                            create_date = DateTime.UtcNow,
                            is_delete = false,
                            is_active = chkActive.Checked
                        });
                    }
                }
                else
                {


                    branchRoomEntities.Add(new BranchRoomEntity
                    {
                        floor_id = int.Parse(lblFloorID.Text),
                        room_id = int.Parse(lblRoomID.Text),
                        room_name = txtRoomName.Text,
                        create_date = DateTime.UtcNow,
                        is_delete = false,
                        is_active = chkActive.Checked

                    });
                    
                }
            }

            return branchRoomEntities;
        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            List<BranchRoomEntity> branchRoomEntities = getDataFromRpt();
            //BranchRoomEntity branchRoomEntity = new BranchRoomEntity();

            for (int i = 0; i < 1; i++)
            {
                branchRoomEntities.Add(new BranchRoomEntity
                {
                    room_id = 0,
                    floor_id = int.Parse(lblFloorID.Text),
                    room_name = "",
                    create_date = DateTime.UtcNow,
                    is_delete = false,
                    is_active = true

                });
            }
            SetDataTorpt(branchRoomEntities);

        }

        protected void lblBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/floor-setup.aspx?branch_id=" + lblBranchID.Text);
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {

            DateFormat dateFormat = new DateFormat();

            List<BranchRoomEntity> branchRoomEntities = getDataFromRpt();
            BranchRoomService branchRoomService = new BranchRoomService();
            //BranchRoomEntity branchRoomEntity = new BranchRoomEntity();

            if (branchRoomService.InsertDataMore(branchRoomEntities) > 0)
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/floor-setup.aspx?branch_id="+ lblBranchID.Text);
            }
            else
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/floor-setup.aspx?branch_id=" + lblBranchID.Text);

            }
        }
    }
}