<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="customer-visitor.aspx.cs" Inherits="AnomaERP.BackOffice.Customer.customer_visitor" %>

<%@ MasterType VirtualPath="~/Masterpage.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script type="text/javascript">
        var pr = Sys.WebForms.PageRequestManager.getInstance();
        if (pr != null) {
            pr.add_endRequest(function (sender, e) {
                if (sender._postBackSettings.panelsToUpdate != null) {
                    hideProgress();
                }
            });
        };

        $(document).ready(function setformatime() {
            $('#txtAppointmentTime').timepicker({ timeFormat: 'HH:mm' });
        });

        function checkNumHour(txt) {
            if (txt.value != "") {

                num = parseInt(txt.value);
                if (isNaN(num)) {
                    txt.value = "";
                }
                else {
                    if (num > 23) {
                        txt.value = "";
                    }
                }
            }
        }

        function checkNumMiniute(txt) {
            if (txt.value != "") {

                num = parseInt(txt.value);
                if (isNaN(num)) {
                    txt.value = "";
                }
                else {
                    if (num > 59) {
                        txt.value = "";
                    }
                }
            }
        }
    </script>

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="container-fluid flex-grow-1 container-p-y">

                <h4 class="font-weight-bold py-3 mb-2">Customer Management
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Customer Management</a>/
                                    Customer Visitor Type
                                </small>
                            </div>
                </h4>

                <!-- Statistics -->
                <div class="card mb-3">
                    <div class="row no-gutters row-bordered">
                        <div class="col-md-12 col-lg-12 col-xl-12">
                            <div class="card-header">
                                <h5 class="font-weight-bold mb-0">Customer Information</h5>
                            </div>
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-lg-3 col-xl-3 mb-2">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm text-uppercase font-weight-bold">HN</label>
                                            <p class="border-bottom pt-2">
                                                <asp:Label ID="lblHNCode" runat="server" Text="Label"></asp:Label>
                                            </p>
                                        </div>
                                    </div>
                                    <div class="col-lg-3 col-xl-3 mb-2">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm text-uppercase font-weight-bold">Customer Name</label>
                                            <p class="border-bottom pt-2">
                                                <asp:Label ID="lblCustomerName" runat="server" Text="Label"></asp:Label>
                                            </p>
                                        </div>
                                    </div>
                                    <div class="col-lg-3 col-xl-3 mb-2">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm text-uppercase font-weight-bold">Phone No.</label>
                                            <p class="border-bottom pt-2">
                                                <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
                                            </p>
                                        </div>
                                    </div>
                                    <div class="col-lg-3 col-xl-3 mb-2">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm text-uppercase font-weight-bold">ID Card</label>
                                            <p class="border-bottom pt-2">
                                                <asp:Label ID="lblIdCard" runat="server" Text="Label"></asp:Label>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- / Statistics -->
                <div class="row">
                    <div class="col-md-12 col-lg-12">
                        <!-- Sale stats -->
                        <div class="card">
                            <!-- <h6 class="card-header">
                                        Customers
                                    </h6> -->
                            <div class="row no-gutters row-bordered">
                                <div class="col-md-12 col-lg-12 col-xl-12">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-12 col-xl-12 mb-2">
                                                <div class="table-responsive">
                                                    <table class="table table-hover table-bordered">
                                                        <thead class="thead-dark">
                                                            <tr class="text-center custom">
                                                                <th class="tbw-10">Visitor Code</th>
                                                                <th class="tbw-10">Visitor Date</th>
                                                                <th class="tbw-10">Appointment Time</th>
                                                                <th class="tbw-10">Visitor Time</th>
                                                                <th class="tbw-10">Visitor Type</th>
                                                                <th class="tbw-9">Tools</th>
                                                                <th class="tbw-9">Appointment Tools</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <asp:Repeater ID="rptCustomerList" runat="server" OnItemDataBound="rptCustomerList_ItemDataBound" OnItemCommand="rptCustomerList_ItemCommand">
                                                                <ItemTemplate>
                                                                    <tr class="odd gradeX text-center">
                                                                        <td>
                                                                            <asp:Label ID="lblVisitorCode" runat="server" Text="Label"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:Label ID="lblAppointmentTime" runat="server"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:Label ID="lblTime" runat="server" Text="Label"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <div class="form-group row justify-content-around mb-0">
                                                                                <div>
                                                                                    <label class="custom-control custom-radio">
                                                                                        <input runat="server" id="rptAN" name="custom-radio-1" type="radio" class="custom-control-input">
                                                                                        <span class="custom-control-label">AN</span>
                                                                                    </label>
                                                                                </div>
                                                                                <div>
                                                                                    <label class="custom-control custom-radio">
                                                                                        <input runat="server" id="rptVN" name="custom-radio-1" type="radio" class="custom-control-input">
                                                                                        <span class="custom-control-label">VN</span>
                                                                                    </label>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td class="text-center pr-0">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <asp:LinkButton ID="lbnUpload" runat="server" ClientIDMode="AutoID" class="btn btn-warning rounded mr-2">
                                                                    <i class="fas fa-upload mr-1"></i>Upload
                                                                                </asp:LinkButton>
                                                                            </div>
                                                                        </td>
                                                                        <td class="text-center pr-0">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <asp:LinkButton ID="lbnConfirm" runat="server" ClientIDMode="AutoID" CssClass="btn btn-success rounded mr-2" Text="Confirm">
                                                                                </asp:LinkButton>
                                                                                <asp:LinkButton ID="lbnCancle" runat="server" ClientIDMode="AutoID" CssClass="btn btn-danger rounded mr-2" Text="Cancle">
                                                                                </asp:LinkButton>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                            <tr class="odd gradeX text-center">
                                                                <td></td>
                                                                <td>
                                                                    <asp:Label ID="lblShowDate" runat="server" Text="date"></asp:Label></td>
                                                                <td class="text-center pr-0">
                                                                    <div class="form-group row justify-content-around mb-0">
                                                                        <div class="row">
                                                                            <asp:TextBox ID="txtAppointmentTimeHour" runat="server" CssClass="form-control text-center" Width="50px" MaxLength="2" onchange="javascript: checkNumHour(this);" ClientIDMode="AutoID" placeholder="hh"></asp:TextBox>
                                                                            :
                                                                            <asp:TextBox ID="txtAppointmentTimeMinute" runat="server" CssClass="form-control text-center" Width="50px" MaxLength="2" onchange="javascript: checkNumMiniute(this);" ClientIDMode="AutoID" placeholder="mm"></asp:TextBox>
                                                                        </div>
                                                                    </div>
                                                                </td>
                                                                <td></td>
                                                                <td>
                                                                    <div class="form-group row justify-content-around mb-0">
                                                                        <div>
                                                                            <label class="custom-control custom-radio">
                                                                                <input id="AN" name="custom-radio-3" type="radio" runat="server" class="custom-control-input" checked="">
                                                                                <span class="custom-control-label">AN</span>
                                                                            </label>
                                                                        </div>
                                                                        <div>
                                                                            <label class="custom-control custom-radio">
                                                                                <input id="VN" name="custom-radio-3" type="radio" runat="server" class="custom-control-input" checked="">
                                                                                <span class="custom-control-label">VN</span>
                                                                            </label>
                                                                        </div>
                                                                    </div>
                                                                </td>
                                                                <td colspan="2" class="text-center pr-0">
                                                                    <div class="btn-group btn-group-sm">
                                                                        <asp:LinkButton ID="lbnSave" runat="server" OnClick="lbnSave_Click" class="btn btn-primary rounded mr-2">
                                                                    <i class="fas fa-save mr-1"></i>Save
                                                                        </asp:LinkButton>
                                                                    </div>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <!-- / Sale stats -->
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
    <style>
        div.dataTables_wrapper [class*="col-md-"] {
            display: none;
        }
    </style>
    <script>
        function RefreshPage() {
            window.top.location = window.top.location
        }


        $(document).ready(function () {
            SetTable();
        });
        function SetTable() {
            $('#visitfile').dataTable({
                deferRender: true,
                order: [[0, "desc"]],
                iDisplayLength: 50,
                bFilter: false, bInfo: false
            });
        }

    </script>
    <asp:Label ID="lblVistorfileID" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lblVistorID" runat="server" Visible="false"></asp:Label>
    <!-- MODAL Upload -->
    <div class="modal fade" id="upload" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1"
        aria-hidden="true">
        <asp:UpdatePanel runat="server">
            <Triggers>
                <asp:PostBackTrigger ControlID="btnUpload" />
            </Triggers>
            <ContentTemplate>
                <div class="modal-dialog modal-dialog-centered  modal-lg" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel1">Upload Document</h5>
                            <button type="button" class="close" onclick="RefreshPage();" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="text-center mb-4">
                                <asp:FileUpload ID="FileUpload" Multiple="Multiple" CssClass="upload-custom" runat="server" onchange="btnUpload()" />
                                <asp:Button ID="btnUpload" runat="server" autopostback="true" OnClick="btnUpload_Click" Style="display: none" />
                                <asp:Label ID="lblWarning" runat="server" Style="color: red">กรุณาระบุไฟล์เป็น PDF เท่านั้น</asp:Label>
                            </div>
                            <table id="visitfile" class="datatables-demo table table-striped table-hover table-bordered">
                                <thead class="thead-dark text-center">
                                    <tr>
                                        <th scope="col">Document Name</th>
                                        <th scope="col">Tools</th>
                                    </tr>
                                </thead>
                                <tbody class="text-center upload-modal">
                                    <asp:Repeater ID="rptUpload" runat="server" OnItemDataBound="rptUpload_ItemDataBound" OnItemCommand="rptUpload_ItemCommand">
                                        <ItemTemplate>
                                            <tr class="odd gradeX text-center">
                                                <td>
                                                    <asp:Label ID="lblSiteVisiteFileID" runat="server" Visible="false" Text="Label"></asp:Label>
                                                    <asp:Label ID="lblSiteVisiteFileURL" runat="server" Visible="false" Text="Label"></asp:Label>
                                                    <asp:Label ID="lblSiteVisiteFileName" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td class="text-center pr-0">
                                                    <div class="btn-group btn-group-sm">
                                                        <asp:LinkButton ID="lbnView" runat="server" CssClass="btn btn-primary rounded mr-2" target="_blank">  
                                                            <i class="far fa-eye mr-1"></i>View
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="lbnPrint" runat="server" ClientIDMode="AutoID" class="btn btn-dark rounded mr-2">
                                                                    <i class="fas fa-print mr-1"></i>Dowload
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="lbnDelete" runat="server" ClientIDMode="AutoID" class="btn btn-danger rounded mr-2">
                                                                    <i class="fas fa-trash mr-1"></i>DELETE
                                                        </asp:LinkButton>
                                                    </div>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>

                            </table>
                            <%--                            <div class="text-center" id="NoData" runat="server">
                                No data available in table
                            </div>--%>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" onclick="RefreshPage();" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <!-- Add Page -->

        <div class="modal fade" id="PageDelete" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title" id="exampleModalCenterTitle">DELETE</h4>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        Do you want to delete ?
                    </div>
                    <div class="modal-footer">
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <asp:LinkButton ID="lbnclose2" CssClass="btn btn-secondary" data-dismiss="modal" runat="server">No</asp:LinkButton>
                                <asp:LinkButton ID="lbnDeleteYes" CssClass="btn btn-primary" OnClick="lbnDeleteYes_Click" runat="server">Yes</asp:LinkButton>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>

        <script type="text/javascript" lang="javascript">    

            function openModal() {
                $('#upload').modal('show');
            }

            function btnUpload() {
                var btn = document.getElementById('<%= btnUpload.ClientID %>');
                btn.click();
            }

            //function ShowCustomerRefImage(url) {
            //    var image = new Image();

            //    image.align = 'center';
            //    image.style = '-webkit-user-select: none; margin: 12% auto; display: grid; max-width: 65%; max-height: 100vh; overflow: hidden; object-fit: cover;';
            //    //transform: rotate(90deg);
            //    image.src = url;

            //    var meta = document.createElement('meta');
            //    meta.setAttribute('name', 'viewport');
            //    meta.content = "width=device-width, minimum-scale=0.1";

            //    var title = document.createElement('title');
            //    title.innerHTML = "DOC_Visitor_picItemBeforeRepair";

            //    var w = window.open("");
            //    w.document.head.appendChild(meta);
            //    w.document.head.appendChild(title);
            //    w.document.body.appendChild(image);
            //    w.document.body.setAttribute("style", "margin: 0px; background: #0e0e0e;")
            //    //w.document.writeln(image.outerHTML);
            //}


            function ShowPDF() {
                window.open('/BackOffice/Customer/ShowPDF.aspx');
            }
        </script>
</asp:Content>


