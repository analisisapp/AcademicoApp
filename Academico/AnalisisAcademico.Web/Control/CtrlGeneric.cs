using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnalisisAcademico.Data;
using System.Linq.Expressions;
using System.Data.Linq;
using AnalisisAcademico.Data.Model;
using System.Data.Entity;

namespace AnalisisAcademico.Web.Control
{
    public class CtrlGeneric :DbContext
    {
        public List<T> GetCatalogGenericEntity<T>() where T : class
        {
            List<T> lista = null;
            using (var contexto = new AnalisisAcademicoEntities())
            {
                
                lista = contexto.Set<T>().ToList<T>();
                
            }
            return lista;
        }


       


    }
}
