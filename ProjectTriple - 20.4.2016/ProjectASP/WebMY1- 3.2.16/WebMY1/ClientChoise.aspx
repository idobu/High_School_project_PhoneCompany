<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientChoise.aspx.cs" Inherits="WebMY1.ClientChoise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            z-index: 1;
            left: 4px;
            top: 121px;
            position: absolute;
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Welcome client !" ForeColor="#33CC33"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Choose your action in your account:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="MyChoise" runat="server" AutoPostBack="True" OnSelectedIndexChanged="MyChoise_SelectedIndexChanged">
                        <asp:ListItem>My Properties</asp:ListItem>
                        <asp:ListItem>Change my password</asp:ListItem>
                        <asp:ListItem>Show my phones and packs</asp:ListItem>
                        <asp:ListItem>To the store</asp:ListItem>
                        <asp:ListItem>Write us a complain</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/download (1).jpg" Width="236px" />
                </td>
                <td>
                    <asp:Button ID="Action" runat="server" Enabled="False" OnClick="Action_Click" Text="Action" />
                </td>
                <td>
                    <asp:Button ID="AccountExit" runat="server" OnClick="AccountExit_Click" Text="Quit my account" CausesValidation="False" />
                </td>
            </tr>
        </table>
        <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" Font-Underline="True" ForeColor="Red" style="position: absolute; z-index: 1; left: 497px; top: 58px" Text="Account Actions"></asp:Label>
    </form>
</body>
</html>
