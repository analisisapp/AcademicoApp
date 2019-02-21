<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Academico.login" %>

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
</head>
<body class="login">

    <div>
        <a class="hiddenanchor" id="signup"></a>
        <a class="hiddenanchor" id="signin"></a>
        <div class="login_wrapper">
            <div class="animate form login_form">
                <section class="login_content">
                    <form id="form1" runat="server">
                        <h1>Login Académico</h1>
                        <div>
                            <asp:TextBox ID="txtMailUsuario" runat="server" CssClass="form-control" placeholder="Usuario o email " required="required" TextMode="Email"></asp:TextBox>
                            
                        </div>
                        <div>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" required="required" TextMode="Password"></asp:TextBox>
                            
                        </div>
                        <div>
                            <asp:Button ID="BtnLogin" runat="server" Text="Log in" CssClass="btn btn-default submit" />
                            <a class="reset_pass" href="Cuentas/inicio_recuperacion_password.aspx">Olvidaste tu Password?</a>
                        </div>

                        <div class="clearfix"></div>

                        <div class="separator">
                            <p class="change_link">
                                Nuevo en el Sitio?
                  <a href="registroinstitucional.aspx" class="to_register">Crea una Cuenta </a>
                            </p>

                            <div class="clearfix"></div>
                            <br />

                            <div>
                                <h1><i class="fa fa-graduation-cap"></i>Análisis Académico!</h1>
                                <p>©2016 All Rights Reserved. Htsoft-Mexico</p>
                            </div>
                        </div>
                    </form>
                </section>
            </div>

            <div id="register" class="animate form registration_form">
                <section class="login_content">

                    <h1>Create Account</h1>
                    <div>
                        <input type="text" class="form-control" placeholder="Username" required="" />
                    </div>
                    <div>
                        <input type="email" class="form-control" placeholder="Email" required="" />
                    </div>
                    <div>
                        <input type="password" class="form-control" placeholder="Password" required="" />
                    </div>
                    <div>
                        <a class="btn btn-default submit" href="index.html">Submit</a>
                    </div>

                    <div class="clearfix"></div>

                    <div class="separator">
                        <p class="change_link">
                            Already a member ?
                  <a href="#signin" class="to_register">Log in </a>
                        </p>

                        <div class="clearfix"></div>
                        <br />

                        <div>
                            <h1><i class="fa fa-paw"></i>Gentelella Alela!</h1>
                            <p>©2016 All Rights Reserved. Gentelella Alela! is a Bootstrap 3 template. Privacy and Terms</p>
                        </div>
                    </div>

                </section>
            </div>
        </div>
    </div>

</body>
</html>
