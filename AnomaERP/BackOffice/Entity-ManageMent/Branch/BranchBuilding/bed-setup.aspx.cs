using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service.Branch.BranchBuilding;
using Entity;
using System.Web.UI.HtmlControls;
using Definitions;

namespace AnomaERP.BackOffice.Entity_ManageMent.Branch.BranchBuilding
{
    public partial class bed_setup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblBranchID.Text = "0";
                lblFloorID.Text = "0";
                lblRoomID.Text = "0";
                if (Request.QueryString["branch_id"] != null)
                {

                    if (int.Parse(Request.QueryString["branch_id"]) > 0)
                    {
                        lblBranchID.Text = Request.QueryString["branch_id"].ToString();
                        lblFloorID.Text = Request.QueryString["floor_id"].ToString();
                        lblRoomID.Text = Request.QueryString["room_id"].ToString();
                        SetDataToUI(int.Parse(lblRoomID.Text));
                    }
                }
            }
        }

        public void SetDataToUI(int Room_id)
        {
            BranchBedService branchBedService = new BranchBedService();
            List<BranchBedEntity> branchBedEntities = new List<BranchBedEntity>();

            branchBedEntities = branchBedService.GetDataBranchBedByID(Room_id);
            SetDataTorpt(branchBedEntities);

        }

        public void SetDataTorpt(List<BranchBedEntity> branchBedEntities)
        {
            rptBed.DataSource = branchBedEntities;
            rptBed.DataBind();
        }

        protected void rptBed_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            BranchBedEntity branchBedEntity = (BranchBedEntity)e.Item.DataItem;
            Label lblFloorID = (Label)e.Item.FindControl("lblFloorID");
            Label lblBranchID = (Label)e.Item.FindControl("lblBranchID");
            Label lblRoomID = (Label)e.Item.FindControl("lblRoomID");
            Label lblBedID = (Label)e.Item.FindControl("lblBedID");
            TextBox txtBedName = (TextBox)e.Item.FindControl("txtBedName");
            LinkButton lbnActive = (LinkButton)e.Item.FindControl("lbnActive");
            HtmlInputCheckBox chkActive = (HtmlInputCheckBox)e.Item.FindControl("chkActive");
            HiddenField hdfActive = (HiddenField)e.Item.FindControl("hdfActive");
            //LinkButton lbnDelete = (LinkButton)e.Item.FindControl("lbnDelete");
            LinkButton lbnBed = (LinkButton)e.Item.FindControl("lbnBed");

            lblFloorID.Text = lblFloorID.Text;
            lblRoomID.Text = branchBedEntity.room_id.ToString();
            lblBranchID.Text = lblBranchID.Text;
            lblBedID.Text = branchBedEntity.bed_id.ToString();
            txtBedName.Text = branchBedEntity.bed_name;
            hdfActive.Value = branchBedEntity.is_active.ToString();

            if (branchBedEntity.is_active == true)
            {
                chkActive.Attributes.Add("checked", "checked");
            }
            else if (branchBedEntity.is_active == false)
            {
                chkActive.Attributes.Remove("checked");
            }
            lbnActive.CommandName = "Active";
            lbnActive.CommandArgument = branchBedEntity.bed_id.ToString();
            //lbnBed.CommandName = "Bed";
            //lbnBed.CommandArgument = branchBedEntity.room_id.ToString();
        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            List<BranchBedEntity> branchBedEntities = getDataFromRpt();
            //BranchRoomEntity branchRoomEntity = new BranchRoomEntity();

            for (int i = 0; i < 1; i++)
            {
                branchBedEntities.Add(new BranchBedEntity
                {
                    room_id = int.Parse(lblRoomID.Text),
                    floor_id = int.Parse(lblFloorID.Text),
                    bed_name = "",
                    bed_type_id = 1,
                    create_date = DateTime.UtcNow,
                    is_delete = false,
                    is_active = true

                });
            }
            SetDataTorpt(branchBedEntities);
        }

        private List<BranchBedEntity> getDataFromRpt()
        {
            DateFormat dateFormat = new DateFormat();

            List<BranchBedEntity> branchBedEntities = new List<BranchBedEntity>();

            for (int i = 0; i < rptBed.Items.Count; i++)
            {
                
                Label lblBranchID = (Label)rptBed.Items[i].FindControl("lblBranchID");
                Label lblRoomID = (Label)rptBed.Items[i].FindControl("lblRoomID");
                Label lblBedID = (Label)rptBed.Items[i].FindControl("lblBedID");
                TextBox txtBedName = (TextBox)rptBed.Items[i].FindControl("txtBedName");
                HtmlInputCheckBox chkActive = (HtmlInputCheckBox)rptBed.Items[i].FindControl("chkActive");
                HiddenField hdfActive = (HiddenField)rptBed.Items[i].FindControl("hdfActive");

                BranchBedEntity branchBedEntity = new BranchBedEntity();
                BranchBedService branchBedService = new BranchBedService();
                branchBedEntity = branchBedService.GetDataByID(int.Parse(lblRoomID.Text));
                if (branchBedEntity.is_active == true)
                {
                    if (rptBed.Items[i].Visible == true)
                    {

                        branchBedEntities.Add(new BranchBedEntity
                        {
                            
                            room_id = int.Parse(lblRoomID.Text),
                            bed_id = int.Parse(lblBedID.Text),
                            bed_type_id = 1,
                            bed_name = txtBedName.Text,
                            create_date = DateTime.UtcNow,
                            is_delete = false,
                            is_active = chkActive.Checked

                        });
                    }
                    else
                    {

                        branchBedEntities.Add(new BranchBedEntity
                        {
                            
                            room_id = int.Parse(lblRoomID.Text),
                            bed_id = int.Parse(lblBedID.Text),
                            bed_type_id = 1,
                            bed_name = txtBedName.Text,
                            create_date = DateTime.UtcNow,
                            is_delete = false,
                            is_active = chkActive.Checked

                        });
                    }

                }
                else
                {
                    if (rptBed.Items[i].Visible == true)
                    {


                        branchBedEntities.Add(new BranchBedEntity
                        {
                            
                            room_id = int.Parse(lblRoomID.Text),
                            bed_id = int.Parse(lblBedID.Text),
                            bed_type_id = 1,
                            bed_name = txtBedName.Text,
                            create_date = DateTime.UtcNow,
                            is_delete = false,
                            is_active = chkActive.Checked

                        });
                    }
                    else
                    {

                        branchBedEntities.Add(new BranchBedEntity
                        {
                            
                            room_id = int.Parse(lblRoomID.Text),
                            bed_id = int.Parse(lblBedID.Text),
                            bed_type_id = 1,
                            bed_name = txtBedName.Text,
                            create_date = DateTime.UtcNow,
                            is_delete = false,
                            is_active = chkActive.Checked

                        });
                    }
                }
            }

            return branchBedEntities;
        }
        protected void lbnSave_Click(object sender, EventArgs e)
        {
            DateFormat dateFormat = new DateFormat();

            List<BranchBedEntity> branchBedEntities = getDataFromRpt();
            BranchBedService branchBedService = new BranchBedService();
            //BranchRoomEntity branchRoomEntity = new BranchRoomEntity();

            if (branchBedService.InsertDataMore(branchBedEntities) > 0)
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/room-setup.aspx?branch_id=" + lblBranchID.Text+"&floor_id="+lblFloorID.Text);

            }
            else
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/room-setup.aspx?branch_id=" + lblBranchID.Text + "&floor_id=" + lblFloorID.Text);

            }
        }

        protected void lblBack_Click(object sender, EventArgs e)
        {

        }

        protected void rptBed_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Active")
            {
                HiddenField hdfActive = (HiddenField)e.Item.FindControl("hdfActive");
                BranchBedEntity branchBedEntity = new BranchBedEntity();
                BranchBedService branchBedService = new BranchBedService();

                if (hdfActive.Value == "True")
                {
                    branchBedEntity.is_active = false;
                }
                else if (hdfActive.Value == "False")
                {
                    branchBedEntity.is_active = true;
                }
                branchBedEntity.bed_id = Int32.Parse(e.CommandArgument.ToString());


                if (branchBedService.UpdateData(branchBedEntity) > 0)
                {
                    //setDataToUI(setCondition());
                    //Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/floor-setup.aspx/branch_id=" + lblBranchID.Text);
                    SetDataToUI(int.Parse(lblRoomID.Text));
                }
            }
            //else if (e.CommandName == "Bed")
            //{
            //    Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/bed-setup.aspx?room_id=" + e.CommandArgument + "&branch_id=" + lblBranchID.Text + "&floor_id=" + lblFloorID.Text);
            //}
        }
    }
}