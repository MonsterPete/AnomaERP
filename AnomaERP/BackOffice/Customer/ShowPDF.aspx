<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowPDF.aspx.cs" Inherits="AnomaERP.BackOffice.Customer.ShowPDF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title></title>
    <style>
        html, body, form, object {
            width: 100%;
            height: 100%;
        }
    </style>


    <script>
        $(document).ready(function () {
            var url = $("#<%=Url.ClientID %>").val();

            $("#ObShowPdf").attr("data", url);
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <object id="ObShowPdf" type="application/pdf">       
        </object>

        <asp:HiddenField ID="Url" runat="server" />
    </form>

</body>
</html>
