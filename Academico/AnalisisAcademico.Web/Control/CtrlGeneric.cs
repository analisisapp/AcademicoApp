using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Model;
using System.Linq.Expressions;
using System.Data.Linq;

namespace AnalisisAcademico.Web.Control
{
    public class CtrlGeneric
    {
        public List<T> GetCatalogGenericEntity<T>() where T : class
        {
            List<T> lista = null;
            using (var contexto = new dcAnalisisAcademicoDataContext())
            {
                lista = contexto.GetTable<T>().ToList<T>();

                
            }
            return lista;
        }


       


    }
}
