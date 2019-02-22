using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AnalisisAcademico.Mail.Infraestructura;
using AnalisisAcademico.Mail.Dominio;

namespace Academico.Cuentas
{
    public partial class inicio_recuperacion_password : System.Web.UI.Page
    {
        private IEnviarMail enviarMail= null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            enviarMail = new EnviarNotificacionGmail();
            string mail = this.txtEmail.Text;
            enviarMail.enviarCorreo(mail, "Estamos Enviando tu password Nuevo");
          
        }
    }
}