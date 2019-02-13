<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="role-position.aspx.cs" Inherits="AnomaERP.BackOffice.Role.RoleSetup.role_position" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <!-- Layout content -->
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Resource Planning
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Resource Planning</a>/
                                    Role Position
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
                                        <label class="form-label form-label-sm text-uppercase">Group Name</label>
                                        <input type="text" class="form-control form-control-sm" placeholder="Group Name" value="Care" disabled>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12 col-xl-12">
                                    <div class="table-responsive">
                                        <table class="table table-bordered">
                                            <thead class="thead-dark">
                                                <tr>
                                                    <th>Task Name</th>
                                                    <asp:Repeater ID="RptPosition" OnItemDataBound="RptPosition_ItemDataBound" runat="server">
                                                        <ItemTemplate>
                                                            <th>
                                                                <asp:Label ID="lblPositionName" runat="server"></asp:Label>
                                                            </th>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <asp:Repeater ID="RptTask" OnItemDataBound="RptTask_ItemDataBound" runat="server">
                                                    <ItemTemplate>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox CssClass="form-control form-control-sm" ID="txtTask" runat="server"></asp:TextBox>
                                                            </td>
                                                            <asp:Repeater ID="RptTaskPosition" OnItemDataBound="RptTaskPosition_ItemDataBound" runat="server">
                                                                <ItemTemplate>
                                                                    <td>
                                                                        <asp:HiddenField ID="hdfPositionId" runat="server" />
                                                                        <asp:HiddenField ID="hdfTaskId" runat="server" />
                                                                        <asp:HiddenField ID="hdfTaskPositionId" runat="server" />
                                                                        <label class="custom-control custom-checkbox mb-0">
                                                                            <input type="checkbox" runat="server" id="chkTask" class="custom-control-input">
                                                                            <span class="custom-control-label">&nbsp;</span>
                                                                        </label>
                                                                    </td>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <asp:LinkButton ID="lbnBack" runat="server" class="btn btn-secondary" OnClick="lbnBack_Click">Back</asp:LinkButton>
                            <asp:LinkButton ID="lbnSave" runat="server" class="btn btn-success" OnClick="lbnSave_Click">Save</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
            <!-- / Statistics -->

        </div>
        <!-- / Content -->
    </div>
    <!-- Layout content -->

    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
