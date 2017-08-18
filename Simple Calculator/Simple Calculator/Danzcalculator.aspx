<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Danzcalculator.aspx.cs" Inherits="Simple_Calculator.Danzcalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Simple Calculator</strong></div>
        <p>
            <span class="auto-style2">First Value</span>&nbsp;
            <asp:TextBox ID="Value1TextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style2">Second Value</span>&nbsp;
            <asp:TextBox ID="Value2TextBox" runat="server" OnTextChanged="Value2TextBox_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="+" />
&nbsp;
        <asp:Button ID="SubtractButton" runat="server" OnClick="SubtractButton_Click" Text="-" />
&nbsp;
        <asp:Button ID="MultiplicationButton" runat="server" OnClick="MultiplicationButton_Click" Text="*" />
&nbsp;
        <asp:Button ID="DivisionButton" runat="server" OnClick="DivisionButton_Click" Text="/" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" style="font-weight: 700; background-color: #00FFFF"></asp:Label>
    </form>
</body>
</html>
