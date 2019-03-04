﻿using System;
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
                    return (BranchEntity)Session["BranchEntity"];
                }
            }
        }

        public EntityEntity entityEntity
        {
            get
            {

                if (Session["EntityEntity"] == null)
                {
                    return null;
                }
                else
                {
                    return (EntityEntity)Session["EntityEntity"];
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["BranchEntity"] != null)
                {
                    MenuNH.Visible = true;
                    MenuNA.Visible = true;
                    MenuBM.Visible = true;
                    MenuIN.Visible = true;
                    lblUsername.Text = branchEntity.branch_name;
                }
                else if (Session["EntityEntity"] != null)
                {
                    MenuEM.Visible = true;
                    MenuRP.Visible = true;
                    MenuNA.Visible = true;
                    lblUsername.Text = entityEntity.entity_name;
                }
                else
                {
                    Response.Redirect("/login.aspx");
                }

            }
        }

        protected void log_out_Click(object sender, EventArgs e)
        {
            clearSession();
            clearCacheAfterLogout();
            Response.Redirect("/login.aspx", false);
        }

        private void clearCacheAfterLogout()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
        }

        private void clearSession()
        {
            Session["BranchEntity"] = null;
            Session["EntityEntity"] = null;
        }
    }
}