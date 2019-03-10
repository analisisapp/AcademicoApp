using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//cargamos el archivo de recurso
using Academico.Common;
using AnalisisAcademico.Data.Infraestructure;
//establecemos la libreria del modelo
using AnalisisAcademico.Data.Model;
using AnalisisAcademico.Web.Session;
//inyectamos la dependencia del objeto
using Microsoft.Practices.Unity;

namespace Academico.Alumno
{
    public partial class perfil : System.Web.UI.Page
    {
        //establecemos el objeto sesion en null
        private SessionManager sesionManager = null;
        [Dependency]
        public ISegUsuarioRepository segUsuarioRepository { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CtrlSession ctrlSession = new CtrlSession();//utilizamos la controladora de la sesion
                ctrlSession.validaSession(this);//validamos la sesion dentro del sistema
                sesionManager = (SessionManager)this.Session[Recursos.MANAGER];
                if (sesionManager.Parametros[Recursos.USER] != null)
                {
                    SegUsuarios segUser = (SegUsuarios)sesionManager.Parametros[Recursos.USER];///traemos al objeto segUsuario de la sesion
                    SegUsuarios segUsuario = segUsuarioRepository.GetUsuarioById(segUser.id); //consultamos que el usuario si esta en base de datos
                    //establezco los valores validados en la sesion
                    sesionManager.Parametros[Recursos.USER] = segUsuario;
                    Session[Recursos.MANAGER] = sesionManager;

                    //llamamos a el metodo que se encarga de poner los datos en la pantalla
                    this.setVisibleDatosPersonaPerfil(segUsuario);
                    this.setVisibleDatosPerfil(segUsuario);
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


        #region Metodo que se encarga de poner los datos en la pantalla
        protected void setVisibleDatosPersonaPerfil(SegUsuarios segusuario)
        {

            string nombreCompleto = segusuario.strNombre + " " + segusuario.strAPaterno + " " + segusuario.strAMaterno;
            this.etAlumno.Text = nombreCompleto;
            this.txtNombre.Text = segusuario.strNombre;
            this.txtApellidoPaterno.Text = segusuario.strAPaterno;
            this.txtApellidoMaterno.Text = segusuario.strAMaterno;
            this.txtEmail.Text = segusuario.email;
            this.txtNumeroMatricula.Text = segusuario.strMatricula;
            this.txtSemestreActual.Text = segusuario.strSemestreActual;
            

        }
        #endregion
    }
}