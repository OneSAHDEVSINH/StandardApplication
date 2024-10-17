<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="StandardApplication.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top:5px">
            <asp:Label ID="lblName" Text="Name" runat="server" AssociatedControlID="txtName" />
            <asp:TextBox ID="txtName" runat="server" />
        </div>

        <div style="margin-top:5px">
            <asp:Label ID="lblAddress" Text="Address" runat="server" AssociatedControlID="txtAddress" />
            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" />
        </div>

        <div style="margin-top:5px">
            <asp:Label ID="lblGender" Text="Gender" runat="server" />
            <asp:RadioButton ID="rdbMale" Text="Male" Checked="true" runat="server" GroupName="Gender" onCheckedChanged="rdbMale_CheckedChanged" AutoPostBack="true" />
            <asp:RadioButton ID="rdbFemale" Text="Female" runat="server" GroupName="Gender" onCheckedChanged="rdbFemale_CheckedChanged" AutoPostBack="true" />
            <asp:Label ID="lblSelectedGender" runat="server" />
        </div>

        <div style="margin-top:5px">
            <asp:Label ID="lblCity" runat="server" Text="City" />
            <asp:DropDownList ID="ddlCity" runat="server" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" AutoPostBack="true" />
        </div>

        <div style="margin-top:5px">
            <asp:Label ID="lblHobbies" runat="server" Text="Hobbies" />
            <asp:CheckBox ID="chkReading" Text="Reading" runat="server" />
            <asp:CheckBox ID="chkMusic" Text="Music" runat="server" />
            <asp:CheckBox ID="chkSwimming" Text="Swimming" runat="server" />
            <asp:CheckBox ID="chkSports" Text="Sports" runat="server" />
            <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" />
        </div>

        <div style="margin-top:5px">
            <asp:Button ID="btnResult" runat="server" OnClick="btnResult_Click" Text="Result" />
        </div>

        <div style="margin-top:5px">
            <asp:GridView ID="gvStudent" runat="server" />
        </div>

    </form>
</body>
</html>
