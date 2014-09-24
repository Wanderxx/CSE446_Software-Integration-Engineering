<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome Guess Number</h2>
    <p> lower Bound 
    <asp:TextBox ID="lowerTxt" runat="server"></asp:TextBox>
    &nbsp;&nbsp; upper Bound&nbsp; 
    <asp:TextBox ID="UpperTxt" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn1" runat="server" onclick="Btn1_Click" Text="Generate Num" />
&nbsp;&nbsp;
        <asp:Label ID="lblgenerate" runat="server"></asp:Label>
    </p>
    <p> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="lowtxt0" runat="server"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:Button ID="Btn2" runat="server" Text="Guess" onclick="Btn2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Attempts&nbsp;&nbsp;
        <asp:Label ID="lbl1" runat="server" Text="0 "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; The Num is&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl2" runat="server"></asp:Label>
    </p>
  
</asp:Content>
