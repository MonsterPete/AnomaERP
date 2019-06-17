using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Definitions;
using Entity;
using Entity.Customer;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Service;
using Service.Customer;

namespace AnomaERP.BackOffice.Customer
{
    public partial class customer_visitor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CustomerService customerService = new CustomerService();
                CustomerEntity customerEntity = new CustomerEntity();
                customerEntity = customerService.GetDataByID(int.Parse(Request.QueryString["customer_id"].ToString()));
                lblCustomerName.Text = customerEntity.firstname + "   " + customerEntity.lastname;
                lblHNCode.Text = customerEntity.HN_no;
                lblIdCard.Text = customerEntity.id_card;
                lblPhone.Text = customerEntity.tel;
                lblShowDate.Text = DateTime.Now.AddYears(543).ToString("dd-MM-yyyy");
                setDataToRpt();
            }
        }

        private void setDataToRpt()
        {
            List<VisitEntity> visitEntities = new List<VisitEntity>();
            VisitService visitService = new VisitService();
            visitEntities = visitService.GetDataListByCustomerID(int.Parse(Request.QueryString["customer_id"].ToString()));
            rptCustomerList.DataSource = visitEntities;
            rptCustomerList.DataBind();
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            VisitEntity visitEntity = new VisitEntity();
            VisitService visitService = new VisitService();
            visitEntity.customer_id = int.Parse(Request.QueryString["customer_id"].ToString());
            visitEntity.branch_id = Master.branchEntity.branch_id;
            if (AN.Checked)
            {
                visitEntity.running_number_id = 3;
                visitEntity.visit_type = 3;
            }
            if (VN.Checked)
            {
                visitEntity.running_number_id = 4;
                visitEntity.visit_type = 4;
            }

            visitService.InsertData(visitEntity);
            setDataToRpt();
        }

        protected void rptCustomerList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            VisitEntity visitEntity = (VisitEntity)e.Item.DataItem;

            Label lblVisitorCode = (Label)e.Item.FindControl("lblVisitorCode");
            Label lblDate = (Label)e.Item.FindControl("lblDate");
            Label lblTime = (Label)e.Item.FindControl("lblTime");
            HtmlInputRadioButton rptAN = (HtmlInputRadioButton)e.Item.FindControl("rptAN");
            HtmlInputRadioButton rptVN = (HtmlInputRadioButton)e.Item.FindControl("rptVN");
            LinkButton lbnUpload = (LinkButton)e.Item.FindControl("lbnUpload");

            DateFormat dateFormat = new DateFormat();
            lblDate.Text = visitEntity.create_date.AddYears(543).ToString("dd-MM-yyyy");
            lblTime.Text = dateFormat.ThaiFormatTime(visitEntity.create_date);
            lblVisitorCode.Text = visitEntity.visit_code;
            if (visitEntity.visit_type == 3)
            {
                rptAN.Checked = true;
            }
            else
            {
                rptVN.Checked = true;
            }
            rptAN.Disabled = true;
            rptVN.Disabled = true;

            lbnUpload.CommandName = "Upload";
            lbnUpload.CommandArgument = visitEntity.visit_id.ToString();
        }

        protected void rptCustomerList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Upload")
            {
                lblVistorID.Text = e.CommandArgument.ToString();
                getDataVisitFileUpload(int.Parse(lblVistorID.Text));
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "none", "<script>$('#upload').modal('show');</script>", false);
            }
        }

        #region Upload
        private void getDataVisitFileUpload(int visit_id)
        {
            List<Visit_fileEntity> visit_FileEntities = new List<Visit_fileEntity>();
            VisitService visitService = new VisitService();
            visit_FileEntities = visitService.GetDataVisitFileByVisitorID(int.Parse(lblVistorID.Text));
            //NoData.Visible = true;
            //if (visit_FileEntities.Count > 0)
            //{
                rptUpload.DataSource = visit_FileEntities;
                rptUpload.DataBind();
            //    NoData.Visible = false;
            //}
        }

        protected void rptUpload_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Visit_fileEntity visit_FileEntity = (Visit_fileEntity)e.Item.DataItem;

            Label lblSiteVisiteFileID = (Label)e.Item.FindControl("lblSiteVisiteFileID");
            Label lblSiteVisiteFileURL = (Label)e.Item.FindControl("lblSiteVisiteFileURL");
            Label lblSiteVisiteFileName = (Label)e.Item.FindControl("lblSiteVisiteFileName");
            LinkButton lbnView = (LinkButton)e.Item.FindControl("lbnView");
            LinkButton lbnPrint = (LinkButton)e.Item.FindControl("lbnPrint");
            LinkButton lbnDelete = (LinkButton)e.Item.FindControl("lbnDelete");

            lblSiteVisiteFileID.Text = visit_FileEntity.visit_file_id.ToString();
            lblSiteVisiteFileURL.Text = visit_FileEntity.url.ToString();
            lblSiteVisiteFileName.Text = visit_FileEntity.file_name.ToString();
            lbnDelete.CommandName = "Delete";
            lbnDelete.CommandArgument = visit_FileEntity.visit_file_id.ToString();
            lbnView.CommandName = "View";
            lbnView.CommandArgument = visit_FileEntity.visit_file_id.ToString();
            lbnPrint.CommandName = "Dowload";
            lbnPrint.CommandArgument = visit_FileEntity.visit_file_id.ToString();
        }

        protected void rptUpload_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Label lblSiteVisiteFileURL = (Label)e.Item.FindControl("lblSiteVisiteFileURL");
            Label lblSiteVisiteFileName = (Label)e.Item.FindControl("lblSiteVisiteFileName");

            if (e.CommandName == "Delete")
            {
                lblVistorfileID.Text = e.CommandArgument.ToString();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "none", "<script>$('#PageDelete').modal('show');</script>", false);
                //e.Item.Visible = false;
            }
            else if (e.CommandName == "Dowload")
            {
                Response.Redirect(lblSiteVisiteFileURL.Text);
            }
            else if (e.CommandName == "View")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "ShowCustomerRefImage('" + lblSiteVisiteFileURL.Text + "');", true);
            }
        }

        protected void lbnDeleteYes_Click(object sender, EventArgs e)
        {
            Visit_fileEntity visit_FileEntity = new Visit_fileEntity();
            VisitService visitService = new VisitService();
            visit_FileEntity.visit_file_id = int.Parse(lblVistorfileID.Text);
            visit_FileEntity.is_delete = true;
            int success = visitService.DeleteVisitFile(visit_FileEntity);

            if (success > 0)
            {
                getDataVisitFileUpload(int.Parse(lblVistorID.Text));
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "none", "<script>$('#PageDelete').modal('hide');</script>", false);
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            int success = 0;
            int result = 0;
            AzureBlobEntity azureBlobEntity = new AzureBlobEntity();
            AzureBlobHelper azureBlobHelper = new AzureBlobHelper();

            try
            {
                Visit_fileEntity visit_FileEntity = new Visit_fileEntity();
                if (FileUpload.HasFiles)
                {
                    foreach (HttpPostedFile postfiles in FileUpload.PostedFiles)
                    {
                        if ((Path.GetExtension(postfiles.FileName.ToLower()) == ".jpg"
                            || Path.GetExtension(postfiles.FileName.ToLower()) == ".jpeg"
                            || Path.GetExtension(postfiles.FileName.ToLower()) == ".png"))
                        {
                            String url = String.Empty;
                            String fileName = "";
                            String getImgType = Path.GetExtension(postfiles.FileName).ToLower();
                            String hours = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                            fileName = postfiles.FileName;
                            int index = postfiles.FileName.IndexOf(getImgType);
                            fileName = "DOC_Visitor" + '_' + fileName.Substring(0, index) + '_' + hours + getImgType;

                            azureBlobEntity.Stream = postfiles.InputStream;
                            azureBlobEntity.ContainerName = "anoma-container";
                            azureBlobEntity.ConnectionString = Accesskeys.anomastorage;

                            azureBlobEntity.FileName = fileName;
                            url = azureBlobHelper.UploadFile(azureBlobEntity);

                            visit_FileEntity.visit_file_id = 0;
                            visit_FileEntity.visit_id = int.Parse(lblVistorID.Text);
                            visit_FileEntity.file_name = fileName;
                            visit_FileEntity.url = url;
                            visit_FileEntity.created_date = DateTime.Now;
                            visit_FileEntity.created_by = Master.branchEntity.branch_id;
                            visit_FileEntity.modified_date = DateTime.Now;
                            visit_FileEntity.modified_by = Master.branchEntity.branch_id;
                            visit_FileEntity.is_active = true;
                            visit_FileEntity.is_delete = false;

                            VisitService visitService = new VisitService();
                            success = visitService.InsertVisitFile(visit_FileEntity);
                            if (success > 0)
                            {
                                result += 1;
                            }
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "test", "alert('กรุณาระบุไฟล์เป็น .jpg หรือ .png เท่านั้น');", true);
                            return;
                        }
                    }
                    if (result > 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "test", "alert('อัพโหลด " + result + " ไฟล์สำเร็จ');", true);
                    }
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }
        #endregion
    }
}