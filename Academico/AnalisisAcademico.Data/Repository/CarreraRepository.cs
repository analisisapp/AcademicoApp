using AnalisisAcademico.Data.Infraestrucutra;
using AnalisisAcademico.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisAcademico.Data.Repository
{
    public class CarreraRepository: ICarreraRepository
    {
        private AnalisisAcademicoEntities contexto = new AnalisisAcademicoEntities();

        public CatCarrera GetConsultarCatCarrera(int idCarrera)
        {
            CatCarrera catCarrera = null;
            try
            {
                catCarrera = contexto.CatCarrera.Where(v => v.id == idCarrera).FirstOrDefault<CatCarrera>();
            }
            catch (Exception ex)
            {
                string errorMensaje = ex.Message;
              
            }

            return catCarrera;
        }
        public CatCarrera GetConsultarCatCarreraPorUsuario(int idUsuario)
        {
            CatCarrera catCarrera = null;
            try
            {
                SegUsuarios usuarios= contexto.SegUsuarios.
                    Where(p => p.id == idUsuario).FirstOrDefault<SegUsuarios>();
                catCarrera= contexto.CatCarrera.
                  Where(p => p.id == usuarios.idCarrera).FirstOrDefault<CatCarrera>();
            }
            catch (Exception ex)
            {

                string errorMensaje = ex.Message;
            }
            return catCarrera;
        }
    }
}
