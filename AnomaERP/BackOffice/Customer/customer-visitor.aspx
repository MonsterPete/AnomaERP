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
                                                                <th class="tbw-19">Visitor Code</th>
                                                                <th class="tbw-19">Visitor Date</th>
                                                                <th class="tbw-19">Visitor Time</th>
                                                                <th>Visitor Type</th>
                                                                <th class="tbw-9">Tools</th>
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
                                                                                <asp:LinkButton ID="lbnPrint" runat="server" ClientIDMode="AutoID" class="btn btn-dark rounded mr-2" Style="display: none">
                                                                    <i class="fas fa-print mr-1"></i>Print
                                                                                </asp:LinkButton>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                            <tr class="odd gradeX text-center">
                                                                <td></td>
                                                                <td colspan="2">
                                                                    <asp:Label ID="lblShowDate" runat="server" Text="date"></asp:Label></td>
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
                                                                <td class="text-center pr-0">
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
    <asp:Label ID="lblVistorID" runat="server" Visible="false"></asp:Label>
    <!-- MODAL Print -->
    <div class="modal fade" id="print" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1"
        aria-hidden="true">

        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel1">Print Document</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <table class="table table-bordered">
                                <thead class="thead-dark text-center">
                                    <tr>
                                        <th scope="col">Document Name</th>
                                        <th scope="col">Tools</th>
                                    </tr>
                                </thead>
                                <tbody class="text-center upload-modal">

                                    <asp:Repeater ID="rptPrint" runat="server" OnItemDataBound="rptPrint_ItemDataBound" OnItemCommand="rptPrint_ItemCommand">
                                        <ItemTemplate>
                                            <tr class="odd gradeX text-center">
                                                <td>
                                                    <asp:Label ID="lblSiteVisiteFileID" runat="server" Visible="false" Text="Label"></asp:Label>
                                                    <asp:Label ID="lblSiteVisiteFileURL" runat="server" Visible="false" Text="Label"></asp:Label>
                                                    <asp:Label ID="lblSiteVisiteFileName" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td class="text-center pr-0">
                                                    <div class="btn-group btn-group-sm">
                                                        <asp:LinkButton ID="lbnPrint" runat="server" ClientIDMode="AutoID" target="_blank" class="btn btn-dark rounded mr-2">
                                                                    <i class="fas fa-print mr-1"></i>PRINT
                                                        </asp:LinkButton>
                                                    </div>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>


    <!-- MODAL Upload -->
    <div class="modal fade" id="upload" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1"
        aria-hidden="true">


        <asp:UpdatePanel runat="server">
             <Triggers>
                <asp:PostBackTrigger ControlID="btnUpload" />
            </Triggers>
            <ContentTemplate>
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel1">Upload Document</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="text-center mb-4">
                                <asp:FileUpload ID="FileUpload" CssClass="upload-custom" runat="server" onchange="btnUpload()" />
                                <asp:Button ID="btnUpload" runat="server" autopostback="true" OnClick="btnUpload_Click" Style="display: none" />
                            </div>

                            <table class="table table-bordered">
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
                                                    <asp:Label ID="lblSiteVisiteFileName" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td class="text-center pr-0">
                                                    <div class="btn-group btn-group-sm">
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

                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
                </div>
            </ContentTemplate>         
        </asp:UpdatePanel>

        <script type="text/javascript" lang="javascript">    

            function openModal() {
                $('#upload').modal('show');
            }

            function btnUpload() {
                var btn = document.getElementById('<%= btnUpload.ClientID %>');
                btn.click();
            }
        </script>
</asp:Content>


