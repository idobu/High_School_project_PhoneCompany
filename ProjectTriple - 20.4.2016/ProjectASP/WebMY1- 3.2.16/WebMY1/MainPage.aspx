<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebMY1.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 272px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 140px">
    
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="Red" style="z-index: 1; left: 368px; top: 35px; position: absolute" Text="WELCOME TO PhoneStore !"></asp:Label>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/download (2).jpg" style="z-index: 1; left: 864px; top: 31px; position: absolute; height: 113px; width: 105px" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/download.jpg" style="z-index: 1; left: 180px; top: 23px; position: absolute; height: 117px; width: 125px" />
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" ForeColor="#3333FF" Text="PhoneStore, the best phone company around! "></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Font-Size="Large" ForeColor="Fuchsia" Text="What kind of Client are you?"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="I'm a NEW CLIENT:"></asp:Label>
                </td>
                <td class="auto-style2">I&#39;m a EXISTING CLIENT:</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" CausesValidation="False" ForeColor="#CC9900" OnClick="Button1_Click" Text="New" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" CausesValidation="False" ForeColor="#33CC33" OnClick="Button2_Click" Text="Exist" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
