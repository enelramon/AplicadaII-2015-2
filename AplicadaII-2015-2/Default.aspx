<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicadaII_2015_2.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 415px;
        height: 553px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Hola mundo</h1>
    <img alt="" class="auto-style1" src="Img/angular.png" /><asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
&nbsp;<p> </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="SaludarButton" runat="server" OnClick="SaludarButton_Click" Text="Saludar" />
            <br />
            <asp:Label ID="SaludoLabel" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <p> &nbsp;</p>
</asp:Content>
