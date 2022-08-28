<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewClient.aspx.cs" Inherits="WebMY1.NewClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 32px; width: 1312px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 44px; top: 120px; position: absolute; height: 15px; width: 99px" Text="First Name:"></asp:Label>
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 178px; top: 40px; position: absolute; height: 30px;" Text="New Client" Font-Underline="True" ForeColor="Red"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 42px; top: 171px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 40px; top: 212px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="LName" runat="server" style="z-index: 1; left: 173px; top: 166px; position: absolute" OnTextChanged="CheckMyPage"></asp:TextBox>
        <asp:TextBox ID="Pword" runat="server" style="z-index: 1; left: 172px; top: 212px; position: absolute; height: 16px" OnTextChanged="CheckMyPage" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="FName" runat="server" style="z-index: 1; left: 174px; top: 113px; position: absolute; " OnTextChanged="CheckMyPage"></asp:TextBox>
        <asp:Calendar ID="DateCalendar" runat="server" style="z-index: 1; left: 160px; top: 383px; position: absolute; height: 213px; width: 259px" ValidateRequestMode="Disabled" OnSelectionChanged="DateCalendar_SelectionChanged" OnDayRender="DateCalendar_DayRender" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 686px; top: 216px; position: absolute" Text="Please enter a password with 6 numbers." ForeColor="Blue"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FName" ErrorMessage="Its empty!" style="z-index: 1; left: 336px; top: 115px; position: absolute; right: 910px" ForeColor="Red">Its empty!</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Pword" ErrorMessage="Its empty!" style="z-index: 1; left: 337px; top: 213px; position: absolute; width: 71px; right: 904px;" ForeColor="Red">Its empty!</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="LName" ErrorMessage="Its empty!" style="z-index: 1; left: 337px; top: 164px; position: absolute; height: 16px; width: 70px" ForeColor="Red">Its empty!</asp:RequiredFieldValidator>
        <asp:Button ID="ResetB" runat="server" style="z-index: 1; left: 261px; top: 610px; position: absolute" Text="Reset" OnClick="Button1_Click" />
        <asp:Button ID="Confirmation" runat="server" style="z-index: 1; left: 153px; top: 607px; position: absolute; height: 30px; right: 1071px;" Text="Confirm" OnClick="Button2_Click" Enabled="False" />
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 353px; top: 610px; position: absolute; height: 28px; width: 63px;" Text="Back" CausesValidation="False" OnClick="Button3_Click" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="LName" ErrorMessage="wrong name" style="z-index: 1; left: 487px; top: 165px; position: absolute" ValidationExpression="[A-Z a-z]{2,100}" ForeColor="Red">wrong name</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Pword" ErrorMessage="Password is not valid" style="z-index: 1; top: 216px; position: absolute; left: 485px" ValidationExpression="[0-9]{6}" ForeColor="Red">Password is not valid</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="FName" ErrorMessage="wrong name" style="z-index: 1; top: 116px; position: absolute; left: 486px" ValidationExpression="[A-Z a-z]{2,100}" ForeColor="Red">wrong name</asp:RegularExpressionValidator>
        <asp:TextBox ID="CPword" runat="server" OnTextChanged="CheckMyPage" style="z-index: 1; top: 257px; position: absolute; left: 172px;" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 10px; top: 257px; position: absolute" Text="Confirm password:"></asp:Label>
        <asp:TextBox ID="PhoneBox" runat="server" style="z-index: 1; left: 229px; top: 339px; position: absolute"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="CPword" ErrorMessage="RegularExpressionValidator" ForeColor="Red" style="z-index: 1; left: 484px; top: 262px; position: absolute" ValidationExpression="[0-9]{6}">Password is not valid</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="PhoneBox" ErrorMessage="Invalid Phone number" ForeColor="Red" style="z-index: 1; left: 601px; top: 347px; position: absolute" ValidationExpression="[0]\d{9}"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="CPword" ErrorMessage="Its empty!" ForeColor="Red" style="z-index: 1; left: 336px; top: 261px; position: absolute">Its empty!</asp:RequiredFieldValidator>
        <asp:Label ID="Label7" runat="server" ForeColor="Blue" style="z-index: 1; left: 557px; top: 493px; position: absolute; height: 47px;" Text="Label" Visible="False" Font-Size="XX-Large"></asp:Label>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="CPword" ControlToValidate="Pword" ErrorMessage="Password are not alike" ForeColor="Red" style="z-index: 1; left: 706px; top: 264px; position: absolute">Password are not alike</asp:CompareValidator>
        <p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 42px; top: 386px; position: absolute; height: 15px; right: 1189px;" Text="Birth Day"></asp:Label>
        </p>
        <asp:TextBox ID="EmailBox" runat="server" style="z-index: 1; left: 167px; top: 300px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 32px; top: 303px; position: absolute; right: 1176px" Text="Your Email:"></asp:Label>
        <p>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="EmailBox" ErrorMessage="RegularExpressionValidator" ForeColor="Red" style="z-index: 1; left: 363px; top: 302px; position: absolute" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Invalid email</asp:RegularExpressionValidator>
        </p>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 35px; top: 342px; position: absolute" Text="Phone Number for updates:"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="PhoneBox" ErrorMessage="Its empty!" ForeColor="Red" style="z-index: 1; left: 414px; top: 346px; position: absolute"></asp:RequiredFieldValidator>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 807px; top: 346px; position: absolute" Text="Private Phone only- xxx-xxxxxxx" ForeColor="Blue"></asp:Label>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/images (1).jpg" style="z-index: 1; left: 857px; top: 427px; position: absolute; height: 222px" />
    </form>
</body>
</html>
