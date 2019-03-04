<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="role-assign-list.aspx.cs" Inherits="AnomaERP.BackOffice.Role.role_assign_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Resource Planning
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Resource Planning</a>/
                                    Role Assignment
                                </small>
                            </div>
            </h4>
            <div class="row">
                <div class="col-lg-12">
                    <asp:LinkButton ID="btnCreateAssignment" CssClass="btn btn-success mb-3 mr-2" OnClick="btnCreateAssignment_Click" runat="server">
                                + Create Assignment
                    </asp:LinkButton>
                </div>
            </div>


            <asp:UpdatePanel ID="productList" runat="server">
                <ContentTemplate>
                    <!-- Statistics -->
                    <div class="card mb-3">
                        <h6 class="card-header with-elements">
                            <div class="card-header-title">Search</div>
                        </h6>
                        <div class="row no-gutters row-bordered">
                            <div class="col-md-12 col-lg-12 col-xl-12">
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Search</label>
                                                <asp:TextBox ID="txtSearch" CssClass="form-control form-control-sm" placeholder="Search" runat="server" />
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2" style="display: none">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Select Branch</label>
                                                <select class="form-control form-control-sm">
                                                    <option>Branch 1</option>
                                                    <option>Branch 2</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2" style="display: none">
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
                                    <asp:Button ID="btnSearch" CssClass="btn btn-secondary" Text="ค้นหา" OnClick="btnSearch_Click" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="card mb-3">
                        <h6 class="card-header with-elements">
                            <div class="card-header-title">Employee Assignment Lists</div>
                        </h6>
                        <div class="row no-gutters row-bordered">
                            <div class="col-lg-12 col-xl-12">
                                <div class="table-responsive">
                                    <table class="table table-bordered">
                                        <thead class="thead-dark">
                                            <tr>
                                                <th class="tbw-9" style="text-align: center">ID</th>
                                                <th>Position Name</th>
                                                <th>Name</th>
                                                <th>Assignment Status</th>
                                                <th>Cost Center</th>
                                                <th>Status</th>
                                                <th>Tools</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="rptEmployeeList" runat="server" OnItemCommand="rptEmployeeList_ItemCommand" OnItemDataBound="rptEmployeeList_ItemDataBound">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td style="text-align: center">
                                                            <asp:Label ID="lblemployeeID" runat="server" />
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="lblPositionName" runat="server" />
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="lblemployeeName" runat="server" />
                                                        </td>
                                                        <td >
                                                            <asp:Label ID="lblAssignmentStatus" runat="server" />
                                                        </td>
                                                        <td style="text-align: center">
                                                            <asp:Label ID="lblCostCenter" runat="server" />
                                                        </td>
                                                        <td class="center">
                                                            <label class="switcher switcher-sm">
                                                                <asp:HiddenField ID="hdfStatus" runat="server" />
                                                                <asp:LinkButton ID="lbnStatus" runat="server" ClientIDMode="AutoID">
                                                                    <input id="chkStatus" runat="server" type="checkbox" class="switcher-input">
                                                                    <span class="switcher-indicator">
                                                                        <span class="switcher-yes">
                                                                            <span class="ion ion-md-checkmark"></span>
                                                                        </span>
                                                                        <span class="switcher-no">
                                                                            <span class="ion ion-md-close"></span>
                                                                        </span>
                                                                    </span>
                                                                </asp:LinkButton>
                                                            </label>
                                                        </td>
                                                        <td class="center">
                                                            <div class="btn-group btn-group-sm">
                                                                <asp:LinkButton ID="lbnEdit" runat="server" ClientIDMode="AutoID" CssClass="btn btn-primary">
                                                        <i class="ion ion-md-create"></i>
                                                                </asp:LinkButton>
                                                                <asp:LinkButton ID="lbnDelete" runat="server" ClientIDMode="AutoID" CssClass="btn btn-danger" Visible="false">
                                                            <i class="ion ion-md-close"></i>
                                                                </asp:LinkButton>
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
                    <!-- / Statistics -->
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <!-- / Content -->



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
