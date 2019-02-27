<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="Academico.Alumno.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12 col-xs-12">

        <div class="x_panel">
            <div class="x_title">
                <h2>Datos Personales<small>perfil del alumno registrado</small></h2>
                <ul class="nav navbar-right panel_toolbox">
                    <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                    </li>
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                        <ul class="dropdown-menu" role="menu">
                            <li><a href="#">Editar</a>
                            </li>
                            <li><a href="#">Eliminar</a>
                            </li>
                        </ul>
                    </li>
                    <li><a class="close-link"><i class="fa fa-close"></i></a>
                    </li>
                </ul>
                <div class="clearfix"></div>
            </div>
            <div class="x_content">
                
                <div class="form-horizontal form-label-left input_mask">

                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre del Alumno" data-toggle="tooltip" data-placement="left" title="" data-original-title="Nombre del Alumno" ></asp:TextBox>
                        <span class="fa fa-user form-control-feedback right" aria-hidden="true"></span>
                    </div>

                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                        <asp:TextBox ID="txtApellidoPaterno" runat="server" CssClass="form-control" placeholder="Apellido del Alumno" data-toggle="tooltip" data-placement="left" title="" data-original-title="Apellido del Alumno" ></asp:TextBox>
                        <span class="fa fa-user form-control-feedback right" aria-hidden="true"></span>
                    </div>

                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                        <asp:TextBox ID="txtApellidoMaterno" runat="server" CssClass="form-control" placeholder="Apellido Materno del Alumno" data-toggle="tooltip" data-placement="left" title="" data-original-title="Apellido Materno del Alumno" ></asp:TextBox>
                        <span class="fa fa-user form-control-feedback right" aria-hidden="true"></span>
                    </div>

                    <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="email del alumno" data-toggle="tooltip" data-placement="left" title="" data-original-title="email" TextMode="Email" ></asp:TextBox>
                        <span class="fa fa-envelope-o form-control-feedback right" aria-hidden="true"></span>
                    </div>

                     <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                        <asp:TextBox ID="txtNumeroMatricula" runat="server" CssClass="form-control" placeholder="Numero de Matrícula" data-toggle="tooltip" data-placement="left" title="" data-original-title="Numero de Matricula" TextMode="Number" ></asp:TextBox>
                        <span class="fa fa-address-card-o form-control-feedback right" aria-hidden="true"></span>
                    </div>
                     <div class="col-md-6 col-sm-6 col-xs-12 form-group has-feedback">
                        <asp:TextBox ID="txtSemestreActual" runat="server" CssClass="form-control" placeholder="Semestre Actual" data-toggle="tooltip" data-placement="left" title="" data-original-title="Semestre Actual" TextMode="Number" Min="1" Max="15" ></asp:TextBox>
                        <span class="fa fa-archive form-control-feedback right" aria-hidden="true"></span>
                    </div>
                    <div class="ln_solid"></div>
                    <div class="form-group">
                        <div class="col-md-1 col-sm-1 col-xs-12 col-md-offset-10">
                            <%--<button type="button" class="btn btn-primary" data-toggle="modal" data-target=".bs-example-modal-lg">Large modal</button>
                            <button type="button" class="btn btn-primary">Cancel</button>
                            <button class="btn btn-primary" type="reset">Reset</button>--%>
                            <button type="submit" class="btn btn-success">Actualizar</button>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class="modal fade bs-example-modal-lg" tabindex="-1" role="dialog" aria-hidden="true">
                    <div class="modal-dialog modal-lg">
                      <div class="modal-content">

                        <div class="modal-header">
                          <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">×</span>
                          </button>
                          <h4 class="modal-title" id="myModalLabel">Modal title</h4>
                        </div>
                        <div class="modal-body">
                          <h4>Text in a modal</h4>
                          <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.</p>
                          <p>Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.</p>
                        </div>
                        <div class="modal-footer">
                          <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                          <button type="button" class="btn btn-primary">Save changes</button>
                        </div>

                      </div>
                    </div>
                  </div>


</asp:Content>
