<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registroinstitucional.aspx.cs" Inherits="Academico.registroinstitucional" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Academico! | </title>
    <link href="Content/animate.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <link href="Content/nprogress.css" rel="stylesheet" />
    <link href="Content/custom.min.css" rel="stylesheet" />
    <link href="Content/green.css" rel="stylesheet" />
    <link href="Content/prettify.min.css" rel="stylesheet" />
    <link href="Content/select2.min.css" rel="stylesheet" />
    <link href="Content/switchery.css" rel="stylesheet" />
    <link href="Content/starrr.css" rel="stylesheet" />
    <link href="Content/daterangepicker.css" rel="stylesheet" />
    <link href="Content/custom.min.css" rel="stylesheet" />
    <script src="Scripts/jquery.min.js"></script>

    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/fastclick.js"></script>
    <script src="Scripts/nprogress.js"></script>
    <script src="Scripts/bootstrap-progressbar.min.js"></script>
    <script src="Scripts/icheck.min.js"></script>
    <script src="Scripts/moment.js"></script>
    <script src="Scripts/daterangepicker.js"></script>
    <script src="Scripts/bootstrap-wysiwyg.min.js"></script>
    <script src="Scripts/jquery.hotkeys.js"></script>
    <script src="Scripts/prettify.js"></script>
    <script src="Scripts/jquery.tagsinput.js"></script>
    <script src="Scripts/switchery.min.js"></script>
    <script src="Scripts/select2.min.js"></script>
    <script src="Scripts/parsley.min.js"></script>
    <script src="Scripts/autosize.min.js"></script>
    <script src="Scripts/jquery.autocomplete.min.js"></script>
    <script src="Scripts/starrr.js"></script>
    <script src="Scripts/custom.min.js"></script>
</head>
<body class="nav-md">
    <div class="container body">
        <div class="main_container">
            <div class="col-md-3 left_col">
                <div class="left_col scroll-view">
                    <div class="navbar nav_title" style="border: 0;">
                        <a href="index.html" class="site_title"><i class="fa fa-paw"></i><span>Análisis Acádemico!</span></a>
                    </div>

                    <div class="clearfix"></div>

                    <!-- menu profile quick info -->
                    <div class="profile clearfix">
                        <div class="profile_pic">
                            <img src="Imagenes/anonimo.jpg" alt="..." class="img-circle profile_img" />
                        </div>
                        <div class="profile_info">
                            <span>Bienvenido,</span>
                            <h2>Registrate</h2>
                        </div>
                    </div>
                    <!-- /menu profile quick info -->

                    <br />
                </div>

<%--                 <!-- sidebar menu -->
            <div id="sidebar-menu" class="main_menu_side hidden-print main_menu">
                <div class="menu_section active">
                    <h3>General</h3>
                    <ul class="nav side-menu" style="">
                        <li><a><i class="fa fa-home"></i>Login<span class="fa fa-chevron-down"></span></a>
                            <ul class="nav child_menu">
                                <li><a href="index.html">Dashboard</a></li>
                                <li><a href="index2.html">Dashboard2</a></li>
                                <li><a href="index3.html">Dashboard3</a></li>
                            </ul>
                        </li>
                </div>

            </div>
--%>

            </div>
           
            <div class="right_col" role="main" style="min-height: 7010px;">
            <div class="col-md-6 col-xs-12">
                <div class="x_panel">
                    <div class="x_title">
                        <h2>Registro<small>Datos personales del Alumno</small></h2>
                        <ul class="nav navbar-right panel_toolbox">
                            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                <ul class="dropdown-menu" role="menu">
                                    <li><a href="#">Herramientas</a>
                                    </li>
                                    <li><a href="#">Login</a>
                                    </li>
                                </ul>
                            </li>
                            <li><a class="close-link"><i class="fa fa-close"></i></a>
                            </li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <br />
                        <form class="form-horizontal form-label-left input_mask" id="form1" runat="server">

                            <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control has-feedback-left" placeholder="No. de Matricula"></asp:TextBox>
                                <span class="fa fa-user form-control-feedback left" aria-hidden="true"></span>
                            </div>

                            <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                <input type="text" class="form-control" id="inputSuccess3" placeholder="Last Name">
                                <span class="fa fa-user form-control-feedback right" aria-hidden="true"></span>
                            </div>

                            <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                <input type="text" class="form-control has-feedback-left" id="inputSuccess4" placeholder="Email">
                                <span class="fa fa-envelope form-control-feedback left" aria-hidden="true"></span>
                            </div>

                            <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                <input type="text" class="form-control" id="inputSuccess5" placeholder="Phone">
                                <span class="fa fa-phone form-control-feedback right" aria-hidden="true"></span>
                            </div>

                            <div class="form-group">
                                <label class="control-label col-md-3 col-sm-3 col-xs-12">Default Input</label>
                                <div class="col-md-9 col-sm-9 col-xs-12">
                                    <input type="text" class="form-control" placeholder="Default Input">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="control-label col-md-3 col-sm-3 col-xs-12">Disabled Input </label>
                                <div class="col-md-9 col-sm-9 col-xs-12">
                                    <input type="text" class="form-control" disabled="disabled" placeholder="Disabled Input">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="control-label col-md-3 col-sm-3 col-xs-12">Read-Only Input</label>
                                <div class="col-md-9 col-sm-9 col-xs-12">
                                    <input type="text" class="form-control" readonly="readonly" placeholder="Read-Only Input">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="control-label col-md-3 col-sm-3 col-xs-12">
                                    Date Of Birth <span class="required">*</span>
                                </label>
                                <div class="col-md-9 col-sm-9 col-xs-12">
                                    <input class="date-picker form-control col-md-7 col-xs-12" required="required" type="text">
                                </div>
                            </div>
                            <div class="ln_solid"></div>
                            <div class="form-group">
                                <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                                    <button type="button" class="btn btn-primary">Cancel</button>
                                    <button class="btn btn-primary" type="reset">Reset</button>
                                    <button type="submit" class="btn btn-success">Submit</button>
                                </div>
                            </div>

                        </form>
                    </div>
                </div>

            </div>
        </div>
        </div>
        
    </div>
</body>
</html>
