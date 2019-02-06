<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="accessory.aspx.cs" Inherits="AnomaERP.BackOffice.Bed_Management.Accessory.accessory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Bed Management
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Bed Management</a>/
                                    Accesscories Lists
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
                                                    <label class="form-label form-label-sm text-uppercase">Floor</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Floor">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Customer
                                                        Name</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Customer Name">
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
                                                            <table class="datatables-demo table table-striped table-hover table-bordered">
                                                                <thead class="thead-dark">
                                                                    <tr>
                                                                        <th>Branch</th>
                                                                        <th>Floor</th>
                                                                        <th>Room</th>
                                                                        <th>Bed</th>
                                                                        <th>Customer</th>
                                                                        <th>Status</th>
                                                                        <th>Equipment</th>
                                                                        <th>Tools</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    <tr class="odd gradeX">
                                                                        <td>NH001</td>
                                                                        <td>1</td>
                                                                        <td>VIP</td>
                                                                        <td>V001</td>
                                                                        <td><a href="#" class="btn btn-primary btn-sm"
                                                                                data-toggle="modal" data-target="#modals-assign">Assign</i>
                                                                            </a></td>
                                                                        <td class="center">Available</td>
                                                                        <td>ถังออกซิเจน (SKU)</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="" class="btn btn-primary"
                                                                                    data-toggle="modal" data-target="#modals-equip-edit">
                                                                                    <i class="ion ion-md-create"></i></a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>NH002</td>
                                                                        <td>1</td>
                                                                        <td>VIP</td>
                                                                        <td>V001</td>
                                                                        <td><a href="#" class="btn btn-primary btn-sm"
                                                                                data-toggle="modal" data-target="#modals-assign">Assign</i>
                                                                            </a></td>
                                                                        <td class="center">Available</td>
                                                                        <td>ถังออกซิเจน (SKU)</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="" class="btn btn-primary"
                                                                                    data-toggle="modal" data-target="#modals-equip-edit">
                                                                                    <i class="ion ion-md-create"></i></a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>NH003</td>
                                                                        <td>1</td>
                                                                        <td>VIP</td>
                                                                        <td>V001</td>
                                                                        <td><a href="#" class="btn btn-primary btn-sm"
                                                                                data-toggle="modal" data-target="#modals-assign">Assign</i>
                                                                            </a></td>
                                                                        <td class="center">Available</td>
                                                                        <td>ถังออกซิเจน (SKU)</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="" class="btn btn-primary"
                                                                                    data-toggle="modal" data-target="#modals-equip-edit">
                                                                                    <i class="ion ion-md-create"></i></a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>NH004</td>
                                                                        <td>1</td>
                                                                        <td>VIP</td>
                                                                        <td>V001</td>
                                                                        <td><a href="#" class="btn btn-primary btn-sm"
                                                                                data-toggle="modal" data-target="#modals-assign">Assign</i>
                                                                            </a></td>
                                                                        <td class="center">Available</td>
                                                                        <td>ถังออกซิเจน (SKU)</td>
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="" class="btn btn-primary"
                                                                                    data-toggle="modal" data-target="#modals-equip-edit">
                                                                                    <i class="ion ion-md-create"></i></a>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
    <div class="modal fade" id="modals-assign">
        <div class="modal-dialog">
            <form class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">
                        Assgin management
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
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Assgin To</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Assgin To" value="Customer Name">
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <h5 class="mt-0"><strong>Contract Date</strong></h5>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Start Contract</label>
                                <input type="text" class="form-control form-control-sm" placeholder="Start Time" id="datepicker-base">
                            </div>
                        </div>
                        <div class="col-lg-6 col-xl-6">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">End Contract</label>
                                <input type="text" class="form-control form-control-sm" placeholder="End Time" id="datepicker-base-2">
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group">
                                <label class="form-label form-label-sm text-uppercase">Status</label>
                                <select name="" class="form-control form-control-sm">
                                    <option value="">Vacant (Default)</option>
                                    <option value="">Waiting</option>
                                    <option value="">Active</option>
                                </select>
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

    <div class="modal fade" id="modals-equip-edit">
        <div class="modal-dialog">
            <form class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">
                        Equipment
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <div class="card-datatable table-responsive">
                                <table class="datatables-demo table table-striped table-hover table-bordered">
                                    <thead class="thead-dark">
                                        <tr>
                                            <th>Job</th>
                                            <th>Tools</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class="odd gradeX">
                                            <td>
                                                <div class="form-group mb-0">
                                                    <select name="" class="form-control form-control-sm">
                                                        <option value="">Select Item</option>
                                                    </select>
                                                </div>
                                            </td>
                                            <td class="center">
                                                <div class="btn-group btn-group-sm">
                                                    <a href="" class="btn btn-danger"><i class="ion ion-md-close"></i></a>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr class="odd gradeX">
                                            <td>
                                                <div class="form-group mb-0">
                                                    <input type="text" class="form-control form-control-sm" placeholder="Search">
                                                </div>
                                            </td>
                                            <td class="center">
                                                <div class="btn-group btn-group-sm">
                                                    <a href="" class="btn btn-success">+ Add</a>
                                                </div>
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
                    <a href="#" class="btn btn-default" data-dismiss="modal">Clear</a>
                    <a href="#" class="btn btn-success">Comfirm</a>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
