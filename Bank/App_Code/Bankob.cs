using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


public class Bankob
{
    SqlConnection conn;
    SqlCommand cmd, cmd1, cmd2, cmd3, cmd4, cmd5, cmd6;
    SqlDataReader dr;
    SqlDataAdapter da,da1,da2;
    DataSet dt,dt1,dt2;

    public void connectionOpen()
    {
        conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\ashwinp\\Documents\\Visual Studio 2010\\WebSites\\Bank\\App_Data\\BankDB.mdf\";Integrated Security=True;User Instance=True");
        conn.Open();
    }

    public void connectionClose()
    {
        conn.Close();
    }

    public void addbank(String bankname)
    {
        cmd = new SqlCommand("insert into tbl_bank values('" + bankname + "') ", conn);
        cmd.ExecuteNonQuery();
    }

    public void addbranch(int bankid, String branchname)
    {
        cmd1 = new SqlCommand("insert into tbl_branch values(" + bankid + ",'" + branchname + "')", conn);
        cmd1.ExecuteNonQuery();
    }

    public void addaccount(String custname, String bankname, String branchname, String address, long contactno, int balance)
    {
        cmd2 = new SqlCommand("insert into tbl_customer values('" + custname + "','" + bankname + "', '" + branchname + "', '" + address + "', " + contactno + ", " + balance + ")", conn);
        cmd2.ExecuteNonQuery();
    }

    public SqlDataReader displaydropdown(String TableName)
    {
        cmd3 = new SqlCommand("select * from " + TableName, conn);
        dr = cmd3.ExecuteReader();
        return dr;
    }

    public DataSet BankWiseReport(String bank)
    {
        dt = new DataSet();
        da = new SqlDataAdapter("select * from tbl_customer where Bank_Name='" + bank + "'", conn);
        da.Fill(dt,"tbl_customer");
        return dt;
    }

    public DataSet BranchWiseReport(String bank, String branch)
    {
        dt1 = new DataSet();
        da1 = new SqlDataAdapter("select * from tbl_customer where Bank_Name='" + bank + "' and Branch_Name='" + branch + "'", conn);
        da1.Fill(dt1, "tbl_customer");
        return dt1;
    }

    public DataSet checkBalance(String bank, String branch, int accountno)
    {
        dt2 = new DataSet();
        da2 = new SqlDataAdapter("select * from tbl_customer where Bank_Name='" + bank + "' and Branch_Name='" + branch + "' and CustomerId=" + accountno + "", conn);
        da2.Fill(dt2, "tbl_customer");
        return dt2;
    }

}