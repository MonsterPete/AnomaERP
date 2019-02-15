using Entity;
using Service.BedManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnomaERP.BackOffice.Bed_Management.Bed
{
    public partial class bed_entity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BedCustomerService bedCustomerService = new BedCustomerService();
            bedCustomerService.SelectBedCustomerForBedEntity(setDataSearch());
        }

        private BedCustomerEntity setDataSearch()
        {
            BedCustomerEntity bedCustomerEntity = new BedCustomerEntity();
            if (!string.IsNullOrEmpty(txtBranch.Text))
            {
                bedCustomerEntity.branch_name = txtBranch.Text;
            }
            if (!string.IsNullOrEmpty(txtCustomerName.Text))
            {
                bedCustomerEntity.fullname = txtCustomerName.Text;
            }
            if (!string.IsNullOrEmpty(txtFloor.Text))
            {
                bedCustomerEntity.floor_name = txtFloor.Text;
            }
            return bedCustomerEntity;
        }
    }
}