<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientView.aspx.cs" Inherits="WebMY1.ClientView" %>

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
            height: 26px;
        }
        .auto-style4 {
            height: 30px;
        }
        .auto-style5 {
            height: 20px;
            width: 330px;
        }
        .auto-style6 {
            height: 26px;
            width: 330px;
        }
        .auto-style7 {
            width: 330px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:MultiView ID="MyViews" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
            <asp:View ID="PersonalProps" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label1" runat="server" Text="UserName:" ForeColor="Red"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:Label ID="UserNameLabel" runat="server" Text="Label" ForeColor="Blue"></asp:Label>
                        </td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label2" runat="server" Text="First Name:" ForeColor="Red"></asp:Label>
                        </td>
                        <td class="auto-style3">
                            <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style6">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FirstName" ErrorMessage="The text is empty"></asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style3">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="FirstName" ErrorMessage="invalid name/text" ValidationExpression="[A-Z a-z]{2,100}"></asp:RegularExpressionValidator>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Last Name:" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="LastName" ErrorMessage="The text is empty"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="LastName" ErrorMessage="invalid name/text" ValidationExpression="[A-Z a-z]{2,100}"></asp:RegularExpressionValidator>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Phone Number:" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="PhoneClient" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="PhoneClient" ErrorMessage="The text is empty"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="invalid Phone Number" ValidationExpression="[0]\d{9}" ControlToValidate="PhoneClient"></asp:RegularExpressionValidator>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label10" runat="server" ForeColor="Red" Text="Email:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="EmailBox" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="EmailBox" ErrorMessage="The text is empty"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="EmailBox" ErrorMessage="invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="BDCalender" runat="server" Text="BirthDay:" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            <asp:Calendar ID="DateCal" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#808080" />
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                            </asp:Calendar>
                        </td>
                        <td class="auto-style7">
                            <asp:Label ID="Label9" runat="server" Text="if the calender is not selected the last known birth date at the system will be saved"></asp:Label>
                            .</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Confirmation" runat="server" Text="Confirm" Width="72px" OnClick="Confirmation_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" CausesValidation="False" />
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="ChangeMyPassword" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="NewPassword" runat="server" Text="New Password:" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="Npass" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Npass">The field is empty</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="Npass" ValidationExpression="[0-9]{6}">Wrong password input</asp:RegularExpressionValidator>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="SecPassword" runat="server" Text="Reput your password:" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="APass" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="APass">The field is empty</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="APass" ValidationExpression="[0-9]{6}">Wrong password input</asp:RegularExpressionValidator>
                        </td>
                        <td>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToCompare="Npass" ControlToValidate="APass">The passwords are not alike</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Button ID="CPassword" runat="server" Text="Change Password" OnClick="CPassword_Click" />
                        </td>
                        <td class="auto-style4">
                            <asp:Button ID="PassBack" runat="server" Text="Back" OnClick="PassBack_Click" CausesValidation="False" />
                        </td>
                        <td class="auto-style4"></td>
                        <td class="auto-style4"></td>
                        <td class="auto-style4"></td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="PacksAndPhones" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Your Phones:" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Your Packs:" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="Phones" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                <RowStyle ForeColor="#000066" />
                                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#00547E" />
                            </asp:GridView>
                        </td>
                        <td>
                            <asp:GridView ID="Packs" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                <RowStyle ForeColor="#000066" />
                                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#00547E" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="TableBack" runat="server" OnClick="TableBack_Click" Text="Back" CausesValidation="False" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="WriteUsComplain" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Complain subject:" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Height="19px" Width="135px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Complain body:" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Height="126px" Width="271px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="AcceptComp" runat="server" OnClick="AcceptComp_Click" Text="Send complain" />
                        </td>
                        <td>
                            <asp:Button ID="BackComp" runat="server" OnClick="BackComp_Click" Text="Back" CausesValidation="False" />
                        </td>
                    </tr>
                </table>
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
