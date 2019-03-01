using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AnalisisAcademico.Web.Session
{
    public class SessionManager
    {
        private Hashtable parametros;
        public int IdUsuario { set; get; }

        public Hashtable Parametros
        {
            get
            {
                if (parametros == null)
                {
                    parametros = new Hashtable();
                }
                return parametros;
            }
            set { parametros = value; }
        }
    }
}
