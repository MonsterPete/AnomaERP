﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnomaERP.BackOffice.Customer
{
    public partial class ShowPDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Url.Value = Session["PdfUrl"].ToString();
        }
    }
}