using AnalisisAcademico.Data.Infraestructure;
using AnalisisAcademico.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisAcademico.Data.Repository
{
    public class RepositorySegPersonalAdministrativo: ISegPersonalAdministrativoRepository
    {
        private AnalisisAcademicoEntities contexto = new AnalisisAcademicoEntities();

        public bool InsertarPersonalAdministrativo(SegPersonalAdministrativo segPersonalAdministrativo)
        {
            bool respuesta = false;
            try
            {
                contexto.SegPersonalAdministrativo.Add(segPersonalAdministrativo);
                contexto.SaveChanges();
                respuesta = true;
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
                throw;
            }
            return respuesta;
        }

        public bool ValidarRegistroUsuarioAdministrativo(SegPersonalAdministrativo segPersonalAdministrativo)
        {
            bool respuesta = false;
            try
            {
                SegPersonalAdministrativo administrativo = contexto.SegPersonalAdministrativo.Where(p => p.strNombreUsuario == segPersonalAdministrativo.strNombreUsuario).FirstOrDefault<SegPersonalAdministrativo>();
                if (administrativo.id > 0)
                {
                    respuesta = true;
                }

            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;

            }
            return respuesta;
        }

        public SegPersonalAdministrativo ValidarLoginAdministrativo(string nombre, string password)
        {
            SegPersonalAdministrativo administrativo = null;
            try
            {
                administrativo = contexto.SegPersonalAdministrativo.Where(p => p.strNombreUsuario == nombre && p.strPassword == password).FirstOrDefault<SegPersonalAdministrativo>();

            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return administrativo;
        }

        public SegPersonalAdministrativo consultarUsuarioByIdAdministrativo(int id)
        {
            SegPersonalAdministrativo administrativo = null;
            try
            {
                administrativo = contexto.SegPersonalAdministrativo.Where(p => p.id == id).FirstOrDefault<SegPersonalAdministrativo>();
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return administrativo;
        }
    }
}
