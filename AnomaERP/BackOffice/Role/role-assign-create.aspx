<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="role-assign-create.aspx.cs" Inherits="AnomaERP.BackOffice.Role.role_assign_create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Resource Planning
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Resource Planning</a>/
                                    Role Assignment
                                </small>
                            </div>
            </h4>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <!-- Statistics -->
                    <div class="card mb-3">
                        <h4 class="card-header with-elements">
                            <div class="card-header-title"><strong>Employee Setup</strong></div>
                        </h4>
                        <div class="row no-gutters row-bordered">
                            <div class="col-md-12 col-lg-12 col-xl-12">
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <asp:Label ID="lblEmployeeID" runat="server" Visible="false"></asp:Label>
                                                <label class="form-label form-label-sm text-uppercase">Username</label><label class="text-danger">*</label>
                                                <asp:TextBox ID="txtUsername" CssClass="form-control form-control-sm" placeholder="Username" runat="server" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Password</label><label class="text-danger">*</label>
                                                <asp:TextBox ID="txtPassword" CssClass="form-control form-control-sm" placeholder="Password" runat="server" />
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Email:</label>
                                                <asp:TextBox ID="txtEmail" CssClass="form-control form-control-sm" placeholder="Email" runat="server" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Phone:</label><label class="text-danger">*</label>
                                                <asp:TextBox ID="txtPhone" CssClass="form-control form-control-sm" placeholder="Phone" runat="server" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Firstname:</label><label class="text-danger">*</label>
                                                <asp:TextBox ID="txtFirstname" CssClass="form-control form-control-sm" placeholder="Firstname" runat="server" />
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Lastname:</label><label class="text-danger">*</label>
                                                <asp:TextBox ID="txtLastname" CssClass="form-control form-control-sm" placeholder="Lastname" runat="server" />

                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Nickname:</label>
                                                <asp:TextBox ID="txtNickname" CssClass="form-control form-control-sm" placeholder="Nickname" runat="server" />
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Gender</label>
                                                <asp:DropDownList ID="ddlGender" CssClass="form-control form-control-sm" runat="server">
                                                    <asp:ListItem Value="Male" Text="ชาย"></asp:ListItem>
                                                    <asp:ListItem Value="Female" Text="หญิง"></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Date of Birth</label>
                                                <asp:TextBox ID="txtDateOdBirth" CssClass="form-control form-control-sm" placeholder="Date of Birth" TextMode="Date" runat="server" />
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Citizen ID:</label>
                                                <asp:TextBox ID="txtCitizenID" CssClass="form-control form-control-sm" placeholder="Citizen ID" runat="server" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Job Role</label>
                                                <asp:DropDownList ID="ddlPosition" CssClass="form-control form-control-sm" runat="server">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Working Time</label>
                                                <asp:DropDownList ID="ddlWorkingTime" CssClass="form-control form-control-sm" runat="server">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-12 col-xl-12">
                                        <div class="row">
                                            <h5 class="mt-4"><strong>Work Date</strong></h5>
                                        </div>
                                        <div class="row">
                                            <label class="custom-control custom-checkbox mb-0">
                                                <label class="form-label form-label-sm text-uppercase">Monday</label>
                                                <input type="checkbox" runat="server" id="chkMonday" class="custom-control-input">
                                                <span class="custom-control-label">&nbsp;</span>
                                            </label>

                                            <label class="custom-control custom-checkbox mb-0">
                                                <label class="form-label form-label-sm text-uppercase">Tuesday</label>
                                                <input type="checkbox" runat="server" id="chkTuesday" class="custom-control-input">
                                                <span class="custom-control-label">&nbsp;</span>
                                            </label>

                                            <label class="custom-control custom-checkbox mb-0">
                                                <label class="form-label form-label-sm text-uppercase">Wednesday</label>
                                                <input type="checkbox" runat="server" id="chkWednesday" class="custom-control-input">
                                                <span class="custom-control-label">&nbsp;</span>
                                            </label>

                                            <label class="custom-control custom-checkbox mb-0">
                                                <label class="form-label form-label-sm text-uppercase">Thuresday</label>
                                                <input type="checkbox" runat="server" id="chkThuresday" class="custom-control-input">
                                                <span class="custom-control-label">&nbsp;</span>
                                            </label>

                                            <label class="custom-control custom-checkbox mb-0">
                                                <label class="form-label form-label-sm text-uppercase">Friday</label>
                                                <input type="checkbox" runat="server" id="chkFriday" class="custom-control-input">
                                                <span class="custom-control-label">&nbsp;</span>
                                            </label>

                                            <label class="custom-control custom-checkbox mb-0">
                                                <label class="form-label form-label-sm text-uppercase">Saturday</label>
                                                <input type="checkbox" runat="server" id="chkSaturday" class="custom-control-input">
                                                <span class="custom-control-label">&nbsp;</span>
                                            </label>

                                            <label class="custom-control custom-checkbox mb-0">
                                                <label class="form-label form-label-sm text-uppercase">Sunday</label>
                                                <input type="checkbox" runat="server" id="chkSunday" class="custom-control-input">
                                                <span class="custom-control-label">&nbsp;</span>
                                            </label>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-12 col-xl-12">
                                            <h5 class="mt-4"><strong>Shift Time</strong></h5>
                                        </div>
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Start Time</label>
                                                <asp:TextBox ID="txtStartTime1" CssClass="form-control form-control-sm" placeholder="Start Time" TextMode="Time" runat="server" />
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">End Time</label>
                                                <asp:TextBox ID="txtEndTime1" CssClass="form-control form-control-sm" placeholder="End Time" TextMode="Time" runat="server" />


                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Start Time</label>
                                                <asp:TextBox ID="txtStartTime2" CssClass="form-control form-control-sm" placeholder="Start Time" TextMode="Time" runat="server" />
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">End Time</label>
                                                <asp:TextBox ID="txtEndTime2" CssClass="form-control form-control-sm" placeholder="End Time" TextMode="Time" runat="server" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Start Time</label>
                                                <asp:TextBox ID="txtStartTime3" CssClass="form-control form-control-sm" placeholder="Start Time" TextMode="Time" runat="server" />
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-xl-3">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">End Time</label>
                                                <asp:TextBox ID="txtEndTime3" CssClass="form-control form-control-sm" placeholder="End Time" TextMode="Time" runat="server" />
                                            </div>
                                        </div>
                                    </div>
                                </div>


                                <div class="card-footer">
                                    <label class="text-danger">* จำเป็นต้องกรอก</label>
                                    <div class="row">
                                        <asp:LinkButton ID="lblBack" runat="server" CssClass="btn btn-lg btn-secondary" OnClick="lblBack_Click">ยกเลิก</asp:LinkButton>
                                        <asp:LinkButton ID="lbnSave" runat="server" CssClass="btn btn-lg btn-success" OnClick="lbnSave_Click">บันทึก</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- / Statistics -->
                    </div>
        <!-- / Content -->
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
