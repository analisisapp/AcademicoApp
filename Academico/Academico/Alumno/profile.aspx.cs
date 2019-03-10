using Academico.Common;
using AnalisisAcademico.Data.Infraestructure;
using AnalisisAcademico.Data.Model;
using AnalisisAcademico.Web.Session;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academico.Alumno
{
    public partial class profile : System.Web.UI.Page
    {
        //establecemos la session del usuario
        private SessionManager sesionManager = null;
        [Dependency]
        public ISegUsuarioRepository segUsuarioRepository { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CtrlSession ctrlSession = new CtrlSession();
                ctrlSession.validaSession(this);
                sesionManager = (SessionManager)this.Session[Recursos.MANAGER];
                if(sesionManager.Parametros[Recursos.USER] != null)
                {
                    SegUsuarios segUser = (SegUsuarios)sesionManager.Parametros[Recursos.USER];
                    SegUsuarios segusuario = segUsuarioRepository.GetUsuarioById(segUser.id);
                    sesionManager.Parametros[Recursos.USER] = segusuario;
                    Session[Recursos.MANAGER] = sesionManager;
                    this.setVisibleDatosPerfil(segusuario);
                    this.setVisibleDatosPersonaPerfil(segusuario);
                }
            }
        }

        #region Metodo que se encarga de Establecer la foto dentro de la plataforma
        protected void setVisibleDatosPerfil(SegUsuarios segusuario)
        {
            if (segusuario == null)
            {
                this.ImgPerfilUsuario.ImageUrl = "~/imagenes/anonimo.jpg";
                //this.userAlumno.ImageUrl = "~/imagenes/invitado.jpg";
            }
            else
            {
                this.ImgPerfilUsuario.ImageUrl = "/Handler/vizualizarFoto.ashx?id=" + segusuario.id;
                //this.userAlumno.ImageUrl = "/Handler/vizualizarFoto.ashx?id=" + segusuario.id;
                //this.setVisibleDatosPersonaPerfil(segusuario);
            }
        }

        #endregion
        #region Metodo que se encarga de establecer los datos en la pantalla
        protected void setVisibleDatosPersonaPerfil(SegUsuarios segusuario)
        {

            string nombreCompleto = segusuario.strNombre + " " + segusuario.strAPaterno + " " + segusuario.strAMaterno;
            //this.etAlumno.Text = nombreCompleto;
            this.etNombreCompleto.Text = nombreCompleto;
            this.etNombre.Text = segusuario.strNombre;
            this.etApellidoPaterno.Text = segusuario.strAPaterno;
            this.etApellidoMaterno.Text = segusuario.strAMaterno;
            this.etSemestre.Text = segusuario.strSemestreActual;
            this.etMatricula.Text = segusuario.strMatricula;
            this.etMail.Text = segusuario.email;

        }
        #endregion


    }
}