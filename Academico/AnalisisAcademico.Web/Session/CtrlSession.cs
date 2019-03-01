using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///cargamos la libreria  que tiene que ver con la sesion
using System.Web.SessionState;
using System.Web;
using System.Web.UI;

namespace AnalisisAcademico.Web.Session
{
    public class CtrlSession
    {
        public void validaSession(System.Web.UI.Page _page)
        {
            HttpSessionState session = _page.Session;

            if (session == null)
            {
                _page.Response.Redirect("login.aspx", true);
            }
            else
            {
                if (session["manager"] == null)
                {
                    _page.Response.Redirect("login.aspx", false);
                }
            }
        }

        public bool validarSession(System.Web.UI.Page _page)
        {
            HttpSessionState session = _page.Session;
            bool respuesta = true;
            if (session == null)
            {
                respuesta = false;
            }
            else
            {
                if (session["manager"] == null)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }



        public bool validarPerfilUsuario(string perfil)
        {
            bool respuesta = false;
            if (perfil.Equals("Alumno"))
            {
                respuesta = true;
            }
            return respuesta;
        }

        public void imprimirMensajePantalla(Page _page)
        {
            _page.ClientScript.RegisterClientScriptBlock(_page.GetType(),
                "ClientScript", "<script type='text/javascript'> $(function(){ $('#dlgResultado').dialog({ modal: true, resizable: false, autoOpen: true, draggable: false, open: function(type, data){$(this).parent().appendTo('form')} }); }); </script>");
        }
        
        public void MensajePantalla(System.Web.UI.Page _page)
        {
            _page.ClientScript.RegisterClientScriptBlock(_page.GetType(), "myModal", "$('#myMensaje').modal({keyboard: false});", true);
        }

        public string MensajePantalla(string mensaje)
        {
            StringBuilder JQueryMensaje = new StringBuilder();
            JQueryMensaje.Append("<script>");
            JQueryMensaje.Append("function mensaje() {");
            JQueryMensaje.Append("$.growl.error({ message: '" + mensaje + "' });");
            JQueryMensaje.Append(" };");
            JQueryMensaje.Append("</script>");
            return JQueryMensaje.ToString();
        }


    }
}
