<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="role-assign-create.aspx.cs" Inherits="AnomaERP.BackOffice.Role.role_assign_create" %>
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
                        <!-- 
                        <div class="row">
                            <div class="col-lg-12">
                                <a href="visitor-form.html" class="btn btn-success mb-3 mr-2">+ Create Visitor Form</a>
                            </div>
                        </div> -->

                        <!-- Statistics -->
                        <div class="card mb-3">
                            <h4 class="card-header with-elements">
                                <div class="card-header-title"><strong>Employee Setup</strong></div>
                            </h4>
                            <div class="row no-gutters row-bordered">
                                <div class="col-md-12 col-lg-12 col-xl-12">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Username:
                                                    </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Username">
                                                </div>
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Password:
                                                    </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Password">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Email:</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Email">
                                                </div>
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Phone:</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Phone">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Firstname:
                                                    </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Firstname">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Lastname:
                                                    </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Lastname">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Nickname:</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Nickname">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Gender</label>
                                                    <select class="form-control form-control-sm">
                                                        <option>Male</option>
                                                        <option>Female</option>
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Date of Birth
                                                    </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Date of Birth">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Citizen ID: </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Citizen ID">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Job Role</label>
                                                    <select class="form-control form-control-sm">
                                                        <option>Select Role</option>
                                                        <option>Manger</option>
                                                        <option>Sale</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Working Time</label>
                                                    <select class="form-control form-control-sm">
                                                        <option>Select Work Time</option>
                                                        <option>Full Time (Normal)</option>       
                                                        <option>Shift</option>                                                 
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-12 col-xl-12">
                                                <h5 class="mt-4"><strong>Shift Time</strong></h5>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Start Time</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Start">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">End Time</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="End">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Start Time</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Start">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">End Time</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="End">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Start Time</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Start">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">End Time</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="End">
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                    <div class="card-footer">
                                        <a href="#" class="btn btn-lg btn-secondary">Back</a>
                                        <a href="#" class="btn btn-lg btn-success">Save</a>
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
