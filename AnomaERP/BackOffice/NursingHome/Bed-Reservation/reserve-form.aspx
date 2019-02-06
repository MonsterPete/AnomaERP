<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="reserve-form.aspx.cs" Inherits="AnomaERP.BackOffice.NursingHome.reserve_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Reservation Form
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
                                                    <label class="form-label form-label-sm text-uppercase">สาขา</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="สาขา">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">วันที่</label>
                                                    <input type="text" class="form-control form-control-sm" id="datepicker-base">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">ชื่อ-นามสกุล
                                                        ลูกค้า</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="ชื่อ-นามสกุล">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">อายุ</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="อายุ">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-6 col-xl-6">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">โรคประจำตัว
                                                        / อาการ</label>
                                                    <textarea class="form-control form-control-sm" rows="3" placeholder="โรคประจำตัว / อาการ"></textarea>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">ชื่อญาติ</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="ชื่อญาติ">
                                                </div>
                                            </div>
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">เบอร์ติดต่อ</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="เบอร์ติดต่อ">
                                                </div>
                                            </div>
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">เกี่ยวข้องเป็น</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="เกี่ยวข้องเป็น">
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
                                                    <input type="text" class="form-control form-control-sm" placeholder="จำนวนเงิน">
                                                </div>
                                            </div>
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">ค่าเหมาจ่ายผ้าอ้อม</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="จำนวนเงิน">
                                                </div>
                                            </div>
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">ค่าเหมาจ่ายอุปกรณ์ทำแผล</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="จำนวนเงิน">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-6 col-xl-6">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">อื่นๆ</label>
                                                    <textarea class="form-control form-control-sm" rows="3" placeholder="อื่นๆ"></textarea>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">ได้ชำระเงินจองไว้
                                                        เป็นจำนวน</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="จำนวนเงิน">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">คงเหลือ</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="คงเหลือ">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card-footer">
                                        <a href="#" class="btn btn-lg btn-secondary">Back</a>
                                        <a href="#" class="btn btn-lg btn-success">Save</a>
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
