using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Entity;
using Service.Branch;

namespace AnomaERP.BackOffice.Branch
{
    public partial class branch_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDataToUI(setCondition());
            }
        }

        protected void rptBranchList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            BranchEntity branchEntity = (BranchEntity)e.Item.DataItem;

            Label lblEntityID = (Label)e.Item.FindControl("lblEntityID");
            Label lblEntityName = (Label)e.Item.FindControl("lblEntityName");
            Label lblBranchID = (Label)e.Item.FindControl("lblBranchID");
            Label lblBranchName = (Label)e.Item.FindControl("lblBranchName");
            Label lblInformation = (Label)e.Item.FindControl("lblInformation");
            LinkButton lbnStatus = (LinkButton)e.Item.FindControl("lbnStatus");
            HtmlInputCheckBox chkStatus = (HtmlInputCheckBox)e.Item.FindControl("chkStatus");
            HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");
            LinkButton lbnEdit = (LinkButton)e.Item.FindControl("lbnEdit");
            HiddenField hdfFloor = (HiddenField)e.Item.FindControl("hdfFloor");
            LinkButton lbnFloor = (LinkButton)e.Item.FindControl("lbnFloor");

            lblEntityID.Text = branchEntity.entity_id.ToString();
            lblEntityName.Text = branchEntity.entity_name;
            lblBranchID.Text = branchEntity.branch_id.ToString();
            lblBranchName.Text = branchEntity.branch_name;
            lblInformation.Text = branchEntity.address;
            hdfStatus.Value = branchEntity.is_active.ToString();
           
            if (branchEntity.is_active == true)
            {
                chkStatus.Attributes.Add("checked", "checked");
            }
            else if (branchEntity.is_active == false)
            {
                chkStatus.Attributes.Remove("checked");
            }
            lbnStatus.CommandName = "Status";
            lbnStatus.CommandArgument = branchEntity.branch_id.ToString();
            lbnEdit.CommandName = "Edit";
            lbnEdit.CommandArgument = branchEntity.branch_id.ToString();
            lbnFloor.CommandName = "Floor";
            lbnFloor.CommandArgument = branchEntity.branch_id.ToString();
        }

        public void setDataToUI(BranchEntity branchEntity)
        {
            BranchService branchService = new BranchService();
            List<BranchEntity> branchEntities = new List<BranchEntity>();

            branchEntities = branchService.GetDataByCondition(branchEntity);

            
            rptBranchList.DataSource = branchEntities;
            rptBranchList.DataBind();
        }

        public BranchEntity setCondition()
        {
            BranchEntity branchEntity = new BranchEntity();

            branchEntity.branch_name = txtSearch.Text;
            branchEntity.entity_id = Master.entityEntity.entity_id;

            return branchEntity;
        }

        protected void rptBranchList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/Branch-create.aspx?branch_id=" + e.CommandArgument);
            }
            else if (e.CommandName == "Status")
            {
                HiddenField hdfStatus = (HiddenField)e.Item.FindControl("hdfStatus");
                BranchEntity branchEntity = new BranchEntity();
                BranchService branchService = new BranchService();

                if (hdfStatus.Value == "True")
                {
                    branchEntity.is_active = false;
                }
                else if (hdfStatus.Value == "False")
                {
                    branchEntity.is_active = true;
                }
                branchEntity.branch_id = Int32.Parse(e.CommandArgument.ToString());
                branchEntity.modify_date = DateTime.UtcNow;
                branchEntity.create_date = DateTime.UtcNow;

                if (branchService.UpdateData(branchEntity) > 0)
                {
                    //setDataToUI(setCondition());
                    Response.Redirect("/BackOffice/Entity-Management/Branch/Branch-list.aspx");
                }
            }
            else if (e.CommandName == "Floor")
            {
                Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/floor-setup.aspx?branch_id=" + e.CommandArgument);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            setDataToUI(setCondition());
        }
    
        protected void lbnFloor_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/BackOffice/Entity-Management/Branch/BranchBuilding/floor-setup.aspx");
        }
    }
}