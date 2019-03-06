<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="job-assign.aspx.cs" Inherits="AnomaERP.BackOffice.Bed_Management.Job.job_assign" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Job Assignment
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Job Assignment</a>/
                                    Job Assignment Info
                                </small>
                            </div>
            </h4>
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
                            <a href="#" class="btn btn-primary" data-toggle="modal"
                                data-target="#modals-edit">
                                <i class="ion ion-md-create"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
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
                                                            <th>Tools</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <asp:Repeater ID="RptDayActivities" OnItemDataBound="RptDayActivities_ItemDataBound" runat="server">
                                                            <ItemTemplate>
                                                                <tr class="odd gradeX">
                                                                    <td>
                                                                        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <table>
                                                                            <asp:Repeater ID="RptDailyActivities" OnItemDataBound="RptDailyActivities_ItemDataBound" runat="server">
                                                                                <ItemTemplate>
                                                                                    <tr>
                                                                                        <td>
                                                                                            <asp:Label ID="lblDailyTime" runat="server" Text="10.00-12.00"></asp:Label>
                                                                                            :
                                                                                            <asp:Label ID="lblDailyTask" runat="server" Text="ให้อาหารอ่อน"></asp:Label>
                                                                                        </td>
                                                                                    </tr>
                                                                                </ItemTemplate>
                                                                            </asp:Repeater>
                                                                        </table>
                                                                        <table>
                                                                            <asp:Repeater ID="RptExtraActivities" OnItemDataBound="RptExtraActivities_ItemDataBound" runat="server">
                                                                                <ItemTemplate>
                                                                                    <tr>
                                                                                        <td>
                                                                                            <asp:Label ID="lblExtraTime" runat="server" Text="10.00-12.00"></asp:Label>
                                                                                            :
                                                                                            <asp:Label ID="lblExtraTask" runat="server" Text="ให้อาหารอ่อน"></asp:Label>
                                                                                        </td>
                                                                                    </tr>
                                                                                </ItemTemplate>
                                                                            </asp:Repeater>
                                                                        </table>
                                                                    </td>
                                                                    <td>
                                                                        <div class="btn-group btn-group-sm">
                                                                            <a href="#" class="btn btn-primary" data-toggle="modal"
                                                                                data-target="#modals-edit">
                                                                                <i class="ion ion-md-create"></i>
                                                                            </a>
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
                    </div>
                </div>
            </div>

        </div>
        <!-- / Content -->
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
    <div class="modal fade" id="modals-edit">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title text-center mb-0">Schedule on <asp:Label ID="lblDate" runat="server"></asp:Label>
                    </h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">×</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12">
                            <table class="table table-striped table-hover table-bordered">
                                <thead class="thead-dark">
                                    <tr>
                                        <th style="width:30%">Start Time</th>
                                        <th style="width:30%">End Time</th>
                                        <th style="width:40%">Job</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr class="odd gradeX">
                                        <td>
                                            <div class="form-inline">
                                                <asp:DropDownList ID="ddlStartHour" runat="server" CssClass="form-control form-control-sm custom-select ui-w-50">
                                                </asp:DropDownList>
                                                <span class="mx-2">:</span>
                                                <asp:DropDownList ID="ddlStartMinute" runat="server" CssClass="form-control form-control-sm custom-select ui-w-50">
                                                </asp:DropDownList>
                                                <span class="mx-2">:</span>
                                                <asp:DropDownList ID="ddlStartUnit" runat="server" CssClass="form-control form-control-sm custom-select ui-w-50">
                                                    <asp:ListItem Value="AM">AM</asp:ListItem>
                                                    <asp:ListItem Value="PM">PM</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="form-inline">
                                                <asp:DropDownList ID="ddlEndHour" runat="server" CssClass="form-control form-control-sm custom-select ui-w-50">
                                                </asp:DropDownList>
                                                <span class="mx-2">:</span>
                                                <asp:DropDownList ID="ddlEndMinute" runat="server" CssClass="form-control form-control-sm custom-select ui-w-50">
                                                </asp:DropDownList>
                                                <span class="mx-2">:</span>
                                                <asp:DropDownList ID="ddlEndUnit" runat="server" CssClass="form-control form-control-sm custom-select ui-w-50">
                                                    <asp:ListItem Value="AM">AM</asp:ListItem>
                                                    <asp:ListItem Value="PM">PM</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="form-group mb-0">
                                                <asp:DropDownList ID="ddlTask" runat="server" CssClass="form-control form-control-sm custom-select">
                                                </asp:DropDownList>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class="col-lg-12 col-xl-12">
                            <div class="form-group mt-3 mb-0">
                                <label for="" class="form-label form-label-sm text-uppercase">Remark</label>
                                <asp:TextBox ID="txtRemark" runat="server" TextMode="MultiLine" Columns="30" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <hr class="m-0">
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" data-dismiss="modal">Cancel</a>
                    <asp:LinkButton ID="lbnComfirm" CssClass="btn btn-success" runat="server" OnClick="lbnComfirm_Click">Comfirm</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
