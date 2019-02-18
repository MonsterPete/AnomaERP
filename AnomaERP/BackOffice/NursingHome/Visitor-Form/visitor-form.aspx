<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="visitor-form.aspx.cs" Inherits="AnomaERP.BackOffice.NursingHome.visitor_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

                    <!-- Content -->
                    <div class="container-fluid flex-grow-1 container-p-y">

                        <h4 class="font-weight-bold py-3 mb-2">
                            Visitor Form
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Home</a>/
                                    Visitor Form
                                </small>
                            </div>
                        </h4>

                        <!-- Statistics -->
                        <div class="card mb-3">
                            <h4 class="card-header with-elements">
                                <div class="card-header-title"><strong>ใบบันทึกนัดชมศูนย์ฯ</strong></div>
                            </h4>
                            <div class="row no-gutters row-bordered">
                                <div class="col-md-12 col-lg-12 col-xl-12">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">วันที่นัด</label>
                                                    <input type="text" class="form-control form-control-sm" id="datepicker-base">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">วันที่เข้าชม</label>
                                                    <input type="text" class="form-control form-control-sm" id="datepicker-base-2">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">ชื่อ</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="ชื่อ">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">นามสกุล</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="นามสกุล">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">เบอร์ติดต่อ</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="เบอร์ติดต่อ">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">รับจาก</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="รับจาก">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">ราคาที่แจ้ง</label>
                                                    <input type="text" class="form-control form-control-sm" placeholder="ราคาที่แจ้ง">
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <label class="form-label form-label-sm text-uppercase">การจอง</label>
                                                <br>
                                                <label class="form-check form-check-inline">
                                                    <input class="form-check-input" type="radio" name="inline-radios-example"
                                                        value="option1">
                                                    <span class="form-check-label">จอง</span>
                                                </label>
                                                <label class="form-check form-check-inline">
                                                    <input class="form-check-input" type="radio" name="inline-radios-example"
                                                        value="option1">
                                                    <span class="form-check-label">ไม่จอง</span>
                                                </label>
                                            </div>
                                        </div>                                        
                                        <div class="row">
                                            <div class="col-lg-6 col-xl-6">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">อาการลูกค้า</label>
                                                    <textarea class="form-control form-control-sm" rows="3" placeholder="อาการลูกค้า"></textarea>
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
