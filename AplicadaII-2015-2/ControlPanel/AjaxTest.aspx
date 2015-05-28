<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage.master" AutoEventWireup="true" CodeBehind="AjaxTest.aspx.cs" Inherits="AplicadaII_2015_2.ControlPanel.AjaxTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        function ShowCurrentTime() {
            $.ajax({
                type: "POST",
                url: "AjaxTest.aspx/GetCurrentTime",
                data: '{name: "' + $("#<%=txtUserName.ClientID%>")[0].value + '" }',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: OnSuccess,
                failure: function (response) {
                    alert(response.d);
                }
            });
        }

        function OnSuccess(response) {
            toastr["error"]("Ariel se quemara en  A", "lalalalal");

            //toastr.options = {
            //    "closeButton": false,
            //    "debug": false,
            //    "newestOnTop": false,
            //    "progressBar": false,
            //    "positionClass": "toast-top-right",
            //    "preventDuplicates": false,
            //    "onclick": null,
            //    "showDuration": "300",
            //    "hideDuration": "1000",
            //    "timeOut": "5000",
            //    "extendedTimeOut": "1000",
            //    "showEasing": "swing",
            //    "hideEasing": "linear",
            //    "showMethod": "fadeIn",
            //    "hideMethod": "fadeOut"
            //}

        }
    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">

    <h3>Test Ajax</h3>

    <img src="../Img/ajax.png" />

    <br />
    <br />

    <div>
        Nombre :       
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

        <input id="btnGetTime" onclick="ShowCurrentTime()" type="button" value="Fecha Actual" />
    </div>


</asp:Content>
