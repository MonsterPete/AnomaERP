<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="visitor-form.aspx.cs" Inherits="AnomaERP.BackOffice.NursingHome.visitor_form" %>

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

            <!-- Statistics -->
            <div class="card mb-3">

                <asp:Label ID="lblVisitorID" runat="server" Text="" Visible="false"></asp:Label>
                <asp:Label ID="lblBranchID" runat="server" Text="" Visible="false"></asp:Label>

                <h4 class="card-header with-elements">
                    <div class="card-header-title"><strong>ใบบันทึกนัดชมศูนย์ฯ</strong></div>
                </h4>
                <div class="row no-gutters row-bordered">
                    <div class="col-md-12 col-lg-12 col-xl-12">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">วันที่นัด</label><label class="text-danger">*</label>
                                        <%--<input type="text"  id="datepicker-base-2">--%>
                                        <asp:TextBox ID="txtAppointmentDate" runat="server" TextMode="Date" CssClass="form-control form-control-sm"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">วันที่เข้าชม</label><label class="text-danger">*</label>
                                        <asp:TextBox ID="txtVisitDate" runat="server" TextMode="Date" CssClass="form-control form-control-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">ชื่อ</label><label class="text-danger">*</label>
                                        <%--<input type="text" class="form-control form-control-sm" placeholder="ชื่อ">--%>
                                        <asp:TextBox ID="txtFirstname" runat="server" CssClass="form-control form-control-sm" placeholder="ชื่อ"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">นามสกุล</label><label class="text-danger">*</label>
                                        <asp:TextBox ID="txtLastname" runat="server" CssClass="form-control form-control-sm" placeholder="นามสกุล"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">เบอร์ติดต่อ</label><label class="text-danger">*</label>
                                        <%--<input type="text" class="form-control form-control-sm" placeholder="เบอร์ติดต่อ">--%>
                                        <asp:TextBox ID="txtPhone" runat="server" TextMode="Phone" CssClass="form-control form-control-sm" placeholder="เบอร์ติดต่อ"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">รับจาก</label>
                                        <%--<input type="text" class="form-control form-control-sm" placeholder="รับจาก">--%>
                                        <asp:TextBox ID="txtReviceFrom" runat="server" CssClass="form-control form-control-sm" placeholder="รับจาก"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">ราคาที่แจ้ง</label>
                                        <%--<input type="text" class="form-control form-control-sm" placeholder="ราคาที่แจ้ง">--%>
                                        <asp:TextBox ID="txtPriceListed" runat="server" TextMode="Number" CssClass="form-control form-control-sm" placeholder="ราคาที่แจ้ง"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <label class="form-label form-label-sm text-uppercase">การจอง</label>
                                    <br>
                                    <label class="form-check form-check-inline">
                                        <%--   <input class="form-check-input" type="radio" name="inline-radios-example"
                                            value="option1">--%>
                                        <asp:RadioButton ID="rdoReservation" runat="server" GroupName="chkReservation" Checked="True" />
                                        <span class="form-check-label">จอง</span>
                                    </label>
                                    <label class="form-check form-check-inline">
                                        <%--<input class="form-check-input" type="radio" name="inline-radios-example"
                                            value="option1">--%>
                                        <asp:RadioButton ID="rdoUnReservation" runat="server" GroupName="chkReservation" />
                                        <span class="form-check-label">ไม่จอง</span>
                                    </label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-6 col-xl-6">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">อาการลูกค้า</label>
                                        <%--<textarea class="form-control form-control-sm" rows="3" placeholder="อาการลูกค้า"></textarea>--%>
                                        <asp:TextBox ID="txtSymptom" runat="server" TextMode="MultiLine" CssClass="form-control form-control-sm" placeholder="อาการลูกค้า"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <div class="card-footer">
                                    <%--<a href="javascript:history.go(-1)" class="btn btn-lg btn-secondary">Back</a>--%>
                                    <a href="index.aspx" class="btn btn-lg  btn-secondary">Back</a>
                                    <%--<a href="#" class="btn btn-lg btn-success">Save</a>--%>

                                    <asp:Button ID="btnSave" runat="server" CssClass="btn btn-lg btn-success" Text="Save" OnClick="btnSave_Click" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
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
