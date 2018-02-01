using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class New_Bank : System.Web.UI.Page
{
    Bankob ob = new Bankob();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ob.connectionOpen();
        ob.addbank(TextBox1.Text.ToString());
        ob.connectionClose();
        Response.Redirect("~/New_Bank.aspx");
    }
}