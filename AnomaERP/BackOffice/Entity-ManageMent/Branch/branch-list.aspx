<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="branch-list.aspx.cs" Inherits="AnomaERP.BackOffice.Branch.branch_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Entity Management
                           
                <div class="text-muted text-tiny mt-1">
                    <small class="font-weight-normal text-uppercase">
                        <a href="#" class="mr-1">Entity Management</a>/
                                    Branch Setup
                                </small>
                </div>
            </h4>

            <div class="row">
                <div class="col-lg-12">
                    <a href="branch-create.aspx" class="btn btn-success mb-3 mr-2">+ Create Branch</a>
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
                                        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control form-control-sm" placeholder="ค้นหา"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3 mb-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Status</label>
                                        <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control form-control-sm text-uppercase">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="btnSearch_Click" />
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
                                                        <asp:Repeater ID="rptBranchList" runat="server" OnItemDataBound="rptBranchList_ItemDataBound" OnItemCommand="rptBranchList_ItemCommand">
                                                            <%-- OnItemCommand="rptInquiryList_ItemCommand" OnItemDataBound="rptInquiryList_ItemDataBound"--%>
                                                            <ItemTemplate>
                                                                <tr id="trCountDays" runat="server" class="odd gradeX">
                                                                    <td>
                                                                        <asp:Label ID="lblEntityID" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="tdCountDays" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblEntityName" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td1" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblBranchID" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td2" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblBranchName" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td3" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblInformation" runat="server"></asp:Label>
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
                                                                            <asp:LinkButton ID="lbnEdit" runat="server" CssClass="btn btn-primary"><i class="ion ion-md-create"></i></asp:LinkButton>
                                                                        </div>
                                                                        <div class="btn-group btn-group-sm">                                                                            
                                                                            <asp:LinkButton ID="lbnFloor" runat="server" CssClass="btn btn-success"><i class="far fa-building"></i></asp:LinkButton>
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
