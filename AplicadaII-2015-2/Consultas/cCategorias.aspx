<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage.master" AutoEventWireup="true" CodeBehind="cCategorias.aspx.cs" Inherits="AplicadaII_2015_2.Consultas.cCategorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">


   


    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
              <asp:Button ID="buscarButton" runat="server" Text="Buscar" OnClick="buscarButton_Click" />
    


              <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    


    <asp:DataList CellSpacing="5" CellPadding="5" ID="CategoriasDataList" 
         RepeatColumns="3" RepeatDirection="Horizontal" 
        runat="server" OnSelectedIndexChanged="CategoriasDataList_SelectedIndexChanged">
        <ItemTemplate>


            <table style="width: 100%;">
                <tr>
                    <td rowspan="4">
                        <img width="64" height="64" src="../Img/beer.png" /></td>
                    <td>Codigo:</td>
                    <td>
                        <asp:Label ID="CodigoLabel" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "IdCategoria") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Descripcion:</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Descripcion") %></td>
                </tr>
                <tr>
                    <td>Precio</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Cantidad") %> </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="PedirHyperLink" CssClass="addtothecart" CommandName="Select"
                            runat="server">Pedir</asp:LinkButton></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <hr />
        </ItemTemplate>
    </asp:DataList>

    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
