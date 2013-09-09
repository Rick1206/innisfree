<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userlist.aspx.cs" Inherits="Maticsoft.Web.userlist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
            BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
            DataKeyNames="ID" DataSourceID="AccessDataSource1" EnableModelValidation="True" 
            GridLines="Horizontal" PageSize="30">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                    ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="uname" HeaderText="姓名" SortExpression="uname" />
                <asp:BoundField DataField="usex" HeaderText="性别" SortExpression="usex" />
                <asp:BoundField DataField="uage" HeaderText="年龄" SortExpression="uage" />
                <asp:BoundField DataField="uphone" HeaderText="手机" SortExpression="uphone" />
                <asp:BoundField DataField="uemail" HeaderText="电子邮箱" SortExpression="uemail" />
                <asp:BoundField DataField="wid" HeaderText="微博id" SortExpression="wid" />
                <asp:BoundField DataField="wname" HeaderText="微博姓名" SortExpression="wname" />
                <asp:BoundField DataField="parameter1" HeaderText="时间" 
                    SortExpression="parameter1" />
                <asp:BoundField DataField="parameter2" HeaderText="ip地址" 
                    SortExpression="parameter2" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/data/innisfree.mdb" onselecting="AccessDataSource1_Selecting" 
            SelectCommand="SELECT [uname], [usex], [uage], [wid], [uphone], [uemail], [wname], [parameter1], [parameter2], [ID] FROM [userinfo] ORDER BY [ID] DESC">
        </asp:AccessDataSource>
    </div>
    </form>
</body>
</html>
