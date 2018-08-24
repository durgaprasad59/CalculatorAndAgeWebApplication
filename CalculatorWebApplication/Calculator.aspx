<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebApplication1.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 223px;
        }
    </style>
</head>
<body style="height: 212px">
    <form id="form1" runat="server">
        <p>
            Enter First Number:
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 17px"></asp:TextBox>
        </p>
        <p>
            Enter Second Number:
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 12px"></asp:TextBox>
        </p>
        <p>
            Results:
            <asp:TextBox ID="TextBox3" runat="server" Height="16px" style="margin-left: 20px" Width="154px"></asp:TextBox>
        </p>
        <p style="height: 28px; margin-top: 2px">
            <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" style="margin-left: 9px" Text="Addition" Width="55px" />
&nbsp;&nbsp;
            <asp:Button ID="SubBtn" runat="server" OnClick="SubBtn_Click" Text="Subtraction" Width="73px" />
&nbsp;
            <asp:Button ID="MulBtn" runat="server" OnClick="MulBtn_Click" Text="Multiplication" Width="80px" />
&nbsp;
            <asp:Button ID="DivBtn" runat="server" OnClick="DivBtn_Click" Text="Division " />
        </p>
    </form>
</body>
</html>
