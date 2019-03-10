<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Academico.Alumno.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#Mymodal").modal('show')
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="modal fade" tabindex="-1" role="dialog" id="Mymodal" data-backdrop="static" data-keyboard="false">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header" style="background-color: #46ABA2; color: white;">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">
                        <asp:Label ID="etNombreCompleto" runat="server" Text="" CssClass="fonts-title"></asp:Label>
                    </h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-3 col-lg-3">
                            <asp:Image ID="ImgPerfilUsuario" runat="server" CssClass="img-rounded img-responsive" alt="User Pic" />
                        </div>
                        <div class=" col-md-9 col-lg-9 ">
                                <table class="table table-user-information">
                                    <tbody>
                                        <tr>
                                            <td class="fonts-text">Nombre:</td>
                                            <td>
                                                <asp:Label ID="etNombre" runat="server" CssClass="fonts-text"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fonts-text">Apellido Paterno:</td>
                                            <td>
                                                <asp:Label ID="etApellidoPaterno" runat="server" CssClass="fonts-text"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fonts-text">Apellido Materno:</td>
                                            <td>
                                                <asp:Label ID="etApellidoMaterno" runat="server" CssClass="fonts-text"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fonts-text">email:</td>
                                            <td>
                                                <asp:Label ID="etMail" runat="server" CssClass="fonts-text"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td class="fonts-text">Numero de Matricula:</td>
                                            <td>
                                                <asp:Label ID="etMatricula" runat="server" CssClass="fonts-text"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td class="fonts-text">Semestre Actual:</td>
                                            <td>
                                                <asp:Label ID="etSemestre" runat="server" CssClass="fonts-text"></asp:Label>
                                            </td>
                                        </tr>
                                       

                                    </tbody>
                                </table>

                                
                                <a href="perfil.aspx" class="btn btn-sm btn-info">Actualizar Datos</a>
                                <button type="button" class="btn btn-sm btn-success" data-dismiss="modal">Salir</button>
                            </div>
                    </div>
                    
                    <%--<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>--%>
                </div>
                <div class="modal-footer">
                    <asp:Image runat="server" ID="imgFooter" alt="" CssClass="img-responsive img-thumbnail" ImageUrl="~/Imagenes/FooterOficial.png" />
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
</asp:Content>
