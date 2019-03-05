<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="task-setup.aspx.cs" Inherits="AnomaERP.BackOffice.Role.RoleSetup.task_setup" %>

<%@ MasterType VirtualPath="~/Masterpage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">

    <!-- Layout content -->
    <div class="layout-content">

        <!-- Content -->
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Resource Planning
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Resource Planning</a>/
                                    Task Setup
                                </small>
                            </div>
            </h4>

            <!-- <div class="row">
                            <div class="col-lg-12">
                                <a href="branch-create.html" class="btn btn-success mb-3 mr-2">+ Create Branch</a>
                            </div>
                        </div> -->
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <!-- Statistics -->
                    <div class="card mb-3">
                        <div class="row no-gutters row-bordered">
                            <div class="col-md-12 col-lg-12 col-xl-12">
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <div class="form-group">
                                                <label class="form-label form-label-sm text-uppercase">Group Name</label>
                                                <asp:DropDownList ID="ddlGroupName" CssClass="form-control form-control-sm" OnSelectedIndexChanged="ddlGroupName_SelectedIndexChanged" AutoPostBack="true" runat="server">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-9 col-xl-9">
                                            <div class="table-responsive">
                                                <table class="table table-bordered">
                                                    <thead class="thead-dark">
                                                        <tr>
                                                            <th>Task Name</th>
                                                            <th>Status</th>
                                                            <th style="display: none">Tools</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <asp:Label ID="lblGroupID" runat="server" Text="" Visible="false"></asp:Label>
                                                        <asp:Repeater ID="rptTask" runat="server" OnItemDataBound="rptTask_ItemDataBound" OnItemCommand="rptTask_ItemCommand">
                                                            <ItemTemplate>
                                                                <tr class="odd gradeX">
                                                                    <%--  <td>
                                                                <asp:Label ID="lblPositionID" runat="server" Text="" Visible="false"></asp:Label>
                                                                
                                                                <asp:Label ID="lblGroupName" CssClass="form-control form-control-sm" runat="server"></asp:Label>
                                                            </td>--%>
                                                                    <td>
                                                                        <asp:TextBox ID="txtTaskName" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                                                        <asp:Label ID="lblTaskID" runat="server" Text="" Visible="false"></asp:Label>
                                                                    </td>
                                                                    <td class="center">
                                                                        <label class="switcher switcher-sm">
                                                                            <asp:HiddenField ID="hdfStatus" runat="server" />
                                                                            <asp:LinkButton ID="lbnStatus" runat="server" ClientIDMode="AutoID">
                                                                                <input id="chkStatus" runat="server" type="checkbox" class="switcher-input">
                                                                                <span class="switcher-indicator">
                                                                                    <span class="switcher-yes">
                                                                                        <span class="ion ion-md-checkmark"></span>
                                                                                    </span>
                                                                                    <span class="switcher-no">
                                                                                        <span class="ion ion-md-close"></span>
                                                                                    </span>
                                                                                </span>
                                                                            </asp:LinkButton>
                                                                        </label>
                                                                    </td>
                                                                    <td runat="server" id="tdDelete" class="center" style="display: none">
                                                                        <div class="btn-group btn-group-sm">
                                                                            <asp:LinkButton ID="lbnDelete" CssClass="btn btn-danger" runat="server">
                                                                                    <i class="ion ion-md-close"></i>
                                                                            </asp:LinkButton>
                                                                        </div>
                                                                    </td>
                                                                </tr>
                                                            </ItemTemplate>
                                                        </asp:Repeater>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                        <!-- / Statistics -->
                                    </div>
                                    <!-- / Content -->
                                    <div class="row">
                                        <div class="col-lg-12 col-xl-12">
                                            <div class="pull-right">
                                                <asp:LinkButton ID="lbnAdd" runat="server" CssClass="btn btn-sm btn-success" OnClick="lbnAdd_Click">+ เพิ่มรายการ</asp:LinkButton>
                                            </div>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class="row">
                                        <div class="col-lg-3 col-xl-3 mb-2">
                                            <asp:LinkButton ID="lblBack" runat="server" CssClass="btn btn-lg btn-primary" OnClick="lblBack_Click">ยกเลิก</asp:LinkButton>
                                            <asp:LinkButton ID="lbnSave" runat="server" CssClass="btn btn-lg btn-primary" OnClick="lbnSave_Click">บันทึก</asp:LinkButton>
                                        </div>
                                    </div>
                                </div>
                                <!-- / Statistics -->

                            </div>
                            <!-- / Content -->
                        </div>
                        <!-- Layout content -->

                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script type='text/javascript'>
        function openModalError() {
            swal({
                title: '',
                text: 'ทำรายการไม่สำเร็จ',
                type: "error",
                confirmButtonClass: "btn-danger",
            });
        }

        function openModalWaring(msg) {
            swal({
                title: '',
                text: msg,
                type: "warning",
                confirmButtonClass: "btn-warning",
            });
        }

        function openModalSuccess() {
            swal({
                title: '',
                text: 'ทำรายการสำเร็จ',
                type: "success",
                confirmButtonClass: "btn-success",
            });
        }
    </script>
</asp:Content>
