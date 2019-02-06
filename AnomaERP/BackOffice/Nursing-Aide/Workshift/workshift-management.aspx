<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="workshift-management.aspx.cs" Inherits="AnomaERP.BackOffice.Workshift.workshift_management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Nursing Aide
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Aide</a>/
                                    Workshift Management
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
                                                    <label class="form-label form-label-sm text-uppercase">Branch</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Branch">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Position</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Position">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Level</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Level">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Date</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Date" id="datepicker-base">
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
                                                                        <th>Employee Name</th>
                                                                        <th>Position</th>
                                                                        <th>Default Routine</th>
                                                                        <th>2nd Routine</th>
                                                                        <th>3rd Routine</th>
                                                                        <th>Status</th>
                                                                        <th>Tools</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    <tr class="odd gradeX">
                                                                        <td>Pisan Ungchumchoke</td>
                                                                        <td>Nurse</td>
                                                                        <td>10:00 - 18:00</td>
                                                                        <td>20:00 - 23:00</td>
                                                                        <td>-</td>
                                                                        <td class="center">Default Schedule</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="customer-daily.html" class="btn btn-primary">
                                                                                    <i class="ion ion-md-search"></i></a>
                                                                                <a href="#" class="btn btn-secondary"
                                                                                    data-toggle="modal" data-target="#modals-workshift">
                                                                                    <i class="ion ion-md-create"></i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>Pisan Ungchumchoke</td>
                                                                        <td>Nurse</td>
                                                                        <td>10:00 - 18:00</td>
                                                                        <td>20:00 - 23:00</td>
                                                                        <td>-</td>
                                                                        <td class="center">Reschedule - Waiting Confirm</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="customer-daily.html" class="btn btn-primary">
                                                                                    <i class="ion ion-md-search"></i></a>
                                                                                <a href="#" class="btn btn-secondary"
                                                                                    data-toggle="modal" data-target="#modals-workshift">
                                                                                    <i class="ion ion-md-create"></i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>Pisan Ungchumchoke</td>
                                                                        <td>Nurse</td>
                                                                        <td>10:00 - 18:00</td>
                                                                        <td>20:00 - 23:00</td>
                                                                        <td>-</td>
                                                                        <td class="center">Reschedule - Confirm</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="customer-daily.html" class="btn btn-primary">
                                                                                    <i class="ion ion-md-search"></i></a>
                                                                                <a href="#" class="btn btn-secondary"
                                                                                    data-toggle="modal" data-target="#modals-workshift">
                                                                                    <i class="ion ion-md-create"></i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>Pisan Ungchumchoke</td>
                                                                        <td>Nurse</td>
                                                                        <td>10:00 - 18:00</td>
                                                                        <td>20:00 - 23:00</td>
                                                                        <td>-</td>
                                                                        <td class="center">Reschedule Reject</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="customer-daily.html" class="btn btn-primary">
                                                                                    <i class="ion ion-md-search"></i></a>
                                                                                <a href="#" class="btn btn-secondary"
                                                                                    data-toggle="modal" data-target="#modals-workshift">
                                                                                    <i class="ion ion-md-create"></i>
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
</asp:Content>
