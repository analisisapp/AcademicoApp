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
using Unity.WebForms.Configuration;
using Unity;

namespace Academico
{
    public partial class login : System.Web.UI.Page
    {
        private SessionManager sesionManager = null;
        [Dependency]
        public ISegUsuarioRepository segUsuarioRepository { get; set; }
        private SegUsuarios segUsuarios = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Verificamos que sea la carga por primera vez en el login
            if (!IsPostBack)
            {
               
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtMailUsuario.Text; //obtenemos el nombre del usuario de la vista
            string password = txtPassword.Text; //obtenemos el password del usuario
            this.segUsuarios = segUsuarioRepository.GetUsuarioLogin(nombre, password); //vamos a validar al usuario
            
            //se valida que el usuario contenga el perfil del alumno
            if (this.segUsuarios != null && this.segUsuarios.SegPerfil.strValor.Equals(Recursos.PERFIL_ALUMNO))
            {
                this.sesionManager = new SessionManager();
                this.sesionManager.IdUsuario = this.segUsuarios.id;
                this.sesionManager.Parametros[Recursos.USER] = this.segUsuarios;
                Session[Recursos.MANAGER] = sesionManager;
                this.Response.Redirect("Alumno/perfil.aspx", true);
            }
            else
            {

            }
        }

       

    }
}