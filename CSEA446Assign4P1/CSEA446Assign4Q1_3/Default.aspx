<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Height="219px"  TextMode="MultiLine" Width="569px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1.6a" />
    
        <br />
        <br />
        <br />
    
        <asp:TextBox ID="TextBox2" runat="server" Height="219px"  TextMode="MultiLine" Width="569px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="1.6b" />
        <br />
        <br />
        <br />
    
        <asp:TextBox ID="TextBox3" runat="server" Height="219px"  TextMode="MultiLine" Width="569px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="1.6c" />
    
    </div>
    </form>
</body>
</html>
