<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="inventory.aspx.cs" Inherits="AnomaERP.BackOffice.Inventory.inventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Inventory Management
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Inventory Management</a>/
                                    Inventory Management List
                                </small>
                            </div>
            </h4>

            <div class="row">
                <div class="col-lg-12 col-xl-12">
                    <%--  <a href="#" class="btn btn-success mb-3"
                        data-toggle="modal" data-target="#modals-create-inbound">+ Create Inbound
                    </a>--%>
                    <a href="inventory-inbound-form.aspx" class="btn btn-success mb-3">+ Create Inbound</a>

                    <%-- <a href="#" class="btn btn-info mb-3"
                        data-toggle="modal" data-target="#modals-create-outbound">+ Create outbound
                    </a>--%>
                    <a href="inventory-outbound-form.aspx" class="btn btn-info mb-3">+ Create outbound</a>

                </div>
            </div>

            <asp:Label ID="lblEntityID" runat="server" Text="" Visible="false"></asp:Label>

            <!-- Statistics -->
            <div class="card mb-3">
                <div class="row no-gutters row-bordered">
                    <div class="col-md-12 col-lg-12 col-xl-12">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-3 col-xl-3 mb-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Search</label>
                                        <asp:TextBox ID="txtSearch" placeholder="Search" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3 mb-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Branch</label>
                                        <asp:DropDownList ID="ddlBranch" runat="server" CssClass="form-control form-control-sm">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3 mb-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Category</label>
                                        <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control form-control-sm">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                             <%--<a href="#" class="btn btn-primary">Search</a>--%>
                            <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="btnSearch_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <!-- / Statistics -->

            <div class="row">
                <div class="col-lg-12 col-xl-12">
                    <div class="card-datatable table-responsive">
                        <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <table class="datatables-demo table table-striped table-hover table-bordered">
                                    <thead class="thead-dark">
                                        <tr>
                                            <th>SKU</th>
                                            <th>Serial</th>
                                            <th>Name</th>
                                            <th>Type</th>
                                            <th>QTY</th>
                                            <th>On Hand</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:Repeater ID="resultList" runat="server" OnItemDataBound="rptList_ItemDataBound" OnItemCommand="rptList_ItemCommand">
                                            <%-- OnItemCommand="rptInquiryList_ItemCommand" OnItemDataBound="rptInquiryList_ItemDataBound"--%>
                                            <ItemTemplate>
                                                <tr runat="server" class="odd gradeX">
                                                    <td runat="server" style="text-align: center;">
                                                        <asp:Label ID="lblSku" runat="server"></asp:Label>
                                                    </td>
                                                    <td runat="server" style="text-align: center;">
                                                        <asp:Label ID="lblSerial" runat="server"></asp:Label>
                                                    </td>
                                                    <td runat="server" style="text-align: center;">
                                                        <asp:Label ID="lblName" runat="server"></asp:Label>
                                                    </td>
                                                    <td runat="server" style="text-align: center;">
                                                        <asp:Label ID="lblType" runat="server"></asp:Label>
                                                    </td>
                                                    <td runat="server" style="text-align: center;">
                                                        <asp:Label ID="lblQty" runat="server"></asp:Label>
                                                    </td>
                                                    <td runat="server" style="text-align: center;">
                                                        <asp:Label ID="lblOnHand" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>

        </div>
        <!-- / Content -->
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
    <%-- <div class="modal fade" id="modals-create-inbound">
        <asp:UpdatePanel runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h3 class="modal-title text-center mb-0">Inbound Request Form
                            </h3>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-lg-6 col-xl-6">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Branch</label>
                                        <input type="text" class="form-control form-control-sm" placeholder="Branch" value="V001">
                                    </div>
                                </div>
                                <div class="col-lg-6 col-xl-6">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Approver</label>
                                        <input type="text" class="form-control form-control-sm" placeholder="Approver" value="Pisan Ungchumchoke">
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12 col-xl-12">
                                    <div class="card-datatable table-responsive">
                                        <table class="datatables-demo table table-striped table-hover table-bordered">
                                            <thead class="thead-dark">
                                                <tr>
                                                    <th>SKU</th>
                                                    <th>Serial</th>
                                                    <th>Name</th>
                                                    <th>QTY</th>
                                                    <th>Tools</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr class="odd gradeX">
                                                    <td>AH0001</td>
                                                    <td>HN0002323</td>
                                                    <td>เครื่องช่วยหายใจ</td>
                                                    <td>90</td>
                                                    <td><a href="#" class="btn btn-danger btn-sm"><i class="ion ion-md-close"></i></a></td>
                                                </tr>
                                                <tr class="odd gradeX">
                                                    <td>AH0001</td>
                                                    <td>-</td>
                                                    <td>เครื่องช่วยหายใจ</td>
                                                    <td>100</td>
                                                    <td><a href="#" class="btn btn-danger btn-sm"><i class="ion ion-md-close"></i></a></td>
                                                </tr>
                                                <tr class="odd gradeX">
                                                    <td>AH0001</td>
                                                    <td>HN0002323</td>
                                                    <td>เครื่องช่วยหายใจ</td>
                                                    <td>12</td>
                                                    <td><a href="#" class="btn btn-danger btn-sm"><i class="ion ion-md-close"></i></a></td>
                                                </tr>
                                                <tr class="odd gradeX">
                                                    <td>
                                                        <div class="form-group mb-0">
                                                            <input type="text" class="form-control form-control-sm" placeholder="SKU">
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <div class="form-group mb-0">
                                                            <input type="text" class="form-control form-control-sm" placeholder="Serial">
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <div class="form-group mb-0">
                                                            <input type="text" class="form-control form-control-sm" placeholder="Name">
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <div class="form-group mb-0">
                                                            <input type="text" class="form-control form-control-sm" placeholder="Number">
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <button class="btn btn-success btn-sm">+ Add</button>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <hr class="m-0">
                        <div class="modal-footer">
                            <a href="#" class="btn btn-default" data-dismiss="modal">Cancel</a>
                            <asp:Button ID="btnInboundComfirm" runat="server" CssClass="btn btn-primary" Text="Comfirm" />

                        </div>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>--%>

    <%--  <div class="modal fade" id="modals-create-outbound">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">Outbound Request Form
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Branch</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Branch" value="V001">
                            </div>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Requester</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Requester" value="">
                            </div>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Approver</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Approver" value="">
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="card-datatable table-responsive">
                                <table class="datatables-demo table table-striped table-hover table-bordered">
                                    <thead class="thead-dark">
                                        <tr>
                                            <th>SKU</th>
                                            <th>Serial</th>
                                            <th>Name</th>
                                            <th>QTY</th>
                                            <th>Bed</th>
                                            <th>Tools</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class="odd gradeX">
                                            <td>AH0001</td>
                                            <td>HN0002323</td>
                                            <td>เครื่องช่วยหายใจ</td>
                                            <td>90</td>
                                            <td>VIP01</td>
                                            <td><a href="#" class="btn btn-danger btn-sm"><i class="ion ion-md-close"></i></a></td>
                                        </tr>
                                        <tr class="odd gradeX">
                                            <td>AH0001</td>
                                            <td>-</td>
                                            <td>เครื่องช่วยหายใจ</td>
                                            <td>100</td>
                                            <td>VIP01</td>
                                            <td><a href="#" class="btn btn-danger btn-sm"><i class="ion ion-md-close"></i></a></td>
                                        </tr>
                                        <tr class="odd gradeX">
                                            <td>AH0001</td>
                                            <td>HN0002323</td>
                                            <td>เครื่องช่วยหายใจ</td>
                                            <td>12</td>
                                            <td>VIP01</td>
                                            <td><a href="#" class="btn btn-danger btn-sm"><i class="ion ion-md-close"></i></a></td>
                                        </tr>
                                        <tr class="odd gradeX">
                                            <td>
                                                <div class="form-group mb-0">
                                                    <input type="text" class="form-control form-control-sm" placeholder="SKU">
                                                </div>
                                            </td>
                                            <td>
                                                <div class="form-group mb-0">
                                                    <input type="text" class="form-control form-control-sm" placeholder="Serial">
                                                </div>
                                            </td>
                                            <td>
                                                <div class="form-group mb-0">
                                                    <input type="text" class="form-control form-control-sm" placeholder="Name">
                                                </div>
                                            </td>
                                            <td>
                                                <div class="form-group mb-0">
                                                    <input type="text" class="form-control form-control-sm" placeholder="QTY">
                                                </div>
                                            </td>
                                            <td>
                                                <div class="form-group mb-0">
                                                    <input type="text" class="form-control form-control-sm" placeholder="Bed">
                                                </div>
                                            </td>
                                            <td>
                                                <a href="#" class="btn btn-success btn-sm">+ Add</a>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <hr class="m-0">
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" data-dismiss="modal">Cancel</a>
                    <a href="#" class="btn btn-success">Comfirm</a>
                </div>
            </div>
        </div>
    </div>--%>
</asp:Content>
