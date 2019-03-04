<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AnomaERP.login" %>

<!DOCTYPE html>

<html lang="en" class="default-style">
<head>
    <title>ANOMA</title>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="IE=edge,chrome=1">
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0">
    <link rel="icon" type="image/x-icon" href="/favicon.ico">

    <link href="https://fonts.googleapis.com/css?family=Roboto:300,300i,400,400i,500,500i,700,700i,900" rel="stylesheet">
    <%--<link rel="icon" type="image/x-icon" href="http://www.comseven.com/wp-content/uploads/2016/11/fav-Logo-com7-01.png">--%>

    <!-- Icon fonts -->
    <link rel="stylesheet" href="/assets/vendor/fonts/fontawesome.css">
    <link rel="stylesheet" href="/assets/vendor/fonts/ionicons.css">
    <link rel="stylesheet" href="/assets/vendor/fonts/linearicons.css">
    <link rel="stylesheet" href="/assets/vendor/fonts/open-iconic.css">
    <link rel="stylesheet" href="/assets/vendor/fonts/pe-icon-7-stroke.css">

    <!-- Core stylesheets -->
    <link rel="stylesheet" href="/assets/vendor/css/bootstrap-material.css" class="theme-settings-bootstrap-css">
    <link rel="stylesheet" href="/assets/vendor/css/appwork-material.css" class="theme-settings-appwork-css">
    <link rel="stylesheet" href="/assets/vendor/css/theme-corporate-material.css" class="theme-settings-theme-css">
    <link rel="stylesheet" href="/assets/vendor/css/colors-material.css" class="theme-settings-colors-css">
    <link rel="stylesheet" href="/assets/vendor/css/uikit.css">
    <link rel="stylesheet" href="/assets/css/demo.css">

    <script src="/assets/vendor/js/material-ripple.js"></script>
    <script src="/assets/vendor/js/layout-helpers.js"></script>

    <!-- Core scripts -->
    <script src="/assets/vendor/js/pace.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="/assets/js/bootbox.js"></script>
    <script src="/assets/js/custom.js" type="text/javascript"></script>

    <!-- Libs -->
    <link rel="stylesheet" href="/assets/vendor/libs/photoswipe/photoswipe.css">
    <link rel="stylesheet" href="/assets/vendor/libs/bootstrap-datepicker/bootstrap-datepicker.css">
    <link rel="stylesheet" href="/assets/vendor/libs/bootstrap-daterangepicker/bootstrap-daterangepicker.css">
    <link rel="stylesheet" href="/assets/vendor/libs/bootstrap-material-datetimepicker/bootstrap-material-datetimepicker.css">
    <link rel="stylesheet" href="/assets/vendor/libs/timepicker/timepicker.css">
    <link rel="stylesheet" href="/assets/vendor/libs/perfect-scrollbar/perfect-scrollbar.css">
    <link rel="stylesheet" href="/assets/vendor/libs/datatables/datatables.css">
    <link rel="stylesheet" href="/assets/vendor/libs/dropzone/dropzone.css">
    <link rel="stylesheet" href="/assets/vendor/libs/bootstrap-sweetalert/bootstrap-sweetalert.css">
    <link rel="stylesheet" href="/assets/css/custom.css">
