<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="floor-setup.aspx.cs" Inherits="AnomaERP.BackOffice.Entity_ManageMent.Branch.BranchBuilding.floor_setup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
     <div class="layout-content">
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Floor Setup
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Entity List</a>/
                                    Floor Setup
                                </small>
                            </div>
            </h4>
            <div class="card mb-3">
                <h4 class="card-header with-elements">
                    <div class="card-header-title">
                        <strong>Floor Setup  </strong>
                    </div>
                </h4>

                <div class="card-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12 mb-2">
                            <div class="card-datatable table">
                                <div class="row">
                                    <div class="col-sm-12">
                                        <table class="table">
                                            <thead class="thead-dark">
                                                <tr role="row">
                                                    <th>Floor Code</th>
                                                    <th>Status</th>
                                                    <th>Active</th>
                                                    <th>Tools</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1" CssClass="form-control form-control-md" runat="server"></asp:TextBox></td>
                                                    <td>IS USE</td>
                                                    <td class="center">
                                                        <label class="switcher switcher-md">
                                                            <input type="checkbox" class="switcher-input" checked="">
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
                                                        <div class="btn-group btn-group-md">
                                                            <a class="btn btn-primary">
                                                                <i class="ion ion-md-search text-white"></i></a>
                                                        </div>
                                                        <div class="btn-group btn-group-md">
                                                            <a class="btn btn-danger">
                                                                <i class="ion ion-md-trash text-white"></i></a>
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
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
