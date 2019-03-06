<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="position-list.aspx.cs" Inherits="AnomaERP.BackOffice.Role.RoleSetup.position_list" %>

<%@ MasterType VirtualPath="~/Masterpage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <asp:UpdatePanel ID="upnEntityList" runat="server">
        <ContentTemplate>
            <div class="container-fluid flex-grow-1 container-p-y">
                <h4 class="font-weight-bold py-3 mb-2">Resource Planning
           
            <div class="text-muted text-tiny mt-1">
                <small class="font-weight-normal text-uppercase">
                    <a href="javascript:void(0);" class="mr-1">RESOURCE PLANNING</a>/
                                    POSITION LIST
                </small>
            </div>
                    <h4></h4>
                    <div class="row">
                        <div class="col-lg-12">
                            <a class="btn btn-success mb-3 mr-2" href="position-setup.aspx">+ Create Position</a>
                        </div>
                    </div>
                    <!-- Statistics -->
                    <div class="card mb-3">
                        <!-- <h6 class="card-header with-elements">
                                <div class="card-header-title">Filters by</div>
                            </h6> -->
                        <div class="row no-gutters row-bordered">
                            <div class="col-md-12 col-lg-12 col-xl-12">
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">
                                                    Search</label>
                                                <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control form-control-sm" placeholder="ค้นหา"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">
                                                    Status</label>
                                                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control form-control-sm text-uppercase">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="btnSearch_Click" />
                                    <%--OnClick="btnSearch_Click"--%>
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
                                <div class="card-datatable table-responsive">
                                    <table id="tableList" class="datatables-demo table table-striped table-hover table-bordered">
                                        <thead class="thead-dark">
                                            <tr>
                                                <th style="width: 20%">Position Group Name</th>
                                                <th style="width: 10%">Status</th>
                                                <th style="width: 10%">Tools</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="rptGroupList" runat="server" OnItemDataBound="rptGroupList_ItemDataBound" OnItemCommand="rptGroupList_ItemCommand">
                                                <%-- OnItemCommand="rptInquiryList_ItemCommand" OnItemDataBound="rptInquiryList_ItemDataBound"--%>
                                                <ItemTemplate>
                                                    <tr id="trCountDays" runat="server" class="odd gradeX">
                                                        <td id="tdCountDays" runat="server" style="text-align: center;">
                                                            <asp:Label ID="lblGroupName" runat="server"></asp:Label>
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
                                                                <asp:LinkButton ID="lbnConfigTask" runat="server" CssClass="btn btn-success" ClientIDMode="AutoID"><i class="ion ion-md-options"></i></asp:LinkButton>
                                                            </div>
                                                            <div class="btn-group btn-group-sm">
                                                                <asp:LinkButton ID="lbnEdit" runat="server" CssClass="btn btn-primary"><i class="ion ion-md-create"></i></asp:LinkButton>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <!-- / Sale stats -->
                        </div>
                    </div>

                    <!-- / Statistics -->
                </h4>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
    
</asp:Content>
