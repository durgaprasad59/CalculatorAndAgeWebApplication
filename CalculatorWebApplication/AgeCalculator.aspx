<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgeCalculator.aspx.cs" Inherits="CalculatorWebApplication.AgeCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Age: (MM/DD/YYYY)<asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-left: 18px"></asp:TextBox>
        <br />
        Select Gender:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Subbtn" runat="server" OnClick="Subbtn_Click" style="margin-left: 99px" Text="Submit" Width="196px" />
        <br />
        <br />
        Gender: <asp:Label ID="GenLab" runat="server"></asp:Label>
        <br />
        Age:
        <asp:Label ID="AgeLab" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
