<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DATABASE_PROCEDURE.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            ID : <asp:TextBox ID="eidtxt" runat="server" />
            <br />
            Name: <asp:TextBox ID="enametxt" runat="server" />
            <br />
            City : <asp:textbox ID="ecitytxt" runat="server" />
            <br />
            Salary : <asp:TextBox ID="esaltxt" runat="server" />
            <br />
            <asp:Button ID="insbtn" runat="server" Text="INSERT" OnClick="insbtn_Click" />
            <asp:Button ID="delbtn" runat="server" Text="DELETE" OnClick="delbtn_Click"/>
            <asp:Button ID="updbtn" runat="server" Text="UPDATE" OnClick="updbtn_Click"/>
            <asp:Button ID="disbtn" runat="server" Text="DISPLAY" OnClick="disbtn_Click"/>
            
        </div>
        <div>
            <asp:GridView ID="gridv" runat="server">

            </asp:GridView>
        </div>
    </form>
</body>
</html>
