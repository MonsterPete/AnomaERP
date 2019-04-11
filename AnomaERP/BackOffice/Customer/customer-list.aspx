<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="customer-list.aspx.cs" Inherits="AnomaERP.BackOffice.Customer.customer_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="container-fluid flex-grow-1 container-p-y">

        <h4 class="font-weight-bold py-3 mb-2">Customer Management
                           
            <div class="text-muted text-tiny mt-1">
                <small class="font-weight-normal text-uppercase">
                    <a href="#" class="mr-1">Customer Management</a>/
                                    Customer List
                                </small>
            </div>
        </h4>

        <div class="row">
            <div class="col-lg-12">
                <a href="customer-information.html" class="btn btn-success mb-3 mr-2"><i class="fas fa-plus-circle mr-2"></i>New Registration Form</a>
            </div>
        </div>

        <!-- Statistics -->
        <div class="card mb-3">
            <div class="row no-gutters row-bordered">
                <div class="col-md-12 col-lg-12 col-xl-12">
                    <div class="card-header">
                        <h5 class="font-weight-bold mb-0">Search Customer</h5>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-lg-3 col-xl-3 mb-2">
                                <div class="form-group">
                                    <label class="form-label form-label-sm text-uppercase">Search</label>
                                    <input type="text" class="form-control form-control-sm" placeholder="HN, Customer Name, Tel No., ID Card">
                                </div>
                            </div>
                            <div class="col-lg-3 col-xl-3 mb-2">
                                <div class="form-group">
                                    <label class="form-label form-label-sm text-uppercase">Status</label>
                                    <select class="form-control form-control-sm">
                                        <option>Active</option>
                                        <option>Inactive</option>
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
                                                    <tr class="text-center">
                                                        <th class="tbw-5">HN</th>
                                                        <th class="tbw-19">Customer Name</th>
                                                        <th class="tbw-9" style="width: 15%;">Phone No.</th>
                                                        <th>ID Card</th>
                                                        <th>Status</th>
                                                        <th class="tbw-9">Tools</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr class="odd gradeX text-center">
                                                        <td>620100001</td>
                                                        <td>นางสาว สุกัญญา เพียบพร้อม</td>
                                                        <td>062-123-3112</td>
                                                        <td>1100100300113</td>
                                                        <td>Active</td>
                                                        <td class="text-center pr-0">
                                                            <div class="btn-group btn-group-sm">
                                                                <a href="#" class="btn btn-primary rounded mr-2">
                                                                    <i class="far fa-eye mr-1"></i>View
                                                                                </a>
                                                                <a href="#" class="btn btn-danger rounded mr-2">
                                                                    <i class="fas fa-portrait mr-1"></i>Visitor Type
                                                                                </a>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr class="odd gradeX text-center">
                                                        <td>620100001</td>
                                                        <td>นางสาว สุกัญญา เพียบพร้อม</td>
                                                        <td>062-123-3112</td>
                                                        <td>1100100300113</td>
                                                        <td>Active</td>
                                                        <td class="text-center pr-0">
                                                            <div class="btn-group btn-group-sm">
                                                                <a href="#" class="btn btn-primary rounded mr-2">
                                                                    <i class="far fa-eye mr-1"></i>View
                                                                                </a>
                                                                <a href="#" class="btn btn-danger rounded mr-2">
                                                                    <i class="fas fa-portrait mr-1"></i>Visitor Type
                                                                                </a>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr class="odd gradeX text-center">
                                                        <td>620100001</td>
                                                        <td>นางสาว สุกัญญา เพียบพร้อม</td>
                                                        <td>062-123-3112</td>
                                                        <td>1100100300113</td>
                                                        <td>Active</td>
                                                        <td class="text-center pr-0">
                                                            <div class="btn-group btn-group-sm">
                                                                <a href="#" class="btn btn-primary rounded mr-2">
                                                                    <i class="far fa-eye mr-1"></i>View
                                                                                </a>
                                                                <a href="#" class="btn btn-danger rounded mr-2">
                                                                    <i class="fas fa-portrait mr-1"></i>Visitor Type
                                                                                </a>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr class="odd gradeX text-center">
                                                        <td>620100001</td>
                                                        <td>นางสาว สุกัญญา เพียบพร้อม</td>
                                                        <td>062-123-3112</td>
                                                        <td>1100100300113</td>
                                                        <td>Active</td>
                                                        <td class="text-center pr-0">
                                                            <div class="btn-group btn-group-sm">
                                                                <a href="#" class="btn btn-primary rounded mr-2">
                                                                    <i class="far fa-eye mr-1"></i>View
                                                                                </a>
                                                                <a href="#" class="btn btn-danger rounded mr-2">
                                                                    <i class="fas fa-portrait mr-1"></i>Visitor Type
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
