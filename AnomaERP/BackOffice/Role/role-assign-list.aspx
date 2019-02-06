<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="role-assign-list.aspx.cs" Inherits="AnomaERP.BackOffice.Role.role_assign_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Resource Planning
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Resource Planning</a>/
                                    Role Assignment
                                </small>
                            </div>
                        </h4>

                        <div class="row">
                            <div class="col-lg-12">
                                <a href="role-assign-create.html" class="btn btn-success mb-3 mr-2">+ Create Assignment</a>
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
                                                    <label class="form-label form-label-sm text-uppercase">Entity Name</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Entity Name">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Select Branch</label>
                                                    <select class="form-control form-control-sm">
                                                        <option>Branch 1</option>
                                                        <option>Branch 2</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Total Manpower</label>
                                                    <select class="form-control form-control-sm">
                                                        <option>1</option>
                                                        <option>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                        <option>6</option>
                                                        <option>7</option>
                                                        <option>8</option>
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-12 col-xl-12">
                                                <div class="table-responsive">
                                                    <table class="table table-bordered">
                                                        <thead class="thead-dark">
                                                            <tr>
                                                                <th class="tbw-9">ID</th>
                                                                <th>Position Name</th>
                                                                <th>Name</th>
                                                                <th>Assignment Status</th>
                                                                <th>Cost Center</th>
                                                                <th>Status</th>
                                                                <th>Tools</th>                                                                
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr>
                                                                <td>000001</td>
                                                                <td>Manager</td>
                                                                <td>Pisan Ungchumchoke</td>
                                                                <td>On Board</td>
                                                                <td>316</td>
                                                                <td class="center">
                                                                    <label class="switcher switcher-sm">
                                                                        <input type="checkbox" class="switcher-input" checked>
                                                                        <span class="switcher-indicator">
                                                                            <span class="switcher-yes">
                                                                                <span class="ion ion-md-checkmark"></span>
                                                                            </span>
                                                                            <span class="switcher-no">
                                                                                <span class="ion ion-md-close"></span>
                                                                            </span>
                                                                        </span>
                                                                    </label>
                                                                </td>
                                                                <td>
                                                                    <div class="btn-group btn-group-sm">
                                                                        <a href="role-assign-create.html" class="btn btn-primary">
                                                                            <i class="ion ion-md-create"></i>
                                                                        </a>
                                                                        <a href="#" class="btn btn-danger" data-toggle="modal"
                                                                            data-target="#modals-default">
                                                                            <i class="ion ion-md-close"></i>
                                                                        </a>
                                                                    </div>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>000002</td>
                                                                <td>Sale</td>
                                                                <td>Worapot Pattanasoon</td>
                                                                <td>On Board</td>
                                                                <td>316</td>
                                                                <td class="center">
                                                                    <label class="switcher switcher-sm">
                                                                        <input type="checkbox" class="switcher-input" checked>
                                                                        <span class="switcher-indicator">
                                                                            <span class="switcher-yes">
                                                                                <span class="ion ion-md-checkmark"></span>
                                                                            </span>
                                                                            <span class="switcher-no">
                                                                                <span class="ion ion-md-close"></span>
                                                                            </span>
                                                                        </span>
                                                                    </label>
                                                                </td>
                                                                <td>
                                                                    <div class="btn-group btn-group-sm">
                                                                        <a href="role-assign-create.html" class="btn btn-primary">
                                                                            <i class="ion ion-md-create"></i>
                                                                        </a>
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
                                    <div class="card-footer">
                                        
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- / Statistics -->

                    </div>
                    <!-- / Content -->

                   

                </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
