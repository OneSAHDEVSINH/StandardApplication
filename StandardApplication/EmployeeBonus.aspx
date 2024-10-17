<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeBonus.aspx.cs" Inherits="StandardApplication.EmployeeBonus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Information</title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="margin-top:5px">
            <asp:Label ID="lblName" runat="server" Text="Name" AssociatedControlID="txtName" />&nbsp;
            <asp:TextBox ID="txtName" runat="server" placeholder="Name" />
            <asp:Label ID="lblNameError" runat="server" Text="*" ForeColor="Red" />
        </div>

        <div style="margin-top:5px">
            <asp:Label ID="blSalary" runat="server" Text="Salary" AssociatedControlID="txtSalary" />&nbsp;
            <asp:TextBox ID="txtSalary" TextMode="Number" runat="server" placeholder="Salary" />
            <asp:Label ID="lblSalaryError" runat="server" Text="*" ForeColor="Red" />
        </div>

        <div style="margin-top:5px">
            <asp:Label ID="lblBonus" runat="server" Text="Bonus" AssociatedControlID="txtBonus" />&nbsp;
            <asp:TextBox ID="txtBonus" TextMode="Number" runat="server" placeholder="Bonus" ReadOnly="true" />
        </div>

        <div style="margin-top:5px">
            <asp:Label ID="lblNetSalary" runat="server" Text="NetSalary" AssociatedControlID="txtNetSalary" />&nbsp;
            <asp:TextBox ID="txtNetSalary" TextMode="Number" runat="server" placeholder="NetSalary" ReadOnly="true" />
        </div>

        <div style="margin-top:5px">
            <asp:Button ID="btnResult" runat="server" Text="Result" OnClick="btnResult_Click" />
        </div>

    </form>
</body>
</html>
