using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Branch_Wise_Report : System.Web.UI.Page
{
    Bankob ob = new Bankob();
    SqlDataReader dr,dr1;
    DataSet dt;

    protected void Page_Load(object sender, EventArgs e)
    {
        ob.connectionOpen();
        dr = ob.displaydropdown("tbl_bank");
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr["Bank_Name"].ToString());
        }
        ob.connectionClose();
        ob.connectionOpen();
        dr1 = ob.displaydropdown("tbl_branch");
        while (dr1.Read())
        {
            DropDownList2.Items.Add(dr1["Branch_Name"].ToString());
        }
        ob.connectionClose();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ob.connectionOpen();
        dt = ob.BranchWiseReport(DropDownList1.SelectedItem.ToString(),DropDownList2.SelectedItem.ToString());
        GridView1.DataSource = dt;
        GridView1.DataBind();
        ob.connectionClose();
    }
}