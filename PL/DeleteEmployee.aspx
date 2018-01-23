<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteEmployee.aspx.cs" Inherits="DeleteEmployee" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Delete Employee Confirmation<br />
        <br />
        <table style="width: 320px">
            <tr>
                <td>
                    EmployeeID</td>
                <td>
                    <asp:Label ID="lblEmployeeID" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    LastName</td>
                <td>
                    <asp:Label ID="lblLastName" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    FirstName</td>
                <td>
                    <asp:Label ID="lblFirstName" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    Title</td>
                <td>
                    <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    Address</td>
                <td>
                    <asp:Label ID="lblAddress" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    City</td>
                <td>
                    <asp:Label ID="lblCity" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    Region</td>
                <td>
                    <asp:Label ID="lblRegion" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    PostalCode</td>
                <td>
                    <asp:Label ID="lblPostalCode" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    Country</td>
                <td>
                    <asp:Label ID="lblCountry" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    Extension</td>
                <td>
                    <asp:Label ID="lblExtension" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
        </table>
    
    </div>
        <br />
        Are you sure you want to delete this employee record: &nbsp; &nbsp;
        <asp:Button ID="btnYES" runat="server" Text="YES" OnClick="btnYES_Click" />
        &nbsp; &nbsp;
        <asp:Button ID="btnNO" runat="server" Text="NO" OnClick="btnNO_Click" /><br />
        <br />
        &nbsp;&nbsp;
    </form>
</body>
</html>
