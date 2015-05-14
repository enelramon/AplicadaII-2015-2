<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EjemploValidaciones.aspx.cs" Inherits="AplicadaII_2015_2.EjemploValidaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 63px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            color: #FF0000;
        }
        .auto-style4 {
            width: 63px;
            height: 26px;
        }
        .auto-style5 {
            width: 151px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Nombre" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    CssClass="auto-style3" 
                    ErrorMessage="Debe introducir el nombre" ControlToValidate="NombreTextBox">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Apellido" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="ApellidoTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                    runat="server" CssClass="auto-style3" 
                    ErrorMessage="Debe Introducir el apellido" ControlToValidate="ApellidoTextBox">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="ApellidoTextBox" ErrorMessage="Telefono no valido" style="color: #FF0000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2" colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style3" />
            </td>
        </tr>
    </table>
</asp:Content>
