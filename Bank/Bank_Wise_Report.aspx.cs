using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Bank_Wise_Report : System.Web.UI.Page
{
    Bankob ob = new Bankob();
    SqlDataReader dr;
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
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ob.connectionOpen();
        dt = ob.BankWiseReport(DropDownList1.SelectedItem.ToString());
        GridView1.DataSource = dt;
        GridView1.DataBind();
        ob.connectionClose();
    }
}