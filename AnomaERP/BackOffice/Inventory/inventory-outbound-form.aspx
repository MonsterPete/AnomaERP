﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="inventory-outbound-form.aspx.cs" Inherits="AnomaERP.BackOffice.Inventory.inventory_outbound_form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Inventory Management
                <div class="text-muted text-tiny mt-1">
                    <small class="font-weight-normal text-uppercase">
                        <a href="#" class="mr-1">INVENTORY MANAGEMENT</a>/
                                  OUTBOUND REQUEST FROM 
                    </small>
                </div>
            </h4>

            <!-- Statistics -->
            <div class="card mb-3">

                <asp:Label ID="lblBranchID" runat="server" Text="" Visible="false"></asp:Label>

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
                                <a href="javascript:history.go(-1)" class="btn btn-lg btn-default">Cancel</a>
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
