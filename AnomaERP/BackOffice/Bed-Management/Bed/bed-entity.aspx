<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="bed-entity.aspx.cs" Inherits="AnomaERP.BackOffice.Bed_Management.Bed.bed_entity" %>
<%@ MasterType VirtualPath="~/Masterpage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <script>

                $(document).ready(function () {
                    $('#tableList').DataTable({
                        "destroy": true,
                        "pageLength": 50,
                        "order": [[1, "desc"]]
                    });
                })

            </script>
            <div class="layout-content">

                <!-- Content -->
                <div class="container-fluid flex-grow-1 container-p-y">

                    <h4 class="font-weight-bold py-3 mb-2">Bed Management
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Bed Management</a>/
                                    Bed Management List
                                </small>
                            </div>
                    </h4>

                    <!-- Statistics -->
                    <div class="card mb-3">
                        <asp:HiddenField ID="hdfBedId" runat="server" />
                        <asp:HiddenField ID="hdfCustomerId" runat="server" />
                        <asp:HiddenField ID="hdfBedCustomerId" runat="server" />
                        <asp:HiddenField ID="hdfBedName" runat="server" />
                        <div class="row no-gutters row-bordered">
                            <div class="col-md-12 col-lg-12 col-xl-12">
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Branch</label>
                                                <asp:TextBox ID="txtBranch" CssClass="form-control form-control-sm" placeholder="Branch" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Floor</label>
                                                <asp:TextBox ID="txtFloor" CssClass="form-control form-control-sm" placeholder="Floor" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Customer Name</label>
                                                <asp:TextBox ID="txtCustomerName" CssClass="form-control form-control-sm" placeholder="Customer Name" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Status</label>
                                                <input type="text" class="form-control form-control-sm" placeholder="Status">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="card-footer">
                                    <a href="#" class="btn btn-primary">Search</a>
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
                                                    <div class="card-datatable table-responsive">
                                                        <table id="tableList" class="datatables-demo table table-striped table-hover table-bordered">
                                                            <thead class="thead-dark">
                                                                <tr>
                                                                    <th>Branch</th>
                                                                    <th>Floor</th>
                                                                    <th>Room</th>
                                                                    <th>Bed</th>
                                                                    <th>Customer</th>
                                                                    <th>Status</th>
                                                                    <th>Job Assign</th>
                                                                    <th>Tools</th>
                                                                    <th>Accessory</th>
                                                                </tr>
                                                            </thead>
                                                            <tbody>
                                                                <asp:Repeater ID="rptBedEntity" OnItemDataBound="rptBedEntity_ItemDataBound" OnItemCommand="rptBedEntity_ItemCommand" runat="server">
                                                                    <ItemTemplate>
                                                                        <tr class="odd gradeX">
                                                                            <td>
                                                                                <asp:Label ID="lblBranch" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Label ID="lblFloor" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Label ID="lblRoom" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Label ID="lblBed" runat="server"></asp:Label>
                                                                                <asp:Label ID="lblBedId" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <asp:LinkButton ID="lbnAssign" runat="server" ClientIDMode="AutoID" CssClass="btn btn-primary btn-sm">Assign</asp:LinkButton>
                                                                                <asp:Label ID="lblCustomer" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td style="text-align:center">
                                                                                <asp:Label ID="lblStatus" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td>-</td>
                                                                            <td class="center">
                                                                                <div runat="server" id="manupnl">

                                                                                    <%--                                                                                    <div class="btn-group btn-group-sm">
                                                                                        <a href="" class="btn btn-primary" title="Edit"
                                                                                            data-toggle="modal" data-target="#modals-assign-edit">
                                                                                            <i class="ion ion-md-create"></i></a>
                                                                                    </div>--%>
                                                                                    <div class="btn-group btn-group-sm">
                                                                                        <asp:LinkButton runat="server" ID="lbnCustomerGoOutBed" ClientIDMode="AutoID" class="btn btn-success text-white" ToolTip="OutToBed">
                                                                                            <i class="ion ion-md-log-out"></i></asp:LinkButton>
                                                                                    </div>
                                                                                    <div class="btn-group btn-group-sm">
                                                                                        <asp:LinkButton runat="server" ID="lbnAdmit" ClientIDMode="AutoID" class="btn btn-warning text-white" ToolTip="Admit">
                                                                                            <i class="ion ion-md-medkit"></i></asp:LinkButton>
                                                                                    </div>
                                                                                    <div class="btn-group btn-group-sm">
                                                                                        <asp:LinkButton runat="server" ID="lbnDeleteCustomer" ClientIDMode="AutoID" class="btn btn-danger text-white" ToolTip="Delete">
                                                                                            <i class="ion ion-md-close"></i></asp:LinkButton>
                                                                                    </div>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div runat="server" id="AccessoryTool">
                                                                                    <div class="btn-group btn-group-sm">
                                                                                        <asp:LinkButton runat="server" ID="lbnCustomerAddAccessory" ClientIDMode="AutoID" class="btn btn-success text-white" ToolTip="AddAccessory">
                                                                                            <i class="ion ion-md-add"></i></asp:LinkButton>
                                                                                    </div>
                                                                                    <div class="btn-group btn-group-sm">
                                                                                        <asp:LinkButton runat="server" ID="lbnCustomerDeleteAccessory" ClientIDMode="AutoID" class="btn btn-danger text-white" ToolTip="DeleteAccessory">
                                                                                            <i class="ion ion-md-trash"></i></asp:LinkButton>
                                                                                    </div>
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
                                    </div>
                                </div>

                            </div>
                            <!-- / Sale stats -->
                        </div>
                    </div>

                </div>
                <!-- / Content -->
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
    <script>
        function openModalGoOut() {
            $('#modals-gooutbed').modal('show');
        };
        function openModalAdmit() {
            $('#modals-admit').modal('show');
        };
        function openModalDeleteCustomer() {
            $('#modals-delete').modal('show');
        };
        function openModal() {
            $('#modals-assign').modal('show');

            $('#txtModalBedName').val(document.getElementById('<%= hdfBedName.ClientID %>').value);
        };
    </script>
