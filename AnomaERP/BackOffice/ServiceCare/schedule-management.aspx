<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="schedule-management.aspx.cs" Inherits="AnomaERP.BackOffice.ServiceCare.schedule_management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-wrapper layout-2">
        <div class="layout-inner">

            <!-- Layout content -->
            <div class="layout-content">

                <!-- Content -->
                <div class="container-fluid flex-grow-1 container-p-y">

                    <h4 class="font-weight-bold py-3 mb-2">Schedule Management
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <%-- <a href="#" class="mr-1">Nursing Aide</a>/--%>
                                    Schedule Management
                                </small>
                            </div>
                    </h4>

                    <!-- Statistics -->
                    <div class="card mb-3">
                        <div class="row no-gutters row-bordered">
                            <div class="col-md-12 col-lg-12 col-xl-12">
                                <div class="card-body">
                                    <div class="row">
                                        <asp:Label ID="lblEmployeeID" runat="server" Text="" Visible="false"></asp:Label>

                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Customer ID</label>
                                                <div class="input-group">
                                                    <%--   <input type="text" class="form-control" placeholder="Bed Code" value="">--%>
                                                    <asp:TextBox ID="txtCustomerId" runat="server" CssClass="form-control form-control-sm" placeholder="Customer ID"></asp:TextBox>

                                                    <span class="input-group-append">
                                                        <%--<button class="btn btn-primary" type="button">Submit!</button>--%>
                                                        <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="btnSearch_Click" />

                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Customer Name</label>
                                                <%--    <input type="text" class="form-control form-control-sm" placeholder="Customer Name"
                                                    value="นางวาสนา เจริญใจ" disabled>--%>
                                                <asp:TextBox ID="txtCustomerName" runat="server" ReadOnly="true" CssClass="form-control form-control-sm" placeholder="Customer Name"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Branch</label>
                                                <%--    <input type="text" class="form-control form-control-sm" placeholder="Employee"
                                                    value="Suanluang" disabled>--%>
                                                <asp:TextBox ID="txtBranch" runat="server" ReadOnly="true" CssClass="form-control form-control-sm" placeholder="Branch"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Contract Start</label>
                                                <%-- <input type="text" class="form-control form-control-sm" placeholder="Contract Start"
                                                    value="DD/MM/YYYY" disabled>--%>
                                                <asp:TextBox ID="txtStartDate" runat="server" ReadOnly="true" CssClass="form-control form-control-sm" placeholder="Contract Start"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Contract End</label>
                                                <%-- <input type="text" class="form-control form-control-sm" placeholder="Contract Start"
                                                    value="DD/MM/YYYY" disabled>--%>
                                                <asp:TextBox ID="txtEndDate" runat="server" ReadOnly="true" CssClass="form-control form-control-sm" placeholder="Contract End"></asp:TextBox>
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
                                        <!-- <div class="modal-header">
                                                <h5 class="modal-title text-center mb-0">
                                                    Care Plans
                                                </h5>
                                            </div> -->
                                        <div class="card-body">
                                            <div class="row">
                                                <div class="col-lg-12 col-xl-12">
                                                    <div class="card-datatable table-responsive">
                                                        <table class="datatables-demo table table-striped table-hover table-bordered">
                                                            <thead class="thead-dark">
                                                                <tr>
                                                                    <th class="tbw-7">Daily Date</th>
                                                                    <th class="tbw-7">Start Time</th>
                                                                    <th class="tbw-7">End Time</th>
                                                                    <th class="tbw-7">Job</th>
                                                                    <th class="tbw-9">Take Care By</th>
                                                                    <th class="tbw-9">Tools</th>
                                                                </tr>
                                                            </thead>
                                                            <tbody>
                                                                <asp:Repeater ID="resultList" runat="server" OnItemDataBound="rptList_ItemDataBound" OnItemCommand="rptList_ItemCommand">
                                                                    <%-- OnItemCommand="rptInquiryList_ItemCommand" OnItemDataBound="rptInquiryList_ItemDataBound"--%>
                                                                    <ItemTemplate>
                                                                        <tr id="trCountDays" runat="server" class="odd gradeX">
                                                                            <td id="td1" runat="server" style="text-align: center;">
                                                                                <asp:Label ID="lblDailyDate" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td id="td2" runat="server" style="text-align: center;">
                                                                                <asp:Label ID="lblStartTime" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td id="td3" runat="server" style="text-align: center;">
                                                                                <asp:Label ID="lblEndTime" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td id="td4" runat="server" style="text-align: center;">
                                                                                <asp:Label ID="lblJob" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td id="td5" runat="server" style="text-align: center;">
                                                                                <asp:Label ID="lblTakeCareBy" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td class="center">
                                                                                <div class="btn-group btn-group-sm">
                                                                                    <asp:LinkButton ID="lbnAccept" runat="server" CssClass="btn btn-primary btn-sm">ทำการดูแล</asp:LinkButton>
                                                                                </div>
                                                                                <div class="btn-group btn-group-sm">
                                                                                    <asp:LinkButton ID="lbnIsTakeCare" runat="server" CssClass="btn btn-success"><i class="ion ion-md-checkmark"></i></asp:LinkButton>
                                                                                </div>
                                                                                <div class="btn-group btn-group-sm">
                                                                                    <asp:LinkButton ID="lbnReject" runat="server" CssClass="btn  btn-danger"><i class="ion ion-md-close"></i></asp:LinkButton>
                                                                                </div>
                                                                            </td>
                                                                        </tr>
                                                                    </ItemTemplate>
                                                                </asp:Repeater>
                                                            </tbody>
                                                        </table>
                                                    </div>
                                                    <%-- <table class="table table-striped table-hover table-bordered">
                                                        <thead class="thead-dark">
                                                            <tr>
                                                                <th>Start Time</th>
                                                                <th>End Time</th>
                                                                <th>Job</th>
                                                                <th>Take Care By</th>
                                                                <th class="tbw-11">Tools</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr class="odd gradeX">
                                                                <td>8:00</td>
                                                                <td>9:00</td>
                                                                <td>อาบน้ำ
                                                                </td>
                                                                <td>พบ. กัญญารัตน์ ใส่ใจ</td>
                                                                <td>
                                                                    <div class="btn-group btn-group-sm">
                                                                        <a href="#" class="btn btn-success"><i class="ion ion-md-checkmark"></i></a>
                                                                    </div>
                                                                </td>
                                                            </tr>
                                                            <tr class="odd gradeX">
                                                                <td>9:00</td>
                                                                <td>10:00</td>
                                                                <td>ป้อนอาหารเช้า
                                                                </td>
                                                                <td>-</td>
                                                                <td>
                                                                    <a href="#" class="btn btn-primary btn-sm">ทำการดูแล</a>
                                                                </td>
                                                            </tr>
                                                            <tr class="odd gradeX">
                                                                <td>11:00</td>
                                                                <td>12:00</td>
                                                                <td>เดินเล่น</td>
                                                                <td>-</td>
                                                                <td>
                                                                    <a href="#" class="btn btn-primary btn-sm">ทำการดูแล</a>
                                                                </td>
                                                            </tr>
                                                            <tr class="odd gradeX">
                                                                <td>13:00</td>
                                                                <td>14:00</td>
                                                                <td>ป้อนอาหารกลางวัน</td>
                                                                <td>-</td>
                                                                <td>
                                                                    <a href="#" class="btn btn-primary btn-sm">ทำการดูแล</a>
                                                                </td>
                                                            </tr>
                                                            <tr class="odd gradeX">
                                                                <td>15:00</td>
                                                                <td>16:00</td>
                                                                <td>ทำกายภาพบำบัด</td>
                                                                <td>-</td>
                                                                <td>
                                                                    <a href="#" class="btn btn-primary btn-sm">ทำการดูแล</a>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>--%>
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
            </div>
        </div>
    </div>
    <!-- / Layout wrapper -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
