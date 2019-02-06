<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="branch-list.aspx.cs" Inherits="AnomaERP.BackOffice.Branch.branch_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Entity Management
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Entity Management</a>/
                                    Branch Setup
                                </small>
                            </div>
                        </h4>

                        <div class="row">
                            <div class="col-lg-12">
                                <a href="branch-create.html" class="btn btn-success mb-3 mr-2">+ Create Branch</a>
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
                                                    <input type="text" class="form-control form-control-sm" placeholder="ค้นหา">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3 mb-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Status</label>
                                                    <select class="form-control form-control-sm">
                                                        <option>Enable</option>
                                                        <option>Disable</option>
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
                                                                        <th class="tbw-9">Entity ID</th>
                                                                        <th class="tbw-19">Entity Name</th>
                                                                        <th class="tbw-9">Branch ID</th>
                                                                        <th class="tbw-19">Branch Name</th>
                                                                        <th class="">Information</th>
                                                                        <th class="tbw-9">Status</th>
                                                                        <th class="tbw-9">Tools</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    <tr class="odd gradeX">
                                                                        <td>0000001</td>
                                                                        <td>Nursing Home Entity</td>
                                                                        <td>BN-0001</td>
                                                                        <td>Nursing Home Entity</td>
                                                                        <td>
                                                                            เลขที่ 184/141 อาคารฟอรั่มทาวเวอร์
                                                                            ห้องเลขที่ 184/3 ชั้นที่ 23 ถนนรัชดาภิเษก
                                                                            เขตห้วยขวาง กรุงเทพมหานคร 10310
                                                                        </td>
                                                                        <td class="center">
                                                                            <label class="switcher switcher-sm">
                                                                                <input type="checkbox" class="switcher-input"
                                                                                    checked>
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
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="branch-create.html" class="btn btn-primary">
                                                                                    <i class="ion ion-md-create"></i></a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>0000002</td>
                                                                        <td>Nursing Home Entity</td>
                                                                        <td>BN-0001</td>
                                                                        <td>Nursing Home Entity</td>
                                                                        <td>
                                                                            เลขที่ 184/141 อาคารฟอรั่มทาวเวอร์
                                                                            ห้องเลขที่ 184/3 ชั้นที่ 23 ถนนรัชดาภิเษก
                                                                            เขตห้วยขวาง กรุงเทพมหานคร 10310
                                                                        </td>
                                                                        <td class="center">
                                                                            <label class="switcher switcher-sm">
                                                                                <input type="checkbox" class="switcher-input"
                                                                                    checked>
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
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="branch-create.html" class="btn btn-primary">
                                                                                    <i class="ion ion-md-create"></i></a>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="odd gradeX">
                                                                        <td>0000003</td>
                                                                        <td>Nursing Home Entity</td>
                                                                        <td>BN-0001</td>
                                                                        <td>Nursing Home Entity</td>
                                                                        <td>
                                                                            เลขที่ 184/141 อาคารฟอรั่มทาวเวอร์
                                                                            ห้องเลขที่ 184/3 ชั้นที่ 23 ถนนรัชดาภิเษก
                                                                            เขตห้วยขวาง กรุงเทพมหานคร 10310
                                                                        </td>
                                                                        <td class="center">
                                                                            <label class="switcher switcher-sm">
                                                                                <input type="checkbox" class="switcher-input"
                                                                                    checked>
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
                                                                        <td class="center">
                                                                            <div class="btn-group btn-group-sm">
                                                                                <a href="branch-create.html" class="btn btn-primary">
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
                    <!-- / Content -->

                    <!-- Layout footer -->
                 
                    <!-- / Layout footer -->

                </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
