using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnalisisAcademico.Data;
using AnalisisAcademico.Data.Model;

namespace AnalisisAcademico.Web.Control
{
    public class HtmlHelper
    {
        public string ConsultarImagenCarrera()
        {
            
            StringBuilder htmlGeneric = new StringBuilder();
            htmlGeneric.Append("<img src='../../imagenes/ing_alimentarias.png' class='img-responsive img-rounded img-thumbnail' alt='Responsive image'>");
            return htmlGeneric.ToString();
        }

        public string ConsultarImagenCarrera(CatCarrera catCarrera)
        {
            
            StringBuilder htmlGeneric = new StringBuilder();
            htmlGeneric.Append("<img src='"+catCarrera.strUrlImg+"' class='img-responsive img-rounded img-thumbnail' alt='Responsive image'>");
            return htmlGeneric.ToString();
        }

        public string ConsultarImagenUsuarioPerfil(SegUsuarios segUsuario)
        {
            StringBuilder htmlGeneric = new StringBuilder();
            htmlGeneric.Append("<img src='"+segUsuario.foto+"' class='img-responsive img-rounded img-thumbnail' alt='Responsive image'>");
            return htmlGeneric.ToString();
        }

        public string ConsultarStarRegistro(bool registro)
        {
            StringBuilder htmlGeneric = new StringBuilder();

          
            if (registro == true)
            {
                for (int x = 0; x < 5; x++)
                {
                    htmlGeneric.Append("<span class='glyphicon glyphicon-star'></span>");
                }
                return htmlGeneric.ToString();
            }
            else
            {
                for (int x = 0; x < 1; x++)
                {
                    htmlGeneric.Append("<span class='glyphicon glyphicon-star-empty'></span>");
                }
                return htmlGeneric.ToString();
            }


        }



    }
}
