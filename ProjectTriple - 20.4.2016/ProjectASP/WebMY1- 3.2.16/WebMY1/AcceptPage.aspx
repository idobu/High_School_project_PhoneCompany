<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptPage.aspx.cs" Inherits="WebMY1.AcceptPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Font-Underline="True" ForeColor="Red" Text="Thanke you for the Purches"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" ForeColor="Blue" Text="An Email was sent to your mail box to inform about the action."></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back to client actions" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/images (1).jpg" />
    </form>
</body>
</html>
