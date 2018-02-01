using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class New_Branch : System.Web.UI.Page
{
    Bankob ob = new Bankob();
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        ob.connectionOpen();
        dr = ob.displaydropdown("tbl_bank");
        while (dr.Read())
        {
            DropDownList1.Items.Add(new ListItem(dr["Bank_Name"].ToString()));
        }
        ob.connectionClose();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ob.connectionOpen();
        ob.addbranch(int.Parse((DropDownList1.SelectedIndex) + 1.ToString()), TextBox1.Text.ToString());
        ob.connectionClose();
        Response.Redirect("~/New_Bank.aspx");
    }
}