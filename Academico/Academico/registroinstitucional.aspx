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
    <form id="form1" runat="server">
        <div class="container body">
            <div class="main_container">
                <div class="col-md-3 left_col">
                    <div class="left_col scroll-view">
                        <div class="navbar nav_title" style="border: 0;">
                            <a href="index.html" class="site_title"><i class="fa fa-graduation-cap"></i><span>Análisis Acádemico!</span></a>
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
                                <div class="form-horizontal form-label-left input_mask">

                                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                        <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control has-feedback-left" placeholder="No. de Matricula" required="required" TextMode="Number"></asp:TextBox>
                                        <span class="fa fa-user form-control-feedback left" aria-hidden="true"></span>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                        <asp:TextBox ID="txtSemestre" runat="server" CssClass="form-control" placeholder="Semestre Actual" TextMode="Number" required="required"></asp:TextBox>
                                        <span class="fa fa-pencil form-control-feedback right" aria-hidden="true"></span>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control has-feedback-left" placeholder="Nombre Completo" required="required" pattern="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+"></asp:TextBox>
                                        <span class="fa fa-user form-control-feedback left" aria-hidden="true"></span>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                        <asp:TextBox ID="txtApellidoPaterno" runat="server" CssClass="form-control" placeholder="Apellido Paterno" required="required" pattern="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+"></asp:TextBox>
                                        <span class="fa  fa-mouse-pointer form-control-feedback right" aria-hidden="true"></span>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                        <asp:TextBox ID="txtApellidoMaterno" runat="server" CssClass="form-control" placeholder="Apellido Materno" required="required" pattern="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+"></asp:TextBox>
                                        <span class="fa  fa-mouse-pointer form-control-feedback right" aria-hidden="true"></span>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="email" TextMode="Email" required="required"></asp:TextBox>
                                        <span class="fa fa-envelope form-control-feedback right" aria-hidden="true"></span>
                                    </div>

                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Telefono Celular:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtTelefonoCelular" runat="server" CssClass="form-control" placeholder="Telefono Celular" TextMode="Phone"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Plan Educativo:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:DropDownList ID="ddlCarrera" runat="server" placeholder="Carrera" CssClass="form-control" required="required">
                                                <asp:ListItem>
                                            Seleccionar
                                                </asp:ListItem>
                                            </asp:DropDownList>

                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Plan de Estudios:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtPlanEstudios" runat="server" placeholder="Plan de Estudios" CssClass="form-control" required="required" pattern="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+"></asp:TextBox>
                                            <span class="fa  fa-folder-o form-control-feedback right" aria-hidden="true"></span>
                                        </div>
                                    </div>

                                    <div class="ln_solid"></div>
                                    <div class="form-group">
                                        <div class="form-horizontal form-label-left input_mask" >
                                        <div class="x_title">
                                            <h2><span><i class="fa fa-user-plus"></i></span>Cuenta de Usuario<small></small>Datos de Tu Cuenta de Acceso</h2>
                                            <%--<ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="#">Herramientas</a>
                                        </li>
                                        <li><a href="#"><span><i class="fa fa-user"></i></span>  Login</a>
                                        </li>
                                    </ul>
                                </li>
                                <li><a class="close-link"><i class="fa fa-close"></i></a>
                                </li>
                            </ul>--%>
                                            <div class="clearfix"></div>
                                        </div>
                                        <div class="x_content">
                                            <div class="form-group">
                                                <label class="control-label col-md-3 col-sm-3 col-xs-12">Nombre de Usuario:</label>
                                                 <div class="col-md-9 col-sm-9 col-xs-12">
                                                <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control" placeholder="Nombre de Usuario" required="required"></asp:TextBox>
                                                <span class="fa fa-user form-control-feedback right" aria-hidden="true"></span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label col-md-3 col-sm-3 col-xs-12">Password:</label>
                                                 <div class="col-md-9 col-sm-9 col-xs-12">
                                                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password" required="required"></asp:TextBox>
                                                <span class="fa fa-eye-slash form-control-feedback right" aria-hidden="true"></span>
                                                </div>
                                            </div>
                                        </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-5 col-sm-5 col-xs-12 col-md-offset-7">
                                            <button class="btn btn-primary" type="reset">Regresar</button>
                                            <button type="submit" class="btn btn-success">Submit</button>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>

                    </div>
                    <div class="col-md-6 col-xs-12">
                        <div class="x_panel">
                            <div class="x_title">
                                <h2>Creditos<small>Cursados hasta el momento</small></h2>
                                <ul class="nav navbar-right panel_toolbox">
                                    <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                    </li>
                                    <li class="dropdown">
                                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                        <ul class="dropdown-menu" role="menu">
                                            <li><a href="#">Herramientas</a>
                                            </li>
                                            <li><a href="#"><span><i class="fa fa-user"></i></span>Login</a>
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
                                <div class="form-horizontal form-label-left input_mask" id="form2">
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Creditos Aprobados:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtCreditosAprobados" runat="server" placeholder="Creditos Aprobados" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                            <span class="fa fa-pencil form-control-feedback right" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Creditos Totales:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtCreditosTotales" runat="server" placeholder="Creditos Totales" CssClass="form-control" required="required" TextMode="Number">
                                            </asp:TextBox>
                                            <span class="fa fa-pencil form-control-feedback right" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Creditos Reprobados:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtCreditosReprobados" runat="server" placeholder="Plan de Estudios" CssClass="form-control" required="required" TextMode="Number"></asp:TextBox>
                                            <span class="fa fa-pencil form-control-feedback right" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6 col-xs-12">
                        <div class="x_panel">
                            <div class="x_title">
                                <h2>Asignaturas<small>Cursados hasta el momento</small></h2>
                                <ul class="nav navbar-right panel_toolbox">
                                    <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                    </li>
                                    <li class="dropdown">
                                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                        <ul class="dropdown-menu" role="menu">
                                            <li><a href="#">Herramientas</a>
                                            </li>
                                            <li><a href="#"><span><i class="fa fa-user"></i></span>Login</a>
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
                                <div class="form-horizontal form-label-left input_mask">
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Asignaturas Totales:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtAsignaturasTotales" runat="server" placeholder="Asignaturas Totales" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                            <span class="fa fa-pencil form-control-feedback right" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Asignaturas Aprobadas:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtAsignaturasAprobadas" runat="server" placeholder="Asignaturas Aprobadas" CssClass="form-control" required="required" TextMode="Number">
                                            </asp:TextBox>
                                            <span class="fa fa-pencil form-control-feedback right" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Asignaturas Cursadas:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtAsignaturasCursadas" runat="server" placeholder="Asignaturas Cursadas" CssClass="form-control" required="required" TextMode="Number"></asp:TextBox>
                                            <span class="fa fa-pencil form-control-feedback right" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Asignaturas Reprobadas:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtAsignaturasReprobadas" runat="server" placeholder="Asignaturas Reprobadas" CssClass="form-control" required="required" TextMode="Number"></asp:TextBox>
                                            <span class="fa fa-exclamation form-control-feedback right" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Asignaturas en Repetición:</label>
                                        <div class="col-md-9 col-sm-9 col-xs-12">
                                            <asp:TextBox ID="txtAsignaturasRepetición" runat="server" placeholder="Asignaturas en Repetición" CssClass="form-control" required="required" TextMode="Number"></asp:TextBox>
                                            <span class="fa fa-exclamation form-control-feedback right" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

        </div>
    </form>
</body>
</html>
