<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="job-assign.aspx.cs" Inherits="AnomaERP.BackOffice.Bed_Management.Job.job_assign" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Job Assignment
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Job Assignment</a>/
                                    Job Assignment Info
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
                                                    <label class="form-label form-label-sm text-uppercase">Name</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Name" value="Pisan Ungchumchoke" disabled>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Branch</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Branch" value="Suanluang (NH001)" disabled>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Room</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Room" value="VIP" disabled>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Bed</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Room" value="V001" disabled>
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
                                                                        <th>Schedule</th>
                                                                        <th>Remark</th>
                                                                        <th>Tools</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    <tr class="odd gradeX">
                                                                        <td>12 January 2019</td>
                                                                        <td>
                                                                            8:00 - 9:00 : อาบน้ำ <br>
                                                                            12:00 - 12:30 : ให้อาหารอ่อนพิเศษ <br>
                                                                            15:30 : วัดความดัน <br>
                                                                            15:45 : ให้ยา <br>
                                                                        </td>
                                                                        <td>-</td>
                                                                        <td>
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="#" class="btn btn-primary" data-toggle="modal"
                                                                                    data-target="#modals-edit">
                                                                                    <i class="ion ion-md-create"></i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>13 January 2019</td>
                                                                        <td>
                                                                            8:00 - 9:00 : อาบน้ำ <br>
                                                                            12:00 - 12:30 : ให้อาหารอ่อนพิเศษ <br>
                                                                            15:30 : วัดความดัน <br>
                                                                            15:45 : ให้ยา <br>
                                                                        </td>
                                                                        <td>-</td>
                                                                        <td>
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="#" class="btn btn-primary" data-toggle="modal"
                                                                                    data-target="#modals-edit">
                                                                                    <i class="ion ion-md-create"></i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>14 January 2019</td>
                                                                        <td>
                                                                            8:00 - 9:00 : อาบน้ำ <br>
                                                                            12:00 - 12:30 : ให้อาหารอ่อนพิเศษ <br>
                                                                            15:30 : วัดความดัน <br>
                                                                            15:45 : ให้ยา <br>
                                                                        </td>
                                                                        <td>-</td>
                                                                        <td>
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="#" class="btn btn-primary" data-toggle="modal"
                                                                                    data-target="#modals-edit">
                                                                                    <i class="ion ion-md-create"></i>
                                                                                </a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>15 January 2019</td>
                                                                        <td>
                                                                            8:00 - 9:00 : อาบน้ำ <br>
                                                                            12:00 - 12:30 : ให้อาหารอ่อนพิเศษ <br>
                                                                            15:30 : วัดความดัน <br>
                                                                            15:45 : ให้ยา <br>
                                                                        </td>
                                                                        <td>-</td>
                                                                        <td>
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="#" class="btn btn-primary" data-toggle="modal"
                                                                                    data-target="#modals-edit">
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
    <div class="modal fade" id="modals-edit">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">
                        Schedule on 12 January 2019
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Time Schedule</label>
                                <select name="" class="form-control form-control-sm">
                                    <option value="">-- Select Role --</option>
                                </select>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <table class="datatables-demo table table-striped table-hover table-bordered">
                                <thead class="thead-dark">
                                    <tr>
                                        <th>Time</th>
                                        <th>Job</th>
                                        <th class="tbw-7">Tools</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr class="odd gradeX">
                                        <td>8:00 - 9:00</td>
                                        <td>
                                            <div class="form-group mb-0">
                                                <select name="" class="form-control form-control-sm">
                                                    <option value=""> Select Task </option>
                                                </select>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="btn-group btn-group-sm">
                                                <a href="#" class="btn btn-danger"><i class="ion ion-md-close"></i></a>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr class="odd gradeX">
                                        <td>9:00 - 10:00</td>
                                        <td>
                                            <div class="form-group mb-0">
                                                <select name="" class="form-control form-control-sm">
                                                    <option value=""> Select Task </option>
                                                </select>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="btn-group btn-group-sm">
                                                <a href="#" class="btn btn-danger"><i class="ion ion-md-close"></i></a>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr class="odd gradeX">
                                        <td>11:00 - 12:00</td>
                                        <td>
                                            <div class="form-group mb-0">
                                                <select name="" class="form-control form-control-sm">
                                                    <option value=""> Select Task </option>
                                                </select>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="btn-group btn-group-sm">
                                                <a href="#" class="btn btn-danger"><i class="ion ion-md-close"></i></a>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr class="odd gradeX">
                                        <td>13:00 - 14:00</td>
                                        <td>
                                            <div class="form-group mb-0">
                                                <select name="" class="form-control form-control-sm">
                                                    <option value=""> Select Task </option>
                                                </select>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="btn-group btn-group-sm">
                                                <a href="#" class="btn btn-danger"><i class="ion ion-md-close"></i></a>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr class="odd gradeX">
                                        <td><input type="text" class="form-control form-control-sm"></td>
                                        <td>
                                            <div class="form-group mb-0">
                                                <select name="" class="form-control form-control-sm">
                                                    <option value=""> Select Task </option>
                                                </select>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="btn-group btn-group-sm">
                                                <a href="#" class="btn btn-success">+ Add Task</a>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group mt-3 mb-0">
                                <label for="" class="form-label form-label-sm text-uppercase">Remark</label>
                                <textarea name="" cols="30" rows="2" class="form-control"></textarea>
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
    </div>
</asp:Content>
