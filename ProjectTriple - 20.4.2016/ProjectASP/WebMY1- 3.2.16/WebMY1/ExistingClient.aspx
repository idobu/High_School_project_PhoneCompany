<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExistingClient.aspx.cs" Inherits="WebMY1.ExistingClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 120px;
            height: 16px;
            left: 245px;
            top: 181px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="z-index: 1">
    <div>
    
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 132px; top: 239px; position: absolute" Text="Password:"></asp:Label>
    
    </div>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 151px; top: 303px; position: absolute; height: 31px; width: 66px;" Text="Confirm" OnClick="Button1_Click" />
        <asp:TextBox ID="UserName" runat="server" CssClass="auto-style1" style="z-index: 1; position: absolute; right: 956px;"></asp:TextBox>
        <asp:TextBox ID="Pword" runat="server" style="z-index: 1; left: 243px; top: 239px; position: absolute; width: 127px;" TextMode="Password"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 246px; top: 303px; position: absolute; height: 30px; width: 57px" Text="Back" OnClick="Button2_Click" CausesValidation="False" />
        <asp:Label ID="Label1" runat="server" BackColor="White" Font-Size="XX-Large" ForeColor="Blue" style="z-index: 1; left: 280px; top: 94px; position: absolute; height: 46px; width: 122px; margin-bottom: 0px;" Text="Log In" Font-Underline="True"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 131px; top: 184px; position: absolute" Text="Username:"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage="RequiredFieldValidator" style="z-index: 1; left: 397px; top: 184px; position: absolute" ForeColor="Red">Is empty!</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Pword" ErrorMessage="RequiredFieldValidator" style="z-index: 1; left: 397px; top: 242px; position: absolute" ForeColor="Red">Is empty!</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="UserName" ErrorMessage="RegularExpressionValidator" style="z-index: 1; left: 564px; top: 183px; position: absolute" ValidationExpression="[0-9]{3}" ForeColor="Red">Wrong username</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Pword" ErrorMessage="RegularExpressionValidator" style="z-index: 1; left: 563px; top: 239px; position: absolute; height: 16px" ValidationExpression="[0-9]{6}" ForeColor="Red">Password incorrect</asp:RegularExpressionValidator>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 331px; top: 303px; position: absolute; height: 31px;" Text="New client?" CausesValidation="False" />
        <asp:Label ID="WarningText" runat="server" ForeColor="Red" style="z-index: 1; left: 21px; top: 366px; position: absolute" Text="Dear client, a manager must active and accept your account first before you make any action in the system." Visible="False"></asp:Label>
    </form>
</body>
</html>
