﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="customer-information.aspx.cs" Inherits="AnomaERP.BackOffice.Customer.customer_information" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="container-fluid flex-grow-1 container-p-y">

        <h4 class="font-weight-bold py-3 mb-2 print-hidden">Customer Information
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Nursing Home</a>/
                                    Customer Information
                                </small>
                            </div>
        </h4>

        <!-- Register Form -->
        <asp:Label ID="lblCustomerID" runat="server" Visible="false"></asp:Label>
        <div class="row">
            <div class="col-sm-12">
                <div class="card mb-3 p-4">
                    <div class="card-header with-elements border-bottom-0">
                        <div class="row justify-content-between w-100 flex-nowrap mb-4">
                            <div class="col-sm-12">
                                <h4 class="d-block text-center">
                                    <div class="card-header-title"><strong>แบบลงทะเบียนผู้ป่วยใหม่</strong></div>
                                    <p class="mb-0 sub-title-form">(New Registration Form)</p>
                                </h4>
                            </div>
                        </div>
                        <div class="row justify-content-center w-100 flex-nowrap">
                            <div class="col-sm-6">
                                <div class="form-group row justify-content-center">
                                    <label for="staticEmail" class="col-sm-2 col-form-label text-right">HN :</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtHN" CssClass="form-control form-control-sm" placeholder="เลข HN" Enabled="false" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group row justify-content-center">
                                    <label for="staticEmail" class="col-sm-4 col-form-label text-right">วันที่เข้ารับบริการ :</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtCreatedDate" CssClass="form-control form-control-sm" placeholder="วว/ดด/ปปปป" Enabled="false" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row no-gutters row-bordered">
                        <div class="col-md-12 col-lg-12 col-xl-12">
                            <div class="card-body">
                                <div class="general-info-content">
                                    <div class="row">
                                        <div class="col-sm-12">
                                            <h5 class="mt-4"><strong><u>ข้อมูลทั่วไป</u></strong></h5>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    ชื่อ
                                                                    (Firstname)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtFirstName" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    นามสกุล
                                                                    (Lastname)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtLastName" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    เลขที่บัตรประชาชน (ID
                                                                    Card)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtTaxId" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    วันเดือนปีเกิด
                                                                    (DOB)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtDOB" TextMode="Date" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">อายุ (Age)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtAge" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">เพศ (Sex)<span class="text-danger">*</span></label>
                                                <div class="form-group">
                                                    <asp:DropDownList ID="ddlSex" CssClass="form-control form-control-sm" runat="server">
                                                        <asp:ListItem Value="0">เลือกเพศ</asp:ListItem>
                                                        <asp:ListItem Value="Male">ชาย</asp:ListItem>
                                                        <asp:ListItem Value="Female">หญิง</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    สถานภาพสมรส
                                                                    (Martial Status)<span class="text-danger">*</span></label>
                                                <div class="form-group">
                                                    <asp:DropDownList ID="ddlMartialStatus" CssClass="form-control form-control-sm" runat="server">
                                                        <asp:ListItem Value="0">เลือกสถานภาพ</asp:ListItem>
                                                        <asp:ListItem Value="Single">โสด</asp:ListItem>
                                                        <asp:ListItem Value="Marry">แต่งงาน</asp:ListItem>
                                                        <asp:ListItem Value="Divorce">หย่าร้าง</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    ที่อยู่ปัจจุบัน
                                                                    (Address)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtAddress" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">จังหวัด (Province)<span class="text-danger">*</span></label>
                                                <asp:DropDownList ID="ddlProvince" CssClass="form-control form-control-sm" runat="server">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    อำเภอ/เขต
                                                                    (District)<span class="text-danger">*</span></label>
                                                <asp:DropDownList ID="ddlDistrict" CssClass="form-control form-control-sm" runat="server">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">ตำบล/แขวง (Sub-Disctrict)<span class="text-danger">*</span></label>
                                                <asp:DropDownList ID="ddlSubDisctrict" CssClass="form-control form-control-sm" runat="server">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">รหัสไปรษณีย์ (Zip Code)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtZipCode" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    เบอร์โทรศัพท์
                                                                    (Telephone No.)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtPhone" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">ทราบข้อมูลจากช่องทางใด</label>
                                                <asp:DropDownList ID="ddlNewFrom" CssClass="form-control form-control-sm" runat="server">
                                                    <asp:ListItem Value="0">เลือกช่องทาง</asp:ListItem>
                                                    <asp:ListItem Value="Friend">เพื่อนแนะนำ</asp:ListItem>
                                                    <asp:ListItem Value="Brochure">โบรชัวร์</asp:ListItem>
                                                    <asp:ListItem Value="Magazine">นิตยสาร</asp:ListItem>
                                                    <asp:ListItem Value="Billboards">ป้ายโฆษณา</asp:ListItem>
                                                    <asp:ListItem Value="Google">กูเกิ้ล (Google)</asp:ListItem>
                                                    <asp:ListItem Value="Facebook">เฟซบุ๊ค (Facebook)</asp:ListItem>
                                                    <asp:ListItem Value="Website">เว็บไซต์ (Website)</asp:ListItem>
                                                    <asp:ListItem Value="Other">อื่นๆ</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-12 col-xl-12">
                                        <h5 class="mt-4"><strong><u>ผู้ให้ข้อมูลและติดต่อกรณีฉุกเฉิน</u></strong></h5>
                                    </div>
                                </div>
                                <div class="emergency-contact-content">
                                    <div class="row">
                                        <div class="col-sm-8">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    ชื่อ-นามสกุล 1
                                                                    (Name-Surname)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtRelationName1" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    ความสัมพันธ์กับผู้ป่วย
                                                                    (Relationship)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtRelation1" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">เบอร์โทรศัพท์ (Tel No.)</label>
                                                <asp:TextBox ID="txtRelationTel1" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">เบอร์โทรศัพท์กรณีฉุกเฉิน (Emergency No.)</label>
                                                <asp:TextBox ID="txtRelationTelEmergency1" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">LINE ID</label>
                                                <asp:TextBox ID="txtRelationLine1" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">Facebook Messenger</label>
                                                <asp:TextBox ID="txtRelationFacebook1" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">E-mail</label>
                                                <asp:TextBox ID="txtRelationEmail1" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    ที่อยู่ของญาติ 1
                                                                    (Relative Address 1)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtRelationAddress1" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="emergency-contact-content">
                                    <div class="row">
                                        <div class="col-sm-8">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    ชื่อ-นามสกุล 2
                                                                    (Name-Surname 2)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtRelationName2" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    ความสัมพันธ์กับผู้ป่วย
                                                                    (Relationship)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtRelation2" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">เบอร์โทรศัพท์ (Tel No.)</label>
                                                <asp:TextBox ID="txtRelationTel2" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">เบอร์โทรศัพท์กรณีฉุกเฉิน (Emergency No.)</label>
                                                <asp:TextBox ID="txtRelationTelEmergency2" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">LINE ID</label>
                                                <asp:TextBox ID="txtRelationLine2" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">Facebook Messenger</label>
                                                <asp:TextBox ID="txtRelationFacebook2" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">E-mail</label>
                                                <asp:TextBox ID="txtRelationEmail2" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm">
                                                    ที่อยู่ของญาติ 2
                                                                    (Relative Address 2)<span class="text-danger">*</span></label>
                                                <asp:TextBox ID="txtRelationAddress" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row page-break">
                                    <div class="col-lg-12 col-xl-12">
                                        <h5 class="mt-4"><strong><u>ข้อมูลแรกรับ (ซักประวัติ)</u></strong></h5>
                                    </div>
                                </div>
                                <div class="row mb-3">
                                    <div class="col-sm-3">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm">วันเดือนปีที่รับ</label>
                                            <asp:TextBox ID="txtDateInformationRecieve" CssClass="form-control form-control-sm" runat="server" TextMode="Date"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-sm-3">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm">เวลา</label>
                                            <asp:TextBox ID="txtTimeInformationRecieve" CssClass="form-control form-control-sm" runat="server" TextMode="Time"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row f-12 mb-3">
                                    <div class="col-lg-12 col-xl-12">
                                        <h5 class="f-12 font-weight-normal">ผู้รับบริการมาโดย :</h5>
                                    </div>
                                    <div class="col-sm-12">
                                        <div class="row">
                                            <div class="col-sm-2">
                                                <div class="form-group">
                                                    <label class="custom-control custom-radio">
                                                        <asp:RadioButton ID="rbtnServiceBy1" GroupName="ServiceBy" CssClass="custom-control-input" runat="server" />
                                                        <span class="custom-control-label">ญาตินำส่งเอง</span>
                                                    </label>
                                                </div>
                                            </div>
                                            <div class="col-sm-5">
                                                <div class="form-group">
                                                    <label class="custom-control custom-radio mb-1">
                                                        <%--custom-control-input--%>
                                                        <asp:RadioButton ID="rbtnServiceBy2" GroupName="ServiceBy" CssClass="custom-control-input" runat="server" />
                                                        <span class="custom-control-label">ไปรับจาก</span>
                                                    </label>
                                                    <asp:TextBox ID="txtServiceBy2" CssClass="form-control form-control-sm w-100" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-sm-5">
                                                <div class="form-group form-inline">
                                                    <label class="custom-control custom-radio mb-1">
                                                        <asp:RadioButton ID="rbtnServiceBy3" GroupName="ServiceBy" CssClass="custom-control-input" runat="server" />
                                                        <span class="custom-control-label">อื่นๆ</span>
                                                    </label>
                                                    <asp:TextBox ID="txtServiceBy3" CssClass="form-control form-control-sm w-100" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row mb-3">
                                    <div class="col-sm-12">
                                        <div class="form-group">
                                            <label
                                                class="form-label form-label-sm text-uppercase">
                                                เอกสารสำคัญ/ความต้องการสำคัญ<span class="text-danger">*</span></label>
                                            <asp:TextBox ID="txtImportantDoc" CssClass="form-control form-control-sm " placeholder="เอกสารสำคัญ/ความต้องการสำคัญ" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row f-12 mb-2">
                                    <div class="col-sm-12">
                                        <h5 class="f-12 font-weight-normal">โรคประจำตัว :</h5>
                                    </div>
                                    <div class="col-sm-12 flex-wrap">
                                        <div class="row">
                                            <div class="col-sm-3">
                                                <div class="form-group mr-3">
                                                    <label class="custom-control custom-checkbox">
                                                        <asp:CheckBoxList ID="chkCongenitalDisease" runat="server"></asp:CheckBoxList>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row f-12 mb-2">
                                    <div class="col-sm-12">
                                        <h5 class="f-12 font-weight-normal">Red Flag :</h5>
                                    </div>
                                    <div class="col-sm-12">
                                        <div class="row">
                                            <div class="col-sm-3">
                                                <div class="form-group">
                                                    <label class="custom-control custom-checkbox">
                                                        <asp:CheckBoxList ID="chkRedFlag" CssClass="custom-control-input" runat="server"></asp:CheckBoxList>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row f-12 mb-2">
                                    <div class="col-sm-12">
                                        <h5 class="f-12 font-weight-normal">ประเมินความเสี่ยงต่อภาวะ :</h5>
                                    </div>
                                    <div class="col-sm-12">
                                        <div class="row">
                                            <div class="col-sm-3">
                                                <div class="form-group mr-3">
                                                    <label class="custom-control custom-checkbox">
                                                        <asp:CheckBoxList ID="chkRiskAssessment" CssClass="custom-control-input" runat="server"></asp:CheckBoxList>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row f-12 mb-3">
                                    <div class="col-sm-12">
                                        <h5 class="f-12 font-weight-normal">ปัจจัยส่วนบุคคลส่งผลต่อความเจ็บป่วย
                                                            :</h5>
                                    </div>
                                    <div class="col-sm-12">
                                        <div class="row">
                                            <div class="col-sm-3">
                                                <div class="form-group mr-3">
                                                    <label class="custom-control custom-checkbox">
                                                        <asp:CheckBoxList ID="chkPersonalFactors" CssClass="custom-control-input" runat="server"></asp:CheckBoxList>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-12">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm text-uppercase">
                                                ประวัติการเจ็บป่วยปัจจุบัน
                                                                :</label>
                                            <asp:TextBox ID="txtCurrentIllness" CssClass="form-control form-control-sm " placeholder="ประวัติการเจ็บป่วยปัจจุบัน" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-12">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm text-uppercase">
                                                ประวัติการเจ็บป่วยในอดีต
                                                                :</label>
                                            <asp:TextBox ID="txtHistoryIllness" CssClass="form-control form-control-sm " placeholder="ประวัติการเจ็บป่วยในอดีต" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-12">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm text-uppercase">การวินิจฉัยของแพทย์ :</label>
                                            <asp:TextBox ID="txtDiagnosis" CssClass="form-control form-control-sm " placeholder="การวินิจฉัยของแพทย์" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row mb-2">
                                    <div class="col-sm-12">
                                        <div class="form-group">
                                            <label class="form-label form-label-sm text-uppercase">
                                                การรักษาที่เคยได้รับจากแพทย์
                                                                :</label>
                                            <asp:TextBox ID="txtTreatment" CssClass="form-control form-control-sm " placeholder="เคยได้รับจากแพทย์" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row f-12">
                                    <div class="col-lg-12 col-xl-12">
                                        <h5 class="f-12 font-weight-normal">เคยได้รับการผ่าตัด :</h5>
                                    </div>
                                    <div class="col-sm-3">
                                        <div class="form-group">
                                            <label class="custom-control custom-radio">
                                                <asp:RadioButton ID="rbtnTreatment1" GroupName="Treatment" CssClass="custom-control-input" runat="server" />
                                                <span class="custom-control-label">ไม่มี</span>
                                            </label>
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label class="custom-control custom-radio mb-1">
                                                <asp:RadioButton ID="rbtnTreatment2" GroupName="Treatment" CssClass="custom-control-input" runat="server" />
                                                <span class="custom-control-label">มี</span>
                                            </label>
                                            <asp:TextBox ID="txtTreatmentComment" CssClass="form-control form-control-sm " placeholder="ข้อมูลการผ่าตัดที่เคยได้รับ" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-12 col-xl-12">
                                        <h5 class="mt-4"><strong><u>การตรวจสัญญาณชีพแรกรับ</u></strong></h5>
                                    </div>
                                    <div class="col-sm-12">
                                        <div class="row">
                                            <div class="col-sm-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm">Vital Sign :</label>
                                                    <asp:TextBox ID="txtT_C" CssClass="form-control form-control-sm " placeholder="T/C" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-sm-3">
                                                <label class="form-label form-label-sm"></label>
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtP_Min" CssClass="form-control form-control-sm " placeholder="P/Min" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-sm-3">
                                                <label class="form-label form-label-sm"></label>
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtR_Min" CssClass="form-control form-control-sm " placeholder="R/Min" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-sm-3">
                                                <label class="form-label form-label-sm"></label>
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtBP_mmHg" CssClass="form-control form-control-sm " placeholder="BP/mmHg" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-sm-3">
                                                <label class="form-label form-label-sm"></label>
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtO2Sat_Percent" CssClass="form-control form-control-sm " placeholder="O2Sat/%" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-sm-3">
                                                <label class="form-label form-label-sm"></label>
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtBW_kg" CssClass="form-control form-control-sm " placeholder="BW/kg" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-sm-3">
                                                <label class="form-label form-label-sm"></label>
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtHT_Cm" CssClass="form-control form-control-sm " placeholder="HT/Cm" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-sm-3">
                                                <label class="form-label form-label-sm"></label>
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtBMI_Index" CssClass="form-control form-control-sm " placeholder="BMI/Index" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="card-footer d-flex justify-content-between my-2 border-top-0 print-hidden">
                                <a href="#" class="btn btn-lg btn-outline-secondary print-hidden">Reset</a>
                                <a href="#" class="btn btn-lg btn-success print-hidden">Print</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>