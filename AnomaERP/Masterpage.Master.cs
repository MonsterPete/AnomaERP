using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

namespace AnomaERP
{
    public partial class Masterpage : System.Web.UI.MasterPage
    {
        public BranchEntity branchEntity
        {
            get
            {

                if (Session["BranchEntity"] == null)
                {
                    return null;
                }
                else
                {
                    return ((BranchEntity)Session["BranchEntity"]);
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}