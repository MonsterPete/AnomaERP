<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="logistic-list.aspx.cs" Inherits="AnomaERP.BackOffice.NursingHome.logistic_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Moving & Logistic
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Home</a>/
                                    Moving & Logistic
                                </small>
                            </div>
                        </h4>

                        <div class="row">
                            <div class="col-lg-12">
                                <a href="logistic-reserve-form.aspx" class="btn btn-success mb-3 mr-2">+ Create
                                    Logistic Reserve</a>
                            </div>
                        </div>

                        <!-- Statistics -->
                        <div class="card mb-3">
                            <div class="row no-gutters row-bordered">
                                <div class="col-md-12 col-lg-12 col-xl-12">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Customer
                                                        Name</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="ค้นหา">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Source Name</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="ค้นหา">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Destination
                                                        Name</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="ค้นหา">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Status</label>
                                                    <select class="form-control form-control-sm">
                                                        <option>Reserved</option>
                                                        <option>No Reserved</option>
                                                    </select>
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
                                                            <table class="datatables-demo table table-striped table-hover table-bordered">
                                                                <thead class="thead-dark">
                                                                    <tr>
                                                                        <th class="tbw-5">#</th>
                                                                        <th>Customer Name</th>
                                                                        <th class="tbw-15">Source Name</th>
                                                                        <th class="tbw-15">Destination Name</th>
                                                                        <th class="tbw-9">Time</th>
                                                                        <th class="tbw-9">Phone</th>
                                                                        <th>Remark</th>
                                                                        <th class="tbw-9">Tools</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    <tr class="odd gradeX">
                                                                        <td>0000001</td>
                                                                        <td>Steve Job</td>
                                                                        <td>Source Name</td>
                                                                        <td>Destination Name</td>
                                                                        <td>16.45</td>
                                                                        <td class="center">0811334567</td>
                                                                        <td class="left">Remark</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="logistic-reserve-form.html" class="btn btn-primary">
                                                                                    <i class="ion ion-md-create"></i></a>
                                                                                <a href="#" class="btn btn-danger"
                                                                                    data-toggle="modal" data-target="#modals-default">
                                                                                    <i class="ion ion-md-close"></i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>0000002</td>
                                                                        <td>Steve Job</td>
                                                                        <td>Source Name</td>
                                                                        <td>Destination Name</td>
                                                                        <td>16.45</td>
                                                                        <td class="center">0811334567</td>
                                                                        <td class="left">Remark</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="logistic-reserve-form.html" class="btn btn-primary">
                                                                                    <i class="ion ion-md-create"></i></a>
                                                                                <a href="#" class="btn btn-danger"
                                                                                    data-toggle="modal" data-target="#modals-default">
                                                                                    <i class="ion ion-md-close"></i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>0000003</td>
                                                                        <td>Steve Job</td>
                                                                        <td>Source Name</td>
                                                                        <td>Destination Name</td>
                                                                        <td>16.45</td>
                                                                        <td class="center">0811334567</td>
                                                                        <td class="left">Remark</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="logistic-reserve-form.html" class="btn btn-primary">
                                                                                    <i class="ion ion-md-create"></i></a>
                                                                                <a href="#" class="btn btn-danger"
                                                                                    data-toggle="modal" data-target="#modals-default">
                                                                                    <i class="ion ion-md-close"></i>
                                                                                </a>
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
                    <!-- / Content -->

                    <!-- Layout footer -->
                    
                    <!-- / Layout footer -->

                </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
