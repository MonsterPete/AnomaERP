<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="role-list.aspx.cs" Inherits="AnomaERP.BackOffice.Role.role_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Resource Planning
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Resource Planning</a>/
                                    Role List
                                </small>
                            </div>
                        </h4>

                        <!-- <div class="row">
                            <div class="col-lg-12">
                                <a href="branch-create.html" class="btn btn-success mb-3 mr-2">+ Create Branch</a>
                            </div>
                        </div> -->

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
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-12 col-xl-12">
                                                <div class="table-responsive">
                                                    <table class="table table-bordered">
                                                        <thead class="thead-dark">
                                                            <tr>
                                                                <th class="tbw-9">ID</th>
                                                                <th>Position Name</th>
                                                                <th>Group</th>
                                                                <th>Level</th>
                                                                <th>Status</th>
                                                                <th>Tools</th>                                                                
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr>
                                                                <td>000001</td>
                                                                <td>Nurse</td>
                                                                <td>Care</td>
                                                                <td>2</td>
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
                                                                        <a href="inquiry-info.html" class="btn btn-primary">
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
                                                                <td>
                                                                    <input type="text" class="form-control form-control-sm" placeholder="Position Name">
                                                                </td>
                                                                <td>
                                                                    <input type="text" class="form-control form-control-sm" placeholder="Group Name">
                                                                </td>
                                                                <td>
                                                                    <input type="text" class="form-control form-control-sm" placeholder="Level">
                                                                </td>
                                                                <td>&nbsp;</td>
                                                                <td><a href="#" class="btn btn-success btn-sm">Create</a></td>
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
