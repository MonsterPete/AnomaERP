<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="reserve-form.aspx.cs" Inherits="AnomaERP.BackOffice.NursingHome.reserve_form" UnobtrusiveValidationMode="None" %>

<%@ MasterType VirtualPath="~/MasterPage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Reservation Form
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Home</a>/
                                    Reservation Form
                                </small>
                            </div>
            </h4>
            <!-- 
                        <div class="row">
                            <div class="col-lg-12">
                                <a href="visitor-form.html" class="btn btn-success mb-3 mr-2">+ Create Visitor Form</a>
                            </div>
                        </div> -->

            <!-- Statistics -->
            <div class="card mb-3">
                <h4 class="card-header with-elements">
                    <div class="card-header-title"><strong>ใบจองเตียง</strong></div>
                </h4>
                <div class="row no-gutters row-bordered">
                    <div class="col-md-12 col-lg-12 col-xl-12">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <asp:Label ID="lblCustomerID" runat="server" Visible="false"></asp:Label>
                                        <asp:Label ID="lblCustomer_relative_ID" runat="server" Visible="false"></asp:Label>
                                        <asp:Label ID="lblCustomer_service_agreement_ID" runat="server" Visible="false"></asp:Label>
                                        <label class="form-label form-label-sm text-uppercase">สาขา</label>
                                        <asp:TextBox ID="txtBranchName" CssClass="form-control form-control-sm" Enabled="false" runat="server" placeholder="สาขา"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">วันที่เริ่ม</label>
                                        <asp:TextBox ID="txtContractStart" CssClass="form-control form-control-sm" runat="server" placeholder="วันที่เริ่ม" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">วันที่สิ้นสุด</label>
                                        <asp:TextBox ID="txtContractEnd" CssClass="form-control form-control-sm" runat="server" placeholder="วันที่สิ้นสุด" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">ชื่อ</label>
                                        <asp:TextBox ID="txtFirstname" CssClass="form-control form-control-sm" runat="server" placeholder="ชื่อ"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">นามสกุล</label>
                                        <asp:TextBox ID="txtLastname" CssClass="form-control form-control-sm" runat="server" placeholder="นามสกุล"></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">เพศ</label>
                                        <asp:DropDownList ID="ddlGender" CssClass="form-control form-control-sm" runat="server">
                                            <asp:ListItem Text="male" Value="Male"></asp:ListItem>
                                            <asp:ListItem Text="female" Value="Female"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">วันเกิด</label>
                                        <asp:TextBox ID="txtDOB" CssClass="form-control form-control-sm" runat="server" placeholder="วันเกิด" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12 col-xl-12">
                                    <h5 class="mt-4"><strong>ญาติ</strong></h5>
                                </div>
                                <div class="col-lg-2 col-xl-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">ชื่อญาติ</label>
                                        <asp:TextBox ID="txtRelativecustomer" CssClass="form-control form-control-sm" runat="server" placeholder="ชื่อญาติ"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-2 col-xl-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">เบอร์ติดต่อ</label>
                                        <asp:TextBox ID="txtPhone" CssClass="form-control form-control-sm" runat="server" placeholder="เบอร์ติดต่อ"></asp:TextBox>
                                        <asp:RangeValidator runat="server"
                                            ID="valrNumberOfPreviousOwners"
                                            ControlToValidate="txtPhone"
                                            Type="Double"
                                            CssClass="input-error"
                                            ErrorMessage="กรุณากรอกตัวเลขเท่านั้น"
                                            ForeColor="Red"
                                            ValidationGroup="whensave">
                                        </asp:RangeValidator>
                                    </div>
                                </div>
                                <div class="col-lg-2 col-xl-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">เกี่ยวข้องเป็น</label>
                                        <asp:TextBox ID="txtrelationCustomer" CssClass="form-control form-control-sm" runat="server" placeholder="เกี่ยวข้องเป็น"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12 col-xl-12">
                                    <h5 class="mt-4"><strong>ข้อตกลงเงื่อนไขการให้บริการ</strong></h5>
                                </div>
                                <div class="col-lg-2 col-xl-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">ค่าบริการรายเดือน</label>
                                        <asp:TextBox ID="txtMonthyCost" CssClass="form-control form-control-sm" runat="server" Text="0" placeholder="จำนวนเงิน"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5"
                                            ControlToValidate="txtMonthyCost"
                                            ValidationExpression="^\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$"
                                            ErrorMessage="กรุณากรอกตัวเลขเท่านั้น" runat="server" ForeColor="Red"
                                            ValidationGroup="whensave">
                                        </asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="col-lg-2 col-xl-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">ค่าเหมาจ่ายผ้าอ้อม</label>
                                        <asp:TextBox ID="txtDiaperCost" CssClass="form-control form-control-sm" runat="server" Text="0" placeholder="จำนวนเงิน"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4"
                                            ControlToValidate="txtDiaperCost"
                                            ValidationExpression="^\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$"
                                            ErrorMessage="กรุณากรอกตัวเลขเท่านั้น" runat="server" ForeColor="Red"
                                            ValidationGroup="whensave">
                                        </asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="col-lg-2 col-xl-2">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">ค่าเหมาจ่ายอุปกรณ์ทำแผล</label>
                                        <asp:TextBox ID="txtDressingEuqCost" CssClass="form-control form-control-sm" runat="server" Text="0" placeholder="จำนวนเงิน"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3"
                                            ControlToValidate="txtDressingEuqCost"
                                            ValidationExpression="^\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$"
                                            ErrorMessage="กรุณากรอกตัวเลขเท่านั้น" runat="server" ForeColor="Red"
                                            ValidationGroup="whensave">
                                        </asp:RegularExpressionValidator>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-6 col-xl-6">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">อื่นๆ</label>
                                        <asp:TextBox ID="txtRemark" CssClass="form-control form-control-sm" runat="server" TextMode="MultiLine" Rows="5" placeholder="อื่นๆ"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">
                                            ได้ชำระเงินจองไว้
                                                        เป็นจำนวน</label>
                                        <asp:TextBox ID="txtReserveCost" CssClass="form-control form-control-sm" runat="server" Text="0" placeholder="จำนวนเงิน"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                            ControlToValidate="txtReserveCost"
                                            ValidationExpression="^\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$"
                                            ErrorMessage="กรุณากรอกตัวเลขเท่านั้น" runat="server" ForeColor="Red"
                                            ValidationGroup="whensave">
                                        </asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">คงเหลือ</label>
                                        <asp:TextBox ID="txtBalacneCost" CssClass="form-control form-control-sm" runat="server" placeholder="คงเหลือ" Text="0"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                                            ControlToValidate="txtBalacneCost"
                                            ValidationExpression="^\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$"
                                            ErrorMessage="กรุณากรอกตัวเลขเท่านั้น" runat="server" ForeColor="Red"
                                            ValidationGroup="whensave">
                                        </asp:RegularExpressionValidator>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <a href="/BackOffice/NursingHome/Bed-Reservation/bed-reserve-list.aspx" class="btn btn-lg btn-secondary">Back</a>
                            <asp:LinkButton ID="lbnSave" ValidationGroup="whensave" OnClick="lbnSave_Click" class="btn btn-lg btn-success" runat="server" ClientIDMode="AutoID">Save</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
            <!-- / Statistics -->
        </div>
        <!-- / Content -->

        <!-- Layout footer -->

        <!-- / Layout footer -->

    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