<div class="modal fade" id="modals-delete">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">Delete Customer
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">คุณต้องการลบข้อมูลผู้ป่วยใช่หรือไม่</label>
                            </div>
                        </div>
                    </div>
                </div>
                <hr class="m-0">
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" data-dismiss="modal">Clear</a>
                    <asp:LinkButton ID="lbnDeleteCustomer" runat="server" OnClick="lbnDeleteCustomer_Click" CssClass="btn btn-success">Comfirm</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="modals-admit">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">Customer Admit
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">ผู้ป่วยไม่ได้อยู่ที่เตียงใช่หรือไม่</label>
                            </div>
                        </div>
                    </div>
                </div>
                <hr class="m-0">
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" data-dismiss="modal">Clear</a>
                    <asp:LinkButton ID="lbnAdmit" runat="server" OnClick="lbnAdmit_Click" CssClass="btn btn-success">Comfirm</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="modals-gooutbed">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">Customer go out bed
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">คุณต้องการจะย้ายผู้ป่วยออกจากเตียงใช่หรือไม่</label>
                            </div>
                        </div>
                    </div>
                </div>
                <hr class="m-0">
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" data-dismiss="modal">Clear</a>
                    <asp:LinkButton ID="lbnGoOutBed" runat="server" OnClick="lbnGoOutBed_Click" CssClass="btn btn-success">Comfirm</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="modals-assign">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">Assgin management
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Bed</label>

                                <input type="text" readonly class="form-control form-control-sm" placeholder="Bed" id="txtModalBedName">
                            </div>
                        </div>
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Assgin To</label>
                                <asp:DropDownList ID="ddlCustomer" runat="server" CssClass="form-control form-control-sm"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <%--<div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <h5 class="mt-0"><strong>Contract Date</strong></h5>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Start Contract</label>
                                <asp:TextBox ID="txtDateStart" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">End Contract</label>
                                <asp:TextBox ID="txtDateEnd" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Status</label>
                                <asp:DropDownList ID="ddlStatus" CssClass="form-control form-control-sm" runat="server">
                                    <asp:ListItem Value="1">Vacant (Default)</asp:ListItem>
                                    <asp:ListItem Value="2">Waiting</asp:ListItem>
                                    <asp:ListItem Value="3">Active</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>--%>
                </div>
                <hr class="m-0">
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" data-dismiss="modal">Clear</a>
                    <asp:LinkButton ID="lbnComfirm" runat="server" OnClick="lbnComfirm_Click" CssClass="btn btn-success">Comfirm</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="modals-assign-edit">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">Edit Assgin management
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Bed</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Bed" value="V001">
                            </div>
                        </div>
                        <div class="col-lg-8 col-xl-8">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Assgin To</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Assgin To" value="Customer Name">
                            </div>
                        </div>
                        <div class="col-lg-4 col-xl-4">
                            <div class="form-group">
                                <div class="btn-group btn-group-sm mt-3">
                                    <a href="#" class="btn btn-warning mr-1">Change</a>
                                    <a href="#" class="btn btn-danger">Remove</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <h5 class="mt-0"><strong>Contract Date</strong></h5>
                        </div>
                        <div class="col-lg-5 col-xl-5">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Start Contract</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Start Time" id="datepicker-base">
                            </div>
                        </div>
                        <div class="col-lg-5 col-xl-5">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">End Contract</label>
                                <input type="text" class="form-control form-control-sm" placeholder="End Time" id="datepicker-base-2">
                            </div>
                        </div>
                        <div class="col-lg-2 col-xl-2 ">
                            <div class="form-group">
                                <div class="btn-group btn-group-sm mt-3">
                                    <a href="#" class="btn btn-primary btn-sm">Update</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-10 col-xl-10">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Status</label>
                                <select name="" class="form-control form-control-sm">
                                    <option value="">Vacant (Default)</option>
                                    <option value="">Waiting</option>
                                    <option value="">Active</option>
                                </select>
                            </div>
                        </div>
                        <div class="col-lg-2 col-xl-2">
                            <div class="form-group">
                                <div class="btn-group btn-group-sm mt-3">
                                    <a href="#" class="btn btn-primary btn-sm">Update</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <hr class="m-0">
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" data-dismiss="modal">Clear</a>
                    <a href="#" class="btn btn-success">Comfirm</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