</head>
<body>

    <div class="page-loader">
        <div class="bg-primary"></div>
    </div>
    <!-- Nav -->
    <nav class="navbar navbar-expand-lg bg-white">
        <div class="container">
            <a href="javascript:void(0);" class="navbar-brand text-large font-weight-bolder line-height-1 py-2">
                <i class="ion ion-md-trending mr-2"></i>Anoma Health Care
            </a>

            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#header-3">
                <span class="navbar-toggler-icon"></span>
            </button>
            <!-- <div class="collapse navbar-collapse" id="header-3">
                <div class="navbar-nav ml-auto">
                    <a class="nav-item nav-link active" href="javascript:void(0)">Login</a>
                    <a class="nav-item nav-link" href="javascript:void(0)">Features</a>
                    <a class="nav-item nav-link" href="javascript:void(0)">Pricing</a>
                    <a class="nav-item nav-link" href="javascript:void(0)">About&nbsp;Us</a>
                </div>
            </div> -->
        </div>
    </nav>
    <!-- / Nav -->
    <!-- Article's primary image -->
    <div class="ui-rect ui-rect-5 ui-bg-cover mb-5" style="background-color: darkgrey;">
        <div class="row no-gutters">
            <div class="col-md-3 ml-md-auto mr-md-auto">
                <div class="authentication-inner py-5">
                    <div class="card bg-white-95 ">
                        <div class="p-4">
                            <!-- Form -->
                            <form runat="server">
                                <div class="form-group">
                                    <label class="form-label">Username</label>
                                    <asp:TextBox ID="txtUsername" class="form-control" runat="server" />
                                </div>
                                <div class="form-group">
                                    <label class="form-label d-flex justify-content-between align-items-end">
                                        <div>Password</div>
                                    </label>
                                    <asp:TextBox ID="txtPassword" TextMode="Password" class="form-control" runat="server" />
                                </div>

                                <div class="d-flex justify-content-between align-items-center m-0 pull-right">
                                    <%-- <label class="custom-control custom-checkbox m-0">
                                        <input type="checkbox" class="custom-control-input">
                                        <span class="custom-control-label">Remember me</span>
                                    </label>--%>
                                    <asp:LinkButton ID="btnSignin" CssClass="btn btn-primary" OnClick="btnSignin_Click" runat="server">Sign In</asp:LinkButton>

                                </div>
                            </form>
                            <!-- / Form -->
                        </div>
                        <%--<div class="card-footer">
                            <div class="text-center text-muted">
                                Don't have an account yet? <a href="javascript:void(0)">Sign Up</a>
                            </div>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Footer -->
    <nav class="footer bg-white">
        <div class="container text-center py-3">
            <!-- <div class="pb-3">
                <a href="javascript:void(0)" class="footer-link pt-3">About Us</a>
                <a href="javascript:void(0)" class="footer-link pt-3 ml-4">Help</a>
                <a href="javascript:void(0)" class="footer-link pt-3 ml-4">Contact</a>
                <a href="javascript:void(0)" class="footer-link pt-3 ml-4">Terms & Conditions</a>
            </div> -->
            <!--
                        <div class="col-md-9 col-lg-7 col-xl-6 px-0 my-4 mx-auto">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam
                            vulputate commodo justo, a malesuada magna interdum sodales.
                            Vestibulum bibendum fermentum tortor, eu blandit orci porta quis.
                        </div> -->
            <div class="pb-3">
                <span class="footer-text font-weight-bolder">Anoma Health Care</span> ©
            </div>
        </div>
    </nav>
    <!-- / Footer -->
    <!-- Core scripts -->
    <script src="/assets/vendor/libs/popper/popper.js"></script>
    <script src="/assets/vendor/js/bootstrap.js"></script>
    <script src="/assets/vendor/js/sidenav.js"></script>

    <!-- Libs -->
    <script src="/assets/vendor/libs/perfect-scrollbar/perfect-scrollbar.js"></script>
    <script src="/assets/vendor/libs/photoswipe/photoswipe.js"></script>
    <script src="/assets/vendor/libs/datatables/datatables.js"></script>
    <script src="/assets/js/dataTables.checkboxes.min.js"></script>
    <script src="/assets/js/ui_button-groups.js"></script>
    <script src="/assets/js/ui_modals.js"></script>
    <script src="/assets/vendor/libs/moment/moment.js"></script>
    <script src="/assets/vendor/libs/bootstrap-datepicker/bootstrap-datepicker.js"></script>
    <script src="/assets/vendor/libs/bootstrap-daterangepicker/bootstrap-daterangepicker.js"></script>
    <script src="/assets/vendor/libs/bootstrap-material-datetimepicker/bootstrap-material-datetimepicker.js"></script>
    <script src="/assets/vendor/libs/timepicker/timepicker.js"></script>

    <!-- Demo -->
    <script src="/assets/js/forms_pickers.js"></script>
    <script src="/assets/js/demo.js"></script>
    <script src="/assets/js/tables_datatables.js"></script>
    <%--<script src="/assets/js/dashboards_dashboard-1.js"></script>--%>
    <script src="/assets/vendor/libs/bootstrap-sweetalert/bootstrap-sweetalert.js"></script>
    <script src="/assets/js/ui_lightbox.js"></script>

    <%--    <script type="text/javascript">
        function showProgress() {
            document.getElementById('<%= UpdateProgress1.ClientID  %>').style.display = "block";
        }
        function hideProgress() {
            document.getElementById('<%= UpdateProgress1.ClientID  %>').style.display = "none";
        }
    </script>--%>
</body>

</html>
