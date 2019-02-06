<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Entity-list.aspx.cs" Inherits="AnomaERP.BackOffice.Entity.Entity_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script type="text/javascript">
        var pr = Sys.WebForms.PageRequestManager.getInstance();
        if (pr != null) {
            pr.add_endRequest(function (sender, e) {
                if (sender._postBackSettings.panelsToUpdate != null) {
                    setControlPicker();
                    setModalPicker();
                    setInitUiLightBox();
                }
            });
        };

        function setInitUiLightBox() {
            var script = document.createElement("script");
            script.src = "/assets/js/ui_lightbox.js";
            document.head.appendChild(script);
            initPhotoSwipeFromDOM('#photoswipeViewSlips');
        }
        function callUploadImageInquiryList() {
            setInitInquiryListDropZone();
            callUploadImageInquiryList();
        }

        function setInitInquiryListDropZone() {
            var script = document.createElement("script");
            script.src = "/assets/js/forms_file-upload-inquiry-list.js";

            document.head.appendChild(script);
        }

        

        function showReturnPayment() {

            if ($("input:checked").length > 0) {
                $('#return-payment').css('display', 'flex');
            }
            else {
                $('#return-payment').css('display', 'none');
            }
        }

        function addCommas(inputText) {
            inputText += '';
            x = inputText.split('.');
            x1 = x[0];
            x2 = x.length > 1 ? '.' + x[1] : '';
            var rgx = /(\d+)(\d{3})/;
            while (rgx.test(x1)) {
                x1 = x1.replace(rgx, '$1' + ',' + '$2');
            }
            return x1 + x2;
        }
        function isNumber(inputText) {
            if (inputText != '') {
                num = parseFloat(inputText.value.replace(",", ""));
                if (isNaN(num)) {
                    alertMessage();
                    inputText.value = "0.00";
                    return;
                }
                else {
                    inputText.value = addCommas(num.toFixed(2));
                }
            }
        }
        function alertMessage() {
            swalAlertErrorNumber('กรุณากรอกตัวเลขให้ถูกต้อง');
        }

        $(function () {
            setControlPicker();
            setModalPicker();
        });
        $(document).ready(function () {
            $('#tableList').DataTable({
                "destroy": true,
                "order": [[1, "desc"]]
            });
        });

    </script>
    <asp:UpdatePanel ID="upnInquiryList" runat="server">
        <ContentTemplate>
            <div class="container-fluid flex-grow-1 container-p-y">
                <h4 class="font-weight-bold py-3 mb-2">Entity Management
           
            <div class="text-muted text-tiny mt-1">
                <small class="font-weight-normal text-uppercase">
                    <a href="javascript:void(0);" class="mr-1">ENTITY MANAGEMENT</a>/
                                    ENTITY LIST
                </small>
            </div>
                    <h4></h4>
                    <div class="row">
                        <div class="col-lg-12">
                            <a class="btn btn-success mb-3 mr-2" href="entity-info.aspx">+ Create Entity</a>                           
                        </div>
                    </div>
                    <!-- Statistics -->
                    <div class="card mb-3">
                        <!-- <h6 class="card-header with-elements">
                                <div class="card-header-title">Filters by</div>
                            </h6> -->
                        <div class="row no-gutters row-bordered">
                            <div class="col-md-12 col-lg-12 col-xl-12">
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">
                                                    Search</label>
                                                <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control form-control-sm" placeholder="ค้นหา"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">
                                                    Status</label>
                                                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control form-control-sm text-uppercase">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>                                    
                                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-primary"  Text="Search" /> <%--OnClick="btnSearch_Click"--%>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <div class="row">
                        <div class="col-md-12 col-lg-12">
                            <!-- Sale stats -->

                            <div class="card">
                                <!-- <h6 class="card-header">
                                        Customers
                                    </h6> -->                               
                                <div class="card-datatable table-responsive">
                                    <table id="tableList" class="datatables-demo table table-striped table-hover table-bordered">
                                        <thead class="thead-dark">
                                            <tr>
                                                <th style="width: 3%">#</th>
                                                <th style="width: 20%">Entity Name</th>
                                                <th style="width: 50%">Information</th>
                                                <th style="width: 10%">Status</th>
                                                <th style="width: 10%">Tools</th>                                                
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="rptInquiryList" runat="server" ><%-- OnItemCommand="rptInquiryList_ItemCommand" OnItemDataBound="rptInquiryList_ItemDataBound"--%>
                                                <ItemTemplate>
                                                    <tr id="trCountDays" runat="server" class="odd gradeX">                                                        
                                                        <td>
                                                            <asp:Label ID="lblInquiryDate" runat="server"></asp:Label>
                                                        </td>
                                                        <td id="tdCountDays" runat="server" style="text-align: center;">
                                                            <asp:Label ID="lblCountDays" runat="server"></asp:Label>
                                                        </td>
                                                        <td id="td1" runat="server" style="text-align: center;">
                                                            <asp:Label ID="Label1" runat="server"></asp:Label>
                                                        </td>
                                                        <td id="td2" runat="server" style="text-align: center;">
                                                            <asp:Label ID="Label2" runat="server"></asp:Label>
                                                        </td> 
                                                        <td class="center">
                                                            <div class="btn-group btn-group-sm">
                                                                <asp:LinkButton ID="lbnEdit" runat="server" CssClass="btn btn-primary"><i class="ion ion-md-create"></i></asp:LinkButton>                                                               
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <!-- / Sale stats -->
                        </div>
                    </div>
                        
                    <!-- / Statistics -->
                </h4>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
