<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="logistic-reserve-form.aspx.cs" Inherits="AnomaERP.BackOffice.NursingHome.logistic_reserve_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Moving & Logistic Form
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Home</a>/
                                    Moving & Logistic Form
                                </small>
                            </div>
                        </h4>
                        <!-- Statistics -->
                        <div class="card mb-3">
                            <h4 class="card-header with-elements">
                                <div class="card-header-title"><strong>ใบบันทึกและใบจองรถ</strong></div>
                            </h4>
                            <div class="row no-gutters row-bordered">
                                <div class="col-md-12 col-lg-12 col-xl-12">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">วันที่</label>
                                                    <input type="text" class="form-control form-control-sm" id="datepicker-base">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">เรื่อง</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="เรื่อง">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">จาก</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="จาก">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">ถึง</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="ถึง">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">ชื่อลูกค้า</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="ชื่อลูกค้า">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">เบอร์ติดต่อ</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="เบอร์ติดต่อ">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">สถานที่ไป</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="สถานที่ไป">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">สถานที่กลับ</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="สถานที่กลับ">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">เวลา</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="เวลา">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-6 col-xl-6">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">หมายเหตุ</label>
                                                    <textarea class="form-control form-control-sm" rows="3" placeholder="หมายเหตุ"></textarea>
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
