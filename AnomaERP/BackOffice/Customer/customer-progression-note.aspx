<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="customer-progression-note.aspx.cs" Inherits="AnomaERP.BackOffice.Customer.customer_progression_note" %>

<%@ MasterType VirtualPath="~/Masterpage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FromPlaceHolder" runat="server">
    <div class="container-fluid flex-grow-1 container-p-y">
        <h4 class="font-weight-bold py-3 mb-2 print-hidden">Progress Note
                        <div class="text-muted text-tiny mt-1">
                            <small class="font-weight-normal text-uppercase">
                                <a href="#" class="mr-1">Nursing Home</a>/
                                <a href="#" class="mr-1">Customer Vistor</a>/
                                Progress Note
                            </small>
                        </div>
        </h4>
    </div>
    <asp:Label ID="lblProgressNoteId" runat="server" Visible="false"></asp:Label>
    <div class="row">
        <div class="col-sm-12">
            <div class="card mb-3 p-4">
                <div class="row no-gutters row-bordered">
                    <div class="col-md-12 col-lg-12 col-xl-12">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-12 col-xl-12">
                                    <h5 class="mt-4"><strong><u>การตรวจสัญญาณชีพแรกรับ</u></strong></h5>
                                </div>
                                <div class="col-sm-12">
                                    <div class="row">
                                        <div class="col-sm-3">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text">Vital Sign : T</span>
                                                    </div>
                                                    <asp:TextBox ID="txtT_C" CssClass="form-control" placeholder="T/C" runat="server"></asp:TextBox>
                                                    <div class="input-group-append">
                                                        <span class="input-group-text">C</span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-3">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text">P</span>
                                                    </div>
                                                    <asp:TextBox ID="txtP_Min" CssClass="form-control" placeholder="P/Min" runat="server"></asp:TextBox>
                                                    <div class="input-group-append">
                                                        <span class="input-group-text">/min</span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-3">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text">R</span>
                                                    </div>
                                                    <asp:TextBox ID="txtR_Min" CssClass="form-control" placeholder="R/Min" runat="server"></asp:TextBox>
                                                    <div class="input-group-append">
                                                        <span class="input-group-text">/min</span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-3">
                                            <div class="form-group">
                                                <div class="form-group">
                                                    <div class="input-group">
                                                        <div class="input-group-prepend">
                                                            <span class="input-group-text">BP</span>
                                                        </div>
                                                        <asp:TextBox ID="txtBP_mmHg" CssClass="form-control" placeholder="BP/mmHg" runat="server"></asp:TextBox>
                                                        <div class="input-group-append">
                                                            <span class="input-group-text">mmHg</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-3">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text">O2 Sat</span>
                                                    </div>
                                                    <asp:TextBox ID="txtO2Sat_Percent" CssClass="form-control" placeholder="O2Sat/%" runat="server"></asp:TextBox>
                                                    <div class="input-group-append">
                                                        <span class="input-group-text">%</span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-3">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text">BW</span>
                                                    </div>
                                                    <asp:TextBox ID="txtBW_kg" CssClass="form-control" placeholder="BW/kg" runat="server"></asp:TextBox>
                                                    <div class="input-group-append">
                                                        <span class="input-group-text">Kg</span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-3">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text">HT</span>
                                                    </div>
                                                    <asp:TextBox ID="txtHT_Cm" CssClass="form-control" placeholder="HT/Cm" runat="server"></asp:TextBox>
                                                    <div class="input-group-append">
                                                        <span class="input-group-text">Cm</span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-3">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text">BMI Index</span>
                                                    </div>
                                                    <asp:TextBox ID="txtBMI_Index" CssClass="form-control" placeholder="BMI/Index" runat="server"></asp:TextBox>
                                                    <div class="input-group-append">
                                                        <span class="input-group-text"></span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row page-break">
                                <div class="col-lg-12 col-xl-12">
                                    <h5 class="mt-4"><strong><u>รายละเอียด</u></strong></h5>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col-sm-12">
                                    <div class="form-group">
                                        <asp:TextBox ID="txtDescription" CssClass="form-control form-control-sm " placeholder="รายละเอียด" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <asp:LinkButton ID="lbnBack" runat="server" class="btn btn-lg btn-secondary" OnClick="lbnBack_Click">Back</asp:LinkButton>
                            <asp:LinkButton ID="lbnSave" runat="server" class="btn btn-lg btn-success" OnClick="lbnSave_Click">Save</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ModalPlaceHolder" runat="server">
</asp:Content>
