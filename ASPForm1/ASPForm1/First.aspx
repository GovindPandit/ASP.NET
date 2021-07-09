<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="ASPForm1.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Number" runat="server"></asp:TextBox>
            <asp:Button ID="Click" runat="server" Text="Click" OnClick="OnButtonClicked"/>
        </div>
    </form>
</body>
</html>
