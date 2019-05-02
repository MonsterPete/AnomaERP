<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="customer-list.aspx.cs" Inherits="AnomaERP.BackOffice.Customer.customer_list" %>

<%@ MasterType VirtualPath="~/Masterpage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <script>

        $(document).ready(function () {
            SetTable();
        });
        function SetTable() {
            $('#inquiryTech').dataTable({
                deferRender: true,
                order: [[0, "desc"]],
                iDisplayLength: 50
            });
        }

    </script>
    <div class="container-fluid flex-grow-1 container-p-y">

        <h4 class="font-weight-bold py-3 mb-2">Customer Management
                           
            <div class="text-muted text-tiny mt-1">
                <small class="font-weight-normal text-uppercase">
                    <a href="#" class="mr-1">Customer Management</a>/
                                    Customer List
                </small>
            </div>
        </h4>

        <div class="row">
            <div class="col-lg-12">
                <a href="/BackOffice/Customer/customer-information.aspx/customer_id=0" class="btn btn-success mb-3 mr-2"><i class="fas fa-plus-circle mr-2"></i>New Registration Form</a>
            </div>
        </div>

        <!-- Statistics -->
        <div class="card mb-3">
            <div class="row no-gutters row-bordered">
                <div class="col-md-12 col-lg-12 col-xl-12">
                    <div class="card-header">
                        <h5 class="font-weight-bold mb-0">Search Customer</h5>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-lg-3 col-xl-3 mb-2">
                                <div class="form-group">
                                    <label class="form-label form-label-sm text-uppercase">Search</label>
                                    <asp:TextBox ID="txtSearch" runat="server" class="form-control form-control-sm" placeholder="KN, Customer Name, Phone No., ID Card"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-lg-3 col-xl-3 mb-2">
                                <div class="form-group">
                                    <label class="form-label form-label-sm text-uppercase">Status</label>
                                    <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control form-control-sm">
                                        <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                        <asp:ListItem Text="Active" Value="true"></asp:ListItem>
                                        <asp:ListItem Text="InActive" Value="false"></asp:ListItem>
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
                                            <table id="inquiryTech" class="datatables-demo table table-striped table-hover table-bordered">
                                                <thead class="thead-dark">
                                                    <tr class="text-center">
                                                        <th class="tbw-5">Kin No.(KN)</th>
                                                        <th class="tbw-19">Customer Name</th>
                                                        <th class="tbw-9" style="width: 15%;">Phone No.</th>
                                                        <th>ID Card</th>
                                                        <th>Status</th>
                                                        <th class="tbw-9">Tools</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <asp:Repeater ID="rptCustomerList" runat="server" OnItemDataBound="rptCustomerList_ItemDataBound" OnItemCommand="rptCustomerList_ItemCommand">
                                                        <ItemTemplate>
                                                            <tr class="odd gradeX text-center">
                                                                <td>
                                                                    <asp:Label ID="lblCustomerID" Visible="false" runat="server"></asp:Label>
                                                                    <asp:Label ID="lblHnNo" runat="server"></asp:Label></td>
                                                                <td class="text-left">
                                                                    <asp:Label ID="lblCustomerName" runat="server"></asp:Label></td>
                                                                <td class="text-left">
                                                                    <asp:Label ID="lblPhoneNo" runat="server"></asp:Label></td>
                                                                <td class="text-left">
                                                                    <asp:Label ID="lblIdCard" runat="server"></asp:Label></td>
                                                                <td>
                                                                    <asp:Label ID="lblStatus" runat="server"></asp:Label></td>
                                                                <td class="text-center pr-0">
                                                                    <div class="btn-group btn-group-sm">
                                                                        <asp:LinkButton ID="lbnEdit" runat="server" CssClass="btn btn-primary rounded mr-2">  <i class="far fa-eye mr-1"></i>View</asp:LinkButton>
                                                                        <asp:LinkButton ID="lbnVisitor" runat="server" CssClass="btn btn-danger rounded mr-2">  <i class="fas fa-portrait mr-1"></i>Visitor Type</asp:LinkButton>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
