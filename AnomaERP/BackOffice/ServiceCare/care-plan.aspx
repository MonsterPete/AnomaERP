﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="care-plan.aspx.cs" Inherits="AnomaERP.BackOffice.ServiceCare.care_plan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">

    <!-- Content -->
    <div class="container-fluid flex-grow-1 container-p-y">

        <h4 class="font-weight-bold py-3 mb-2">Nursing Aide
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Aide</a>/
                                    <a href="#" class="mr-1">Care Plan Management</a>/
                                    Care Plan List
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
                                    <label class="form-label form-label-sm text-uppercase">Customer Name</label>
                                    <asp:TextBox ID="txtCustomerName" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-lg-3 col-xl-3 mb-2">
                                <div class="form-group">
                                    <label class="form-label form-label-sm text-uppercase">Branch</label>
                                    <asp:TextBox ID="txtBranch" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-lg-3 col-xl-3 mb-2">
                                <div class="form-group">
                                    <label class="form-label form-label-sm text-uppercase">Contract Start</label>
                                    <asp:TextBox ID="txtContractStart" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-lg-3 col-xl-3 mb-2">
                                <div class="form-group">
                                    <label class="form-label form-label-sm text-uppercase">Contract End</label>
                                    <asp:TextBox ID="txtContractEnd" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                                </div>
                            </div>
                        </div>
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
                            <div class="modal-header">
                                <h5 class="modal-title text-center mb-0">Care Plans
                                </h5>
                            </div>
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-lg-12 col-xl-12">
                                        <table class="table table-striped table-hover table-bordered">
                                            <thead class="thead-dark">
                                                <tr>
                                                    <th class="twb-11">Start Time</th>
                                                    <th class="twb-11">End Time</th>
                                                    <th>Job</th>
                                                    <th class="tbw-11">Tools</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr class="odd gradeX">
                                                    <td>
                                                        <asp:TextBox ID="txtStartTime" runat="server" TextMode="Time" CssClass="form-control form-control-sm"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtEndtime" runat="server" TextMode="Time" CssClass="form-control form-control-sm"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlTask" runat="server"></asp:DropDownList>
                                                    </td>
                                                    <td>
                                                        <div class="btn-group btn-group-sm">
                                                            <div class="btn-group btn-group-sm">
                                                                <asp:LinkButton ID="lbnAdd" OnClick="lbnAdd_Click" runat="server" CssClass="btn btn-success">+ Add Task</asp:LinkButton>
                                                            </div>

                                                        </div>
                                                    </td>
                                                </tr>
                                                <asp:Repeater ID="rptCarePlan" OnItemDataBound="rptCarePlan_ItemDataBound" OnItemCommand="rptCarePlan_ItemCommand" runat="server">
                                                    <ItemTemplate>
                                                        <tr class="odd gradeX">
                                                            <td>
                                                                <asp:Label ID="lblStartTime" runat="server" CssClass="form-control form-control-sm"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="lblEndtime" runat="server" CssClass="form-control form-control-sm"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:HiddenField ID="hdfTaskId" runat="server" />
                                                                <asp:Label ID="lblTask" runat="server" CssClass="form-control form-control-sm"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <div class="btn-group btn-group-sm">
                                                                    <asp:LinkButton ID="lbnDelete" runat="server" CssClass="btn btn-danger"><i class="ion ion-md-close"></i></asp:LinkButton>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </tbody>
                                        </table>
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
