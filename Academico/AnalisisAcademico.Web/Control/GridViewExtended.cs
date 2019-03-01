using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Data.Model;
using System.Collections;
namespace AnalisisAcademico.Web.Control
{
    public static class GridViewExtended
    {

        public static void getCatalgo<T>(this GridView _control, List<T> lista) where T:class
        {
            _control.DataSource = lista;
            _control.DataBind();
        }

        public static void getCatalogo(this GridView _control, IList lista)
        {
            _control.DataSource = lista;
            _control.DataBind();
        }
    }
}
