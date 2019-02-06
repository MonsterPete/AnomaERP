<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="customer-daily.aspx.cs" Inherits="AnomaERP.BackOffice.Customer_Daily.customer_daily" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Nursing Aide
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Aide</a>/
                                    <a href="#" class="mr-1">Workshift Management</a>/
                                    Employee Info
                                </small>
                            </div>
                        </h4>

                        <!-- Statistics -->
                        <div class="card mb-3">
                            <div class="row no-gutters row-bordered">
                                <div class="col-md-12 col-lg-12 col-xl-12">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Employee</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Employee" value="Pisan Ungchumchoke" disabled>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Branch</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Employee" value="Suanluang" disabled>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Nurse</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Employee" value="Nurse" disabled>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Status</label>
                                                    <select name="" class="form-control form-control-sm">
                                                        <option value="All">-- All --</option>
                                                        <option value="All">Reschedule - Waiting Confirm</option>
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
                                                                        <th>Date</th>
                                                                        <th>Default Routine</th>
                                                                        <th>2nd Routine</th>
                                                                        <th>3rd Routine</th>
                                                                        <th>Status</th>
                                                                        <th>Tools</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    <tr class="odd gradeX">
                                                                        <td>11-01-2019</td>
                                                                        <td>10:00 - 18:00</td>
                                                                        <td>20:00 - 23:00</td>
                                                                        <td>-</td>
                                                                        <td class="center">Default Schedule</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="#" class="btn btn-success">Confirm</a>
                                                                                <a href="#" class="btn btn-danger">Reject</i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>11-01-2019</td>
                                                                        <td>10:00 - 18:00</td>
                                                                        <td>20:00 - 23:00</td>
                                                                        <td>-</td>
                                                                        <td class="center">Default Schedule</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="#" class="btn btn-success">Confirm</a>
                                                                                <a href="#" class="btn btn-danger">Reject</i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>11-01-2019</td>
                                                                        <td>10:00 - 18:00</td>
                                                                        <td>20:00 - 23:00</td>
                                                                        <td>-</td>
                                                                        <td class="center">Default Schedule</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="#" class="btn btn-success">Confirm</a>
                                                                                <a href="#" class="btn btn-danger">Reject</i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>11-01-2019</td>
                                                                        <td>10:00 - 18:00</td>
                                                                        <td>20:00 - 23:00</td>
                                                                        <td>-</td>
                                                                        <td class="center">Default Schedule</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="#" class="btn btn-success">Confirm</a>
                                                                                <a href="#" class="btn btn-danger">Reject</i>
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

                   

                </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
    <div class="modal fade" id="modals-workshift">
        <div class="modal-dialog">
            <form class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">
                        Edit Work Shift
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <h5 class="mt-0"><strong>Default Shift Time</strong></h5>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Start Time</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Start">
                            </div>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">End Time</label>
                                <input type="text" class="form-control form-control-sm" placeholder="End">
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <h5 class="mt-0"><strong>2nd Shift Time</strong></h5>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Start Time</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Start">
                            </div>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">End Time</label>
                                <input type="text" class="form-control form-control-sm" placeholder="End">
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <h5 class="mt-0"><strong>3rd Shift Time</strong></h5>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Start Time</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Start">
                            </div>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">End Time</label>
                                <input type="text" class="form-control form-control-sm" placeholder="End">
                            </div>
                        </div>
                    </div>
                </div>
                <hr class="m-0">
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" data-dismiss="modal">Clear</a>
                    <a href="#" class="btn btn-success">Comfirm</a>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
