using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Entity;

namespace AnomaERP.BackOffice.Entity
{
    public partial class Entity_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            int success = 0;

            EntityEntity entityEntity = new EntityEntity();           
            EntityService entityService = new EntityService();

            entityEntity.entity_name = txtEntityName.Text;
        }       
    }
}