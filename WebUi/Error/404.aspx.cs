﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Error_404 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
	 Response.Status = "404 Not Found";
    }
}