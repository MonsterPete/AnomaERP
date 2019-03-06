<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="branch-create.aspx.cs" Inherits="AnomaERP.BackOffice.Branch.branch_create" %>

<%@ MasterType VirtualPath="~/Masterpage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">
        <div class="container-fluid flex-grow-1 container-p-y">
            <!-- Content -->
            <div class="container-fluid flex-grow-1 container-p-y">

                <h4 class="font-weight-bold py-3 mb-2">Entity Management
                           
                <div class="text-muted text-tiny mt-1">
                    <small class="font-weight-normal text-uppercase">
                        <a href="#" class="mr-1">Entity List</a>/
                                    Branch Setup
                    </small>
                </div>
                </h4>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="card mb-3">
                            <h4 class="card-header with-elements">
                                <div class="card-header-title"><strong>Branch Setup</strong></div>
                            </h4>
                            <div class="row no-gutters row-bordered">
                                <div class="col-md-12 col-lg-12 col-xl-12">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-6 col-xl-6">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">
                                                        Branch Name:                                                   
                                                    </label><label class="text-danger">*</label>
                                                    <asp:Label ID="lblbranchID" runat="server" Text="" Visible="false"></asp:Label>
                                                    <asp:TextBox ID="txtBranchName" runat="server" class="form-control form-control-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-6 col-xl-6">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">
                                                        Address:                                                   
                                                    </label>
                                                    <asp:TextBox ID="txtAddress" runat="server" class="form-control form-control-sm" TextMode="MultiLine" Rows="3"></asp:TextBox>

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
                                                    <asp:TextBox ID="txtAddressRegis" runat="server" class="form-control form-control-sm" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">
                                                        Tax ID:
                                                    </label>
                                                    <asp:TextBox ID="txtTaxID" runat="server" class="form-control form-control-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">
                                                        Prefix (3
                                                        Character):
                                                    </label>
                                                    <asp:TextBox ID="txtPrefix" runat="server" class="form-control form-control-sm" MaxLength="3"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-2 col-xl-2" style="display: none">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">
                                                        Building
                                                        Type:</label>

                                                    <%-- <select class="form-control form-control-sm">
                                            <option>Not Spectify</option>
                                            <option>Stand Alone House</option>
                                            <option>Building</option>
                                            <option>Apartment</option>
                                        </select>--%>
                                                </div>
                                            </div>
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">
                                                        Useage
                                                        Area(sqm.):
                                                    </label>
                                                    <asp:TextBox ID="txtArea" runat="server" class="form-control form-control-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-2 col-xl-2">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">
                                                        Rental
                                                        Price:
                                                    </label> <label class="text-danger">*</label>
                                                    <asp:TextBox ID="txtPrice" runat="server" TextMode="Number" class="form-control form-control-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <hr class="mb-0">

                                        <div class="row">
                                            <div class="col-lg-12 col-xl-12">
                                                <h5 class="mt-4"><strong>Branch Manager</strong></h5>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">
                                                        Username:
                                                   
                                                    </label>
                                                    <label class="text-danger">*</label>
                                                    <asp:TextBox ID="txtUsername" runat="server" class="form-control form-control-sm"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">
                                                        Password:                                                  
                                                    </label>
                                                    <label class="text-danger">*</label>
                                                    <asp:TextBox ID="txtPassword" runat="server" class="form-control form-control-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-xl-3">
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Email:</label>
                                                    <asp:TextBox ID="txtEmail" runat="server" class="form-control form-control-sm" TextMode="Email"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="form-label form-label-sm text-uppercase">Phone:</label><label class="text-danger">*</label>
                                                    <asp:TextBox ID="txtPhone" runat="server" class="form-control form-control-sm" TextMode="Email"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card-footer">
                                        <label class="text-danger">* จำเป็นต้องกรอก</label>
                                        <div class="row">
                                            <a href="/BackOffice/Entity-Management/Branch/branch-list.aspx" class="btn btn-lg btn-secondary">Back</a>
                                            <asp:LinkButton ID="lbnSave" runat="server" class="btn btn-lg btn-success" OnClick="lbnSave_Click">Save</asp:LinkButton>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <!-- / Statistics -->
            </div>
            <!-- / Content -->
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>


