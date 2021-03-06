﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="inventory-inbound-form.aspx.cs" Inherits="AnomaERP.BackOffice.Inventory.inventory_inbound_form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">

    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Inventory Management
                <div class="text-muted text-tiny mt-1">
                    <small class="font-weight-normal text-uppercase">
                        <a href="#" class="mr-1">INVENTORY MANAGEMENT</a>/
                                  INBOUND REQUEST FROM 
                    </small>
                </div>
            </h4>

            <!-- Statistics -->
            <div class="card mb-3">

                <asp:Label ID="lblBranchID" runat="server" Text="" Visible="false"></asp:Label>
                <asp:Label ID="lblCreateByID" runat="server" Text="" Visible="false"></asp:Label>

                <h4 class="card-header with-elements">
                    <div class="card-header-title"><strong>Inbound Request Form</strong></div>
                </h4>
                <div class="row no-gutters row-bordered">
                    <div class="col-md-12 col-lg-12 col-xl-12">
                        <div class="modal-header">
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-lg-6 col-xl-6">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Branch</label>
                                        <%--<input type="text" class="form-control form-control-sm" placeholder="Branch" value="V001">--%>
                                        <asp:TextBox ID="txtBranch" placeholder="Branch" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-6 col-xl-6">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Approver</label>
                                        <%--<input type="text" class="form-control form-control-sm" placeholder="Approver" value="Pisan Ungchumchoke">--%>
                                        <asp:TextBox ID="txtCreateBy" placeholder="Approver" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12 col-xl-12">
                                    <div class="card-datatable table-responsive">
                                        <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <table class="table table-striped table-hover table-bordered">
                                                    <thead class="thead-dark">
                                                        <tr>
                                                            <th>Type</th>
                                                            <th>CAT</th>
                                                            <th>SKU</th>
                                                            <th>Serial</th>
                                                            <th>Name</th>
                                                            <th>QTY</th>
                                                            <th>Tools</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr class="odd gradeX">
                                                            <td>
                                                                <div class="form-group mb-0">
                                                                    <asp:DropDownList ID="ddlType" AutoPostBack="true"  runat="server" CssClass="" class="form-control form-control-sm" OnSelectedIndexChanged="ddlType_SelectedIndexChanged">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <div class="form-group mb-0">
                                                                    <asp:DropDownList ID="ddlCategory" runat="server" CssClass="" class="form-control form-control-sm">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <div class="form-group mb-0">
                                                                    <%--<input type="text" class="form-control form-control-sm" placeholder="SKU">--%>
                                                                    <asp:TextBox ID="txtSku" placeholder="SKU" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <div class="form-group mb-0">
                                                                    <%--<input type="text" class="form-control form-control-sm" placeholder="Serial">--%>
                                                                    <asp:TextBox ID="txtSerial" placeholder="Serial" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <div class="form-group mb-0">
                                                                    <%--<input type="text" class="form-control form-control-sm" placeholder="Name">--%>
                                                                    <asp:TextBox ID="txtName" placeholder="Name" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <div class="form-group mb-0">
                                                                    <%--<input type="text" class="form-control form-control-sm" placeholder="Number">--%>
                                                                    <asp:TextBox ID="txtQty" placeholder="QTY" runat="server" TextMode="Number" CssClass="form-control form-control-sm"></asp:TextBox>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <%--<a href="#" class="btn btn-success btn-sm">+ Add</a>--%>
                                                                <asp:LinkButton ID="lbnAdd" runat="server" CssClass="btn btn-success btn-sm" OnClick="lbnAdd_Click">+ Add</asp:LinkButton>
                                                            </td>
                                                        </tr>
                                                        <%--        <tr>
                                                            <td>
                                                                <asp:RangeValidator ErrorMessage="Please enter value between 1-99." ForeColor="Red" ControlToValidate="txtQty" MinimumValue="1" MaximumValue="99" runat="server" Type="Integer">
                                                                </asp:RangeValidator>
                                                            </td>
                                                        </tr>--%>

                                                        <asp:Repeater ID="resultList" runat="server" OnItemDataBound="rptList_ItemDataBound" OnItemCommand="rptList_ItemCommand">
                                                            <%-- OnItemCommand="rptInquiryList_ItemCommand" OnItemDataBound="rptInquiryList_ItemDataBound"--%>
                                                            <ItemTemplate>
                                                                <tr runat="server" class="odd gradeX">
                                                                    <td id="td5" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblType" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td6" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblCategory" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td1" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblSku" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td2" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblSerial" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td3" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblName" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td4" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblQty" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td class="center">
                                                                        <div class="btn-group btn-group-sm">
                                                                            <asp:LinkButton ID="lbnRemove" runat="server" CssClass="btn btn-danger btn-sm"><i class="ion ion-md-close"></i></asp:LinkButton>
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
                                </div>
                            </div>
                        </div>
                        <hr class="m-0">

                        <div class="modal-footer">
                            <a href="inventory.aspx" class="btn btn-lg btn-default">Cancel</a>
                            <%--<a href="#" class="btn btn-lg btn-success">Save</a>--%>
                            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-lg btn-primary" Text="Confirm" OnClick="btnSave_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <!-- / Statistics -->
        </div>

        <!-- / Content -->

        <!-- Layout footer -->

        <!-- / Layout footer -->
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
