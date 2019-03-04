<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="bed-delete-accessory.aspx.cs" Inherits="AnomaERP.BackOffice.Bed_Management.Bed.bed_delete_accessory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script type='text/javascript'>
        function openModalError() {
            swal({
                title: '',
                text: 'ทำรายการไม่สำเร็จ',
                type: "error",
                confirmButtonClass: "btn-danger",
            });
        }

        function openModalWaring(msg) {
            swal({
                title: '',
                text: msg,
                type: "warning",
                confirmButtonClass: "btn-warning",
            });
        }

        function openModalSuccess() {
            swal({
                title: '',
                text: 'ทำรายการสำเร็จ',
                type: "success",
                confirmButtonClass: "btn-success",
            },
                function (isConfirm) {
                    if (isConfirm) {
                        window.location = '/BackOffice/Bed-Management/Bed/bed-entity.aspx';
                    }
                });
        }

         function checkNum(txt) {
            num = parseInt(txt.value);
            if (txt.value == "" || isNaN(num) || num == 0) {
                openModalWaring('กรุณากรอกข้อมูลให้ถูกต้อง');
            }
        }
    </script>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="layout-content">

                <!-- Content -->
                <div class="container-fluid flex-grow-1 container-p-y">

                    <h4 class="font-weight-bold py-3 mb-2">Bed Management
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Bed Management</a>/
                                    Bed Management List/Delete Accessory
                                </small>
                            </div>
                    </h4>

                    <!-- Statistics -->
                    <div class="card mb-3">

                        <asp:Label ID="lblBedID" runat="server" Text="" Visible="false"></asp:Label>

                        <h4 class="card-header with-elements">
                            <div class="card-header-title"><strong>Outbound Request Form</strong></div>
                        </h4>
                        <div class="row no-gutters row-bordered">
                            <div class="col-md-12 col-lg-12 col-xl-12">
                                <div class="modal-header">
                                </div>

                                <div class="modal-body">
                                    <div class="row">
                                        <div class="col-lg-6 col-xl-6">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Bed Name:</label>
                                                <%--<input type="text" class="form-control form-control-sm" placeholder="Branch" value="V001">--%>
                                                <asp:TextBox ID="txtbedname" runat="server" Enabled="false" CssClass="form-control form-control-sm"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="col-lg-6 col-xl-6">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Customer Name:</label>
                                                <%--<input type="text" class="form-control form-control-sm" placeholder="Requester" value="">--%>
                                                <asp:TextBox ID="txtcustomername" runat="server" Enabled="false" CssClass="form-control form-control-sm"></asp:TextBox>

                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-12 col-xl-12">
                                            <div class="card-datatable table-responsive">
                                                <table class="table table-striped table-hover table-bordered">
                                                    <thead class="thead-dark">
                                                        <tr>
                                                            <th>select</th>
                                                            <th>SKU</th>
                                                            <th>Serial</th>
                                                            <th>Date</th>
                                                            <th>Name</th>
                                                            <th>QTY Bed</th>
                                                            <th>QTY To Return</th>
                                                            <th style="display: none">Tools</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <asp:Repeater ID="resultList" runat="server" OnItemDataBound="resultList_ItemDataBound" OnItemCommand="resultList_ItemCommand">
                                                            <ItemTemplate>
                                                                <tr id="trCountDays" runat="server" class="odd gradeX">
                                                                    <td runat="server" style="text-align: center;">
                                                                        <label class="custom-control custom-checkbox mb-0" style="align-content: center;">
                                                                            <input type="checkbox" id="chkselect" runat="server" class="custom-control-input">
                                                                            <span class="custom-control-label">&nbsp;</span>
                                                                        </label>
                                                                    </td>
                                                                    <td runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblSku" runat="server"></asp:Label>
                                                                        <asp:Label ID="lblinventoryID" runat="server" Visible="false"></asp:Label>
                                                                        <asp:Label ID="lblbedinventoryID" runat="server" Visible="false"></asp:Label>
                                                                        <asp:HiddenField ID="flag" runat="server" />
                                                                    </td>
                                                                    <td runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblSerial" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblName" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblQtyBed" runat="server" ClientIDMode="AutoID"></asp:Label>
                                                                        <asp:Label ID="lblQtyTotal" runat="server" Visible="false"></asp:Label>
                                                                    </td>
                                                                    <td runat="server" style="text-align: center;">
                                                                        <asp:TextBox ID="txtQtyReturn" TextMode="Number" onchange="javascript: checkNum(this);" ClientIDMode="AutoID" runat="server"></asp:TextBox>
                                                                    </td>
                                                                    <td class="center" style="display: none">
                                                                        <div class="btn-group btn-group-sm">
                                                                            <asp:LinkButton ID="lbnRemove" ClientIDMode="AutoID" runat="server" CssClass="btn btn-danger btn-sm"><i class="ion ion-md-close" ></i></asp:LinkButton>
                                                                        </div>
                                                                    </td>
                                                                </tr>
                                                            </ItemTemplate>
                                                        </asp:Repeater>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <hr class="m-0">

                                <div class="modal-footer">
                                    <a href="/BackOffice/Bed-Management/Bed/bed-entity.aspx" class="btn btn-lg btn-default">Cancel</a>
                                    <%--<a href="#" class="btn btn-lg btn-success">Save</a>--%>
                                    <asp:Button ID="btnSave" runat="server" CssClass="btn btn-lg btn-primary" Text="Confirm" OnClick="btnSave_Click" />
                                </div>
                            </div>
                        </div>
                        <!-- / Statistics -->
                    </div>

                    <!-- / Content -->

                    <!-- Layout footer -->

                    <!-- / Layout footer -->
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
