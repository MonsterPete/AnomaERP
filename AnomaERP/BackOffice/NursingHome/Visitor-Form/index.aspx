<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AnomaERP.BackOffice.NursingHome.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Visitor Form
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Home</a>/
                                    Visitor Form
                                </small>
                            </div>
            </h4>

            <div class="row">
                <div class="col-lg-12">
                    <a href="visitor-form.aspx" class="btn btn-success mb-3 mr-2">+ Create Visitor Form</a>
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
                                        <label class="form-label form-label-sm text-uppercase">Customer Name</label>
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
                                                            <th class="tbw-7">Appointment Date</th>
                                                            <th class="tbw-7">Visitor Date</th>
                                                            <th>Visitor Name</th>
                                                            <th>Phone Number</th>
                                                            <th class="tbw-9">Reserve Status</th>
                                                            <th class="tbw-9">Tools</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr class="odd gradeX">
                                                            <td>0000001</td>
                                                            <td>12/01/2019</td>
                                                            <td>12/01/2019</td>
                                                            <td>Steve Job</td>
                                                            <td>089-584845215</td>
                                                            <td class="center">Reserved</td>
                                                            <td class="center">
                                                                <div class="btn-group btn-group-sm">
                                                                    <a href="visitor-form.html" class="btn btn-primary">
                                                                        <i class="ion ion-md-create"></i></a>
                                                                    <a href="#" class="btn btn-danger" data-toggle="modal"
                                                                        data-target="#modals-default">
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
