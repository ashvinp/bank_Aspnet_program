﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Bank.master" AutoEventWireup="true" CodeFile="Check_Balance.aspx.cs" Inherits="Check_Balance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="margin-left:100px;margin-right:100px;">
<center>
<b>        <br />
    <asp:Label ID="Label1" runat="server" Text="Select Bank Name:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="176px">
    </asp:DropDownList>
        <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Select Branch Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" Height="21px" Width="176px">
    </asp:DropDownList>
        <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Select Account Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList3" runat="server" Width="176px">
    </asp:DropDownList>
        <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <input id="Reset1" type="reset" value="Reset" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
   </b>
    </center>
    </div>
</asp:Content>

