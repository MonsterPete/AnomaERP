<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AnomaERP.BackOffice.NursingHome.index" %>

<%@ MasterType VirtualPath="~/Masterpage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">
        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Visitor Form
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Home</a>/
                                    Visitor Form
                                </small>
                            </div>
            </h4>

            <div class="row">
                <div class="col-lg-12">
                    <a href="visitor-form.aspx" class="btn btn-success mb-3 mr-2">+ Create Visitor Form</a>
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
                                        <label class="form-label form-label-sm text-uppercase">Customer Name</label>
                                        <%--<input type="text" class="form-control form-control-sm" placeholder="ค้นหา">--%>
                                        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control form-control-sm" placeholder="ค้นหา"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3 mb-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Status</label>
                                        <asp:DropDownList ID="fltReserved" runat="server" CssClass="" class="form-control form-control-sm">
                                            <asp:ListItem>All</asp:ListItem>
                                            <asp:ListItem>Reserved</asp:ListItem>
                                            <asp:ListItem>No Reserved</asp:ListItem>
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
                                                            <%--<th class="tbw-5">#</th>--%>
                                                            <th class="tbw-7">Appointment Date</th>
                                                            <th class="tbw-7">Visitor Date</th>
                                                            <th class="tbw-7">Visitor Name</th>
                                                            <th class="tbw-7">Phone Number</th>
                                                            <th class="tbw-9">Reserve Status</th>
                                                            <th class="tbw-9">Tools</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <asp:Repeater ID="resultList" runat="server" OnItemDataBound="rptList_ItemDataBound" OnItemCommand="rptList_ItemCommand">
                                                            <%-- OnItemCommand="rptInquiryList_ItemCommand" OnItemDataBound="rptInquiryList_ItemDataBound"--%>
                                                            <ItemTemplate>
                                                                <tr id="trCountDays" runat="server" class="odd gradeX">
                                                                    <%--    <td>
                                                                        <asp:Label ID="lblVisitorID" runat="server"></asp:Label>
                                                                    </td>--%>
                                                                    <td id="td1" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblAppointmentDate" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td2" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblVisitDate" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td3" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblFullName" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td4" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblPhone" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td id="td5" runat="server" style="text-align: center;">
                                                                        <asp:Label ID="lblReserve" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td class="center">
                                                                        <div class="btn-group btn-group-sm">
                                                                            <asp:LinkButton ID="lbnEdit" runat="server" CssClass="btn btn-primary"><i class="ion ion-md-create"></i></asp:LinkButton>
                                                                        </div>
                                                                        <%--  <div class="btn-group btn-group-sm">
                                                                            <asp:LinkButton ID="lbnDelete" runat="server" CssClass="btn btn-danger"><i class="ion ion-md-close"></i></asp:LinkButton>
                                                                        </div>--%>
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
