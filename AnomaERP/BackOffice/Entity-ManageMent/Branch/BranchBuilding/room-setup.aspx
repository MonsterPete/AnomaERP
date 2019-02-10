<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="room-setup.aspx.cs" Inherits="AnomaERP.BackOffice.Entity_ManageMent.Branch.BranchBuilding.room_setup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="layout-content">
        <div class="container-fluid flex-grow-1 container-p-y">

            <h4 class="font-weight-bold py-3 mb-2">Room Setup
                            <div class="text-muted text-tiny mt-1">
                                <small class="font-weight-normal text-uppercase">
                                    <a href="#" class="mr-1">Entity List</a>/
                                    <a href="#" class="mr-1">Floor Setup</a>/
                                    Room Setup
                                </small>
                            </div>
            </h4>
            <div class="card mb-3">
                <h4 class="card-header with-elements">
                    <div class="card-header-title">
                        <strong>Room Setup  
                       <br />
                            Floor Code :
                            <label class="text-success">#F1</label></strong>
                    </div>
                </h4>

                <div class="card-body">
                    <div class="row">
                        <div class="col-lg-12 col-xl-12 mb-2">
                            <div class="card-datatable table">
                                <div class="row">
                                    <div class="col-sm-12">
                                        <table class="table">
                                            <thead class="thead-dark">
                                                <tr role="row">
                                                    <th>Room Code</th>
                                                    <th>Status</th>
                                                    <th>Active</th>
                                                    <th>Tools</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                               <asp:Label ID="lblBranchID" runat="server" Text="" Visible="false"></asp:Label>
                                                 <asp:Label ID="lblFloorID" runat="server" Text="" Visible="false"></asp:Label>
                                                <asp:Repeater ID="rptRoom" runat="server" OnItemDataBound="rptRoom_ItemDataBound" OnItemCommand="rptRoom_ItemCommand">
                                                    <ItemTemplate>
                                                        <tr class="odd gradeX">
                                                            <td>
                                                                <asp:Label ID="lblFloorID" runat="server" Text="" Visible="false"></asp:Label>
                                                                <asp:Label ID="lblBranchID" runat="server" Text="" Visible="false"></asp:Label>
                                                                <asp:Label ID="lblRoomID" runat="server" Text="" Visible="false"></asp:Label>
                                                                
                                                                <asp:TextBox ID="txtRoomName" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                                                            </td>
                                                            <td>IS USE
                                                            </td>
                                                            <td class="center">
                                                                <label class="switcher switcher-sm">
                                                                    <asp:HiddenField ID="hdfActive" runat="server" />
                                                                    <asp:LinkButton ID="lbnActive" runat="server" ClientIDMode="AutoID">
                                                                        <input id="chkActive" runat="server" type="checkbox" class="switcher-input">
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
                                                            <td runat="server" id="tdDelete" class="center">
                                                                <div class="btn-group btn-group-sm">
                                                                    <asp:LinkButton ID="lbnDelete" CssClass="btn btn-danger" runat="server">
                                                                                    <i class="ion ion-md-close"></i>
                                                                    </asp:LinkButton>
                                                                </div>
                                                                <div class="btn-group btn-group-sm">
                                                                    <asp:LinkButton ID="lbnRoom" CssClass="btn btn-success" runat="server">
                                                                                   <i class="fas fa-door-open"></i>
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
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
