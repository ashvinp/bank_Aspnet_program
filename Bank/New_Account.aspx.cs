using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class New_Account : System.Web.UI.Page
{
    Bankob ob = new Bankob();
    SqlDataReader dr, dr1;

    protected void Page_Load(object sender, EventArgs e)
    {
        ob.connectionOpen();
        dr = ob.displaydropdown("tbl_bank");
        while (dr.Read())
        {
            DropDownList1.Items.Add(new ListItem(dr["Bank_Name"].ToString()));
        }
        ob.connectionClose();
        ob.connectionOpen();
        dr1 = ob.displaydropdown("tbl_branch");
        while (dr1.Read())
        {
            DropDownList2.Items.Add(new ListItem(dr1["Branch_Name"].ToString()));
        }
        ob.connectionClose();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ob.connectionOpen();
        ob.addaccount(TextBox1.Text.ToString(), DropDownList1.SelectedItem.ToString(), DropDownList2.SelectedItem.ToString(), TextBox2.Text.ToString(), long.Parse(TextBox3.Text.ToString()), int.Parse(TextBox4.Text.ToString()));
        ob.connectionClose();
        Response.Redirect("~/New_Bank.aspx");
    }
}