<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="bed-reserve-list.aspx.cs" Inherits="AnomaERP.BackOffice.NursingHome.bed_reserve_list" %>
<%@ MasterType VirtualPath="~/MasterPage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Bed Reservation
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Home</a>/
                                    Bed Reservation
                                </small>
                            </div>
            </h4>

            <div class="row">
                <div class="col-lg-12">
                    <a href="/BackOffice/NursingHome/Bed-Reservation/reserve-form.aspx?customer_reserve_id=0" class="btn btn-success mb-3 mr-2">+ Create Reserve Form</a>
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
                                        <label class="form-label form-label-sm text-uppercase">
                                            Customer
                                                        Name</label>
                                        <asp:TextBox ID="txtCustomerName" CssClass="form-control form-control-sm" runat="server" placeholder="ค้นหา"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3 mb-2" style="display:none">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Status</label>
                                        <asp:DropDownList ID="ddlStatus" CssClass="form-control form-control-sm" runat="server">
                                            <asp:ListItem Text="Reserved" Value="Reserved"></asp:ListItem>
                                            <asp:ListItem Text="NoReserved" Value="No Reserved"></asp:ListItem>
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
                                                            <th class="tbw-5">ID</th>
                                                            <th class="tbw-15">Branch Name</th>
                                                            <th class="tbw-15" style="text-align:center" >Reserve Date</th>
                                                            <th>Customer Name</th>
                                                            <th>Symptom</th>
                                                            <th class="tbw-9">Phone No.</th>
                                                            <th class="tbw-9">Tools</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <asp:Repeater ID="rptCustomerReserveList" runat="server" OnItemDataBound="rptCustomerReserveList_ItemDataBound" OnItemCommand="rptCustomerReserveList_ItemCommand">
                                                            <ItemTemplate>
                                                                <tr class="odd gradeX">
                                                                    <td style="text-align: center;">
                                                                        <asp:Label ID="lblID" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lblBranchName" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td style="text-align: center;">
                                                                        <asp:Label ID="lblReserveDate" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lblCustomerName" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lblSymtom" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lblPhone" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td class="center">
                                                                        <div class="btn-group btn-group-sm">
                                                                            <asp:LinkButton ID="lbnEdit" runat="server" CssClass="btn btn-primary"><i class="ion ion-md-create"></i></asp:LinkButton>
                                                                            <asp:LinkButton ID="lbnCarePlan" runat="server" CssClass="btn btn-success"><i class="ion ion-md-heart"></i></asp:LinkButton>
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
