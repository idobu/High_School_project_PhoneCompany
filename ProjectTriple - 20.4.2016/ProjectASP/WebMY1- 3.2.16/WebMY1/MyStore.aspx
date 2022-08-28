<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyStore.aspx.cs" Inherits="WebMY1.MyStore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 20px;
        }
        .auto-style3 {
            height: 72px;
        }
        .auto-style4 {
            height: 72px;
            width: 383px;
        }
        .auto-style5 {
            height: 20px;
            width: 383px;
        }
        .auto-style6 {
            width: 383px;
        }
        .auto-style7 {
            height: 72px;
            width: 4px;
        }
        .auto-style8 {
            height: 20px;
            width: 4px;
        }
        .auto-style9 {
            width: 4px;
        }
        .auto-style10 {
            height: 18px;
        }
        .auto-style11 {
            height: 18px;
            width: 383px;
        }
        .auto-style12 {
            height: 18px;
            width: 4px;
        }
        .auto-style13 {
            height: 72px;
            width: 381px;
        }
        .auto-style14 {
            height: 20px;
            width: 381px;
        }
        .auto-style15 {
            width: 381px;
        }
        .auto-style16 {
            height: 18px;
            width: 381px;
        }
        .auto-style17 {
            height: 72px;
            width: 10px;
        }
        .auto-style18 {
            height: 20px;
            width: 10px;
        }
        .auto-style19 {
            width: 10px;
        }
        .auto-style20 {
            height: 18px;
            width: 10px;
        }
        .auto-style21 {
            width: 381px;
            height: 215px;
        }
        .auto-style22 {
            height: 215px;
        }
        .auto-style23 {
            width: 10px;
            height: 215px;
        }
        .auto-style24 {
            width: 383px;
            height: 215px;
        }
        .auto-style25 {
            width: 4px;
            height: 215px;
        }
        .auto-style26 {
            width: 381px;
            height: 56px;
        }
        .auto-style27 {
            height: 56px;
        }
        .auto-style28 {
            width: 10px;
            height: 56px;
        }
        .auto-style29 {
            width: 383px;
            height: 56px;
        }
        .auto-style30 {
            width: 4px;
            height: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style3"></td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Phone and Packs Store:" Font-Size="X-Large" Font-Underline="True" ForeColor="Red"></asp:Label>
                    </td>
                <td class="auto-style3">
                    </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style17">
                    </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style4">
                    </td>
                <td class="auto-style7">
                    </td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style14">
                    </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    </td>
                <td class="auto-style2">
                    </td>
                <td class="auto-style2"></td>
                <td class="auto-style18">||</td>
                <td class="auto-style2">||</td>
                <td class="auto-style5">
                    </td>
                <td class="auto-style8">
                    </td>
                <td class="auto-style2">
                    </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="Label2" runat="server" Text="Store items:" ForeColor="#3333FF" Font-Size="Large"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="OurPhones" runat="server" Text="Store phones:" Font-Underline="True" ForeColor="#33CC33" Font-Size="X-Large"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style19">||</td>
                <td>||</td>
                <td class="auto-style6">
                    <asp:Label ID="OurPacks" runat="server" Text="Store packs:" Font-Underline="True" ForeColor="#33CC33" Font-Size="X-Large"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="Second, select the phone you wish to add:" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="thired, select the amount:" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="First, select the Category:" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style19">||</td>
                <td>||</td>
                <td class="auto-style6">
                    <asp:Label ID="Label17" runat="server" Text="Second, select the Pack you wish to add:" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label18" runat="server" Text="thired, select the amount:" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label19" runat="server" Text="First, select the Category:" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21">
                    </td>
                <td class="auto-style22"></td>
                <td class="auto-style22">
                    <asp:GridView ID="StorePhones" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="StorePhones_RowCommand" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField HeaderText="Available in stock" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                </td>
                <td class="auto-style22">
                    <asp:ListBox ID="phoneamount" runat="server" AutoPostBack="True" OnSelectedIndexChanged="phoneamount_SelectedIndexChanged"></asp:ListBox>
                </td>
                <td class="auto-style22">
                    <asp:ListBox ID="ClientPickPhone" runat="server" OnSelectedIndexChanged="ClientPickPhone_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>All the phones</asp:ListItem>
                        <asp:ListItem>Your favorits</asp:ListItem>
                        <asp:ListItem>Our suggestions</asp:ListItem>
                        <asp:ListItem>New in the store</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td class="auto-style23">
                    ||</td>
                <td class="auto-style22">
                    ||</td>
                <td class="auto-style24">
                    <asp:GridView ID="StorePacks" runat="server" OnSelectedIndexChanged="StorePacks_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" ForeColor="Black">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField HeaderText="Available in stock" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                </td>
                <td class="auto-style25">
                    <asp:ListBox ID="packamount" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
                </td>
                <td class="auto-style22">
                    <asp:ListBox ID="ClientPickPack" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ClientPickPack_SelectedIndexChanged">
                        <asp:ListItem>All the Packs</asp:ListItem>
                        <asp:ListItem>Your favorits</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Label ID="Label9" runat="server" Text="Click &quot;SELECT&quot; in order to add this phone type to your shoping cart" ForeColor="Blue"></asp:Label>
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style2"></td>
                <td class="auto-style18">||</td>
                <td class="auto-style2">||</td>
                <td class="auto-style5">
                    <asp:Label ID="Label10" runat="server" Text="Click &quot;SELECT&quot; in order to add this pack type to your shoping cart" ForeColor="Blue"></asp:Label>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style18">||</td>
                <td class="auto-style2">||</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">*******</td>
                <td class="auto-style2">*</td>
                <td class="auto-style2">
                    *******************************************</td>
                <td class="auto-style2">
                    **********</td>
                <td class="auto-style2">****************</td>
                <td class="auto-style18">*</td>
                <td class="auto-style2">*</td>
                <td class="auto-style5">
                    *******************************************</td>
                <td class="auto-style8">
                    **********</td>
                <td class="auto-style2">**************</td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10">
                    <asp:Label ID="Label3" runat="server" Text="Your Phone items:" Font-Underline="True" ForeColor="#FF66FF" Font-Size="X-Large"></asp:Label>
                </td>
                <td class="auto-style10">
                    </td>
                <td class="auto-style10"></td>
                <td class="auto-style20">||</td>
                <td class="auto-style10">||</td>
                <td class="auto-style11">
                    <asp:Label ID="Label4" runat="server" Text="Your Pack items:" Font-Underline="True" ForeColor="#FF66FF" Font-Size="X-Large"></asp:Label>
                </td>
                <td class="auto-style12">
                    </td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="Label6" runat="server" Text="Your cart:" ForeColor="Blue" Font-Size="Large"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:ListBox ID="YourPhones" runat="server" AutoPostBack="True" OnSelectedIndexChanged="YourPhones_SelectedIndexChanged"></asp:ListBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="auto-style19">
                    ||</td>
                <td>
                    ||</td>
                <td class="auto-style6">
                    <asp:ListBox ID="YourPacks" runat="server" AutoPostBack="True" OnSelectedIndexChanged="YourPacks_SelectedIndexChanged"></asp:ListBox>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Click the item in order to remove this phone from your cart" ForeColor="Blue"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="auto-style19">
                    ||</td>
                <td>
                    ||</td>
                <td class="auto-style6">
                    <asp:Label ID="Label12" runat="server" Text="Click the item in order to remove this Pack from your cart" ForeColor="Blue"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label20" runat="server" Text="*You are a client of DogWorld" Visible="False" ForeColor="#00CC00"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label25" runat="server" Text="50% off the total price" Visible="False"></asp:Label>
                </td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="161px" ImageUrl="~/Images/images.jpg" Width="180px" />
                </td>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="**You are client of Pizzeria" Visible="False" ForeColor="Fuchsia"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label24" runat="server" Text="30% off the total price" Visible="False"></asp:Label>
                </td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26"></td>
                <td class="auto-style27"></td>
                <td class="auto-style27">
                    </td>
                <td class="auto-style27">
                    <asp:Label ID="Label13" runat="server" Font-Size="Large" Font-Underline="True" ForeColor="Blue" Text="Total Payment:"></asp:Label>
                </td>
                <td class="auto-style27">
                    <asp:Label ID="Totalprice" runat="server" Text="Total Price" Font-Size="X-Large" ForeColor="#FF3300"></asp:Label>
                </td>
                <td class="auto-style28">
                    </td>
                <td class="auto-style27">
                    </td>
                <td class="auto-style29">
                    <asp:Label ID="Label26" runat="server" ForeColor="Red" Text="The prices are in Shekels"></asp:Label>
                    !!</td>
                <td class="auto-style30">
                    </td>
                <td class="auto-style27">
                </td>
                <td class="auto-style27"></td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="AcceptPur" runat="server" Text="Accept" OnClick="AcceptPur_Click" />
                </td>
                <td>
                    <asp:Label ID="Label21" runat="server" Font-Overline="False" Font-Underline="True" ForeColor="Blue" Text="Price After Discount:" Visible="False"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="TotalPriceafter" runat="server" Font-Size="X-Large" ForeColor="Red" Text="Total " Visible="False"></asp:Label>
                </td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="ReturnBack" runat="server" Text="Back" OnClick="ReturnBack_Click" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label8" runat="server" ForeColor="#0066FF" Text="Thank you !" Visible="False" Font-Size="X-Large"></asp:Label>
                </td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
