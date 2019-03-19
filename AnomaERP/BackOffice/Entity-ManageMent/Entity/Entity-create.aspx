<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Entity-create.aspx.cs" Inherits="AnomaERP.BackOffice.Entity.Entity_info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <!-- Layout content -->
    <div class="layout-content">
        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Entity Management
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Entity List</a>/
                                    Create Entity
                                </small>
                            </div>
            </h4>

            <div class="card mb-3">
                <h4 class="card-header with-elements">
                    <div class="card-header-title"><strong>Nursing Home Setup</strong></div>
                </h4>
                <div class="row no-gutters row-bordered">
                    <div class="col-md-12 col-lg-12 col-xl-12">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <asp:Label ID="lblentityID" runat="server" Text="" Visible="false"></asp:Label>
                                        <label class="form-label form-label-sm text-uppercase">
                                            Nursing Home
                                                        Name:
                                        </label>
                                        <label class="text-danger">*</label>
                                        <asp:TextBox ID="txtEntityName" runat="server" class="form-control form-control-sm" placeholder="Nursing Home Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label w-100">Logo Upload</label>
                                        <asp:FileUpload ID="fileImage" runatCssClass="form-control form-control-sm" runat="server" />
                                        <asp:Label ID="lblimage" runat="server" Visible="false"></asp:Label>
                                        <small id="AlertFileName" runat="server" visible="false" class="form-text" style="color:red">ประเภทของไฟล์ที่อัพโหลด .png, .jpg</small>
                                        <small id="AlertFileSize" runat="server" visible="false" class="form-text" style="color:red">ขนาดไฟล์ไม่ควรเกิน 1 MB</small>
                                        <asp:Button ID="btnupload" CssClass="btn-sm btn-primary" Text="upload" OnClick="btnupload_Click" runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-6 col-xl-6">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">
                                            Address:
                                        </label>
                                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="3" class="form-control form-control-sm" placeholder="Address"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-6 col-xl-6">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">
                                            Register
                                                        Address:
                                        </label>
                                        <asp:TextBox ID="txtRegisAddress" runat="server" TextMode="MultiLine" Rows="3" class="form-control form-control-sm" placeholder="Register Address"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">
                                            Tax ID:
                                        </label>
                                        <asp:TextBox ID="txtTaxID" runat="server" class="form-control form-control-sm" placeholder="Tax ID"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">
                                            Prefix (3
                                                        Character):
                                        </label>
                                        <asp:TextBox ID="txtPrefix" runat="server" class="form-control form-control-sm" placeholder="Prefix"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <hr class="mb-0">
                            <div class="row">
                                <div class="col-lg-12 col-xl-12">
                                    <h5 class="mt-4"><strong>Administrator Information</strong></h5>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">
                                            Username:
                                        </label>
                                        <label class="text-danger">*</label>
                                        <asp:TextBox ID="txtUserName" runat="server" class="form-control form-control-sm" placeholder="Username"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">
                                            Password:
                                        </label>
                                        <label class="text-danger">*</label>
                                        <asp:TextBox ID="txtPassword" runat="server" class="form-control form-control-sm" placeholder="Password"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-xl-3">
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Email:</label>
                                        <asp:TextBox ID="txtEmail" runat="server" class="form-control form-control-sm" placeholder="Email"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label class="form-label form-label-sm text-uppercase">Phone:</label><label class="text-danger">*</label>
                                        <asp:TextBox ID="txtPhone" runat="server" class="form-control form-control-sm" placeholder="Phone"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <div class="card-footer">
                                    <label class="text-danger">* จำเป็นต้องกรอก</label>
                                    <div class="row">
                                        <a href="/BackOffice/Entity-ManageMent/Entity/entity-list.aspx" class="btn btn-lg btn-secondary">Back</a>
                                        <asp:LinkButton ID="lbnSave" OnClick="lbnSave_Click" class="btn btn-lg btn-success" runat="server" ClientIDMode="AutoID">Save</asp:LinkButton>
                                    </div>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>

            <!-- / Statistics -->
        </div>
        <!-- / Content -->

        <!-- Layout footer -->

        <!-- / Layout footer -->

    </div>
    <!-- Layout content -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
