<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio_recuperacion_password.aspx.cs" Inherits="Academico.Cuentas.inicio_recuperacion_password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Análisis Acádemico!| </title>

    <link href="../Content/animate.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/font-awesome.min.css" rel="stylesheet" />
    <link href="../Content/nprogress.css" rel="stylesheet" />
    <link href="../Content/custom.min.css" rel="stylesheet" />
    <link href="../Content/green.css" rel="stylesheet" />
    <link href="../Content/prettify.min.css" rel="stylesheet" />
    <link href="../Content/select2.min.css" rel="stylesheet" />
    <link href="../Content/switchery.css" rel="stylesheet" />
    <link href="../Content/starrr.css" rel="stylesheet" />
    <link href="../Content/daterangepicker.css" rel="stylesheet" />
    <link href="../Content/custom.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/fastclick.js"></script>
    <script src="../Scripts/nprogress.js"></script>
    <script src="../Scripts/bootstrap-progressbar.min.js"></script>
    <script src="../Scripts/icheck.min.js"></script>
    <script src="../Scripts/moment.js"></script>
    <script src="../Scripts/daterangepicker.js"></script>
    <script src="../Scripts/bootstrap-wysiwyg.min.js"></script>
    <script src="../Scripts/jquery.hotkeys.js"></script>
    <script src="../Scripts/prettify.js"></script>
    <script src="../Scripts/jquery.tagsinput.js"></script>
    <script src="../Scripts/switchery.min.js"></script>
    <script src="../Scripts/select2.min.js"></script>
    <script src="../Scripts/parsley.min.js"></script>
    <script src="../Scripts/autosize.min.js"></script>
    <script src="../Scripts/jquery.autocomplete.min.js"></script>
    <script src="../Scripts/starrr.js"></script>
    <script src="../Scripts/custom.min.js"></script>
</head>
<body class="nav-md">
    <form id="form1" runat="server">
        <div class="container body">
            <div class="main_container">
                <div class="col-md-3 left_col">
                    <div class="left_col scroll-view">
                        <div class="navbar nav_title" style="border: 0;">
                            <a href="#" class="site_title"><i class="fa fa-graduation-cap"></i><span>Análisis Acádemico!</span></a>
                        </div>

                        <div class="clearfix"></div>

                        <!-- menu profile quick info -->
                        <div class="profile clearfix">
                            <div class="profile_pic">
                                <img src="../Imagenes/anonimo.jpg" alt="..." class="img-circle profile_img" />
                            </div>
                            <div class="profile_info">
                                <span>Bienvenido,</span>
                                <h2>Recuperación de Cuentas</h2>
                            </div>
                        </div>
                        <!-- /menu profile quick info -->

                        <br />
                    </div>


                </div>
                <div class="right_col" role="main" style="min-height: 7010px;">
                    <div class="col-md-8 col-xs-12">
                         <div class="x_panel">
                             <div class="x_title">
                                <h2>Recuperación<small>de Cuentas o contraseñas</small></h2>
                                <ul class="nav navbar-right panel_toolbox">
                                    <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                    </li>
                                    <li class="dropdown">
                                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                        <ul class="dropdown-menu" role="menu">
                                            <li><a href="#"><span><i class="fa fa-edit (alias)"></i> </span> Registro</a>
                                            </li>
                                            <li><a href="#"><span><i class="fa fa-user"></i> </span> Login</a>
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
                                    <h2>Encuentra tu cuenta <strong>Aqui</strong></h2>
                                    <p>Ingresa tu correo electrónico, número de teléfono o nombre de usuario.</p>
                                    <div class="col-md-8 col-sm-8 col-xs-12 form-group has-feedback">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control has-feedback-left" placeholder="tu correo electrónico" required="required" TextMode="Email"></asp:TextBox>
                                        <span class="fa  fa-envelope form-control-feedback left" aria-hidden="true"></span>
                                    </div>
                                    <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="BtnBuscar_Click" />
                                    
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
