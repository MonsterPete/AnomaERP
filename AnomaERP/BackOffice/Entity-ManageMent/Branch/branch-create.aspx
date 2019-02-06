<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="branch-create.aspx.cs" Inherits="AnomaERP.BackOffice.Branch.branch_create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Entity Management
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Entity List</a>/
                                    Branch Setup
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
                                <div class="card-header-title"><strong>Branch Setup</strong></div>
                            </h4>
                            <div class="row no-gutters row-bordered">
                                <div class="col-md-12 col-lg-12 col-xl-12">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-6 col-xl-6">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Branch Name:
                                                    </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Branch Name">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-6 col-xl-6">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Address:
                                                    </label>
                                                    <textarea class="form-control form-control-sm" rows="3" placeholder="Address"></textarea>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-6 col-xl-6">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Register
                                                        Address: </label>
                                                    <textarea class="form-control form-control-sm" rows="3" placeholder="Register Address"></textarea>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Tax ID:
                                                    </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Tax ID">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Prefix (3
                                                        Character): </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Prefix">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Building
                                                        Type:</label>
                                                    <select class="form-control form-control-sm">
                                                        <option>Not Spectify</option>
                                                        <option>Stand Alone House</option>
                                                        <option>Building</option>
                                                        <option>Apartment</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Useage
                                                        Area(sqm.): </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Area">
                                                </div>
                                            </div>
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Rental
                                                        Price: </label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="Price">
                                                </div>
                                            </div>
                                        </div>
                                        <hr class="mb-0">
                                        <div class="row">
                                            <div class="col-lg-12 col-xl-12">
                                                <h5 class="mt-4"><strong>Floor Setup</strong></h5>
                                            </div>
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Number of
                                                        Floor:</label>
                                                    <select class="form-control form-control-sm">
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="col-lg-10 col-xl-10">
                                                <div id="accordion2">
                                                    <div class="card mb-2">
                                                        <div class="card-header">
                                                            <a class="d-flex justify-content-between text-dark"
                                                                data-toggle="collapse" aria-expanded="true" href="#accordion2-1">
                                                                Floor 1
                                                                <div class="collapse-icon"></div>
                                                            </a>
                                                        </div>

                                                        <div id="accordion2-1" class="collapse show" data-parent="#accordion2">
                                                            <div class="card-body">
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Number
                                                                                of Room:</label>
                                                                            <select class="form-control form-control-sm">
                                                                                <option>4</option>
                                                                            </select>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class="card mb-2">
                                                        <div class="card-header">
                                                            <a class="collapsed d-flex justify-content-between text-dark"
                                                                data-toggle="collapse" href="#accordion2-2">
                                                                Floor 2
                                                                <div class="collapse-icon"></div>
                                                            </a>
                                                        </div>
                                                        <div id="accordion2-2" class="collapse" data-parent="#accordion2">
                                                            <div class="card-body">
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Number
                                                                                of Room:</label>
                                                                            <select class="form-control form-control-sm">
                                                                                <option>4</option>
                                                                            </select>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class="card mb-2">
                                                        <div class="card-header">
                                                            <a class="collapsed d-flex justify-content-between text-dark"
                                                                data-toggle="collapse" href="#accordion2-3">
                                                                Floor 3
                                                                <div class="collapse-icon"></div>
                                                            </a>
                                                        </div>
                                                        <div id="accordion2-3" class="collapse" data-parent="#accordion2">
                                                            <div class="card-body">
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Number
                                                                                of Room:</label>
                                                                            <select class="form-control form-control-sm">
                                                                                <option>4</option>
                                                                            </select>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class="card mb-2">
                                                        <div class="card-header">
                                                            <a class="collapsed d-flex justify-content-between text-dark"
                                                                data-toggle="collapse" href="#accordion2-4">
                                                                Floor 4
                                                                <div class="collapse-icon"></div>
                                                            </a>
                                                        </div>
                                                        <div id="accordion2-4" class="collapse" data-parent="#accordion2">
                                                            <div class="card-body">
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Number
                                                                                of Room:</label>
                                                                            <select class="form-control form-control-sm">
                                                                                <option>4</option>
                                                                            </select>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class="card mb-2">
                                                        <div class="card-header">
                                                            <a class="collapsed d-flex justify-content-between text-dark"
                                                                data-toggle="collapse" href="#accordion2-5">
                                                                Floor 5
                                                                <div class="collapse-icon"></div>
                                                            </a>
                                                        </div>
                                                        <div id="accordion2-5" class="collapse" data-parent="#accordion2">
                                                            <div class="card-body">
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Number
                                                                                of Room:</label>
                                                                            <select class="form-control form-control-sm">
                                                                                <option>4</option>
                                                                            </select>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <hr>
                                                                <div class="row">
                                                                    <div class="col-lg-2 col-xl-2">
                                                                        <div class="form-group">
                                                                            <label class="form-label form-label-sm text-uppercase">Room
                                                                                Name: </label>
                                                                            <input type="text" class="form-control form-control-sm"
                                                                                placeholder="Room Name">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10 col-xl-10">
                                                                        <div class="row">
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Number
                                                                                        of Bed:</label>
                                                                                    <select class="form-control form-control-sm">
                                                                                        <option>20</option>
                                                                                    </select>
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="A">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="B">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                            <div class="col-lg-3 col-xl-3">
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Type: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="C">
                                                                                </div>
                                                                                <div class="form-group">
                                                                                    <label class="form-label form-label-sm text-uppercase">Bed
                                                                                        Number: </label>
                                                                                    <input type="text" class="form-control form-control-sm"
                                                                                        placeholder="Bed Number">
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <hr class="mb-0">
                                        <div class="row">
                                            <div class="col-lg-12 col-xl-12">
                                                <h5 class="mt-4"><strong>Branch Manager</strong></h5>
                                            </div>
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

                  

                </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
