using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnalisisAcademico.Data;
using System.Linq.Expressions;
using System.Data.Linq;
using AnalisisAcademico.Data.Model;

namespace AnalisisAcademico.Web.Control
{
    public class CtrlGeneric
    {
        public List<T> GetCatalogGenericEntity<T>() where T : class
        {
            List<T> lista = null;
            //using (var contexto = new AnalisisAcademicoEntities())
            //{
            //    lista = contexto.GetTable<T>().ToList<T>();
                
                
            //}
            return lista;
        }


       


    }
}
