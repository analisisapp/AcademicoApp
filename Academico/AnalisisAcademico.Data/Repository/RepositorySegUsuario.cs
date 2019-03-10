using AnalisisAcademico.Data.Infraestructure;
using AnalisisAcademico.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace AnalisisAcademico.Data.Repository
{
    public class RepositorySegUsuario:ISegUsuarioRepository
    {
        private AnalisisAcademicoEntities contexto = new AnalisisAcademicoEntities();

        /// <summary>
        /// este metodo busca a un usuario de acuerdo a un nombre de  usuario y un password.
        /// </summary>
        /// <param name="nombre">el nombre del usuario</param>
        /// <param name="password">el password del usuario</param>
        /// <returns>regresa un segusuario</returns>
        public SegUsuarios GetUsuarioLogin(string nombre, string password)
        {
            SegUsuarios segusuario = null;
            try
            {
                Expression<Func<SegUsuarios, bool>> predicado = p => p.email == nombre && p.strPassword == password;
                segusuario = contexto.SegUsuarios.Where(predicado.Compile()).FirstOrDefault<SegUsuarios>();
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return segusuario;
        }

        public SegUsuarios GetUsuarioByNombreUsuario(string nombreUsuario)
        {
            SegUsuarios segusuario = null;
            try
            {
                segusuario = contexto.SegUsuarios.Where(p => p.strUsuario == nombreUsuario).FirstOrDefault<SegUsuarios>();
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return segusuario;
        }

        public SegUsuarios GetUsuarioById(int id)
        {
            SegUsuarios segusuario = null;
            try
            {
                segusuario = contexto.SegUsuarios.Where(p => p.id == id).FirstOrDefault<SegUsuarios>();
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return segusuario;
        }

        public SegUsuarios GetUsuarioByMatricula(string matricula)
        {
            SegUsuarios _segUsuarios = null;
            CatCarrera _catCarrera = null;
            try
            {
                Expression<Func<SegUsuarios, bool>> predicate = p => p.strMatricula.Equals(matricula);
                _segUsuarios = contexto.SegUsuarios.Where(predicate.Compile()).FirstOrDefault<SegUsuarios>();
                if (_segUsuarios != null)
                {
                    int id = (int)_segUsuarios.idCarrera;
                    Expression<Func<CatCarrera, bool>> predicate1 = p => p.id.Equals(id);
                    _catCarrera = contexto.CatCarrera.Where(predicate1.Compile()).FirstOrDefault<CatCarrera>();
                    _segUsuarios.CatCarrera = _catCarrera;
                }
                
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return _segUsuarios;
        }

        /// <summary>
        /// este metodo se encarga de insertar  en la base de datos
        /// </summary>
        /// <param name="segUsaurio">recibe un segusaurio</param>
        /// <returns>regresa un valor  booleano</returns>
        public bool InsertarSegUsuario(SegUsuarios segUsuario)
        {
            bool respuesta = false;
            try
            {
                contexto.SegUsuarios.Add(segUsuario);
                contexto.SaveChanges();
                respuesta = true;
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return respuesta;
        }

        public bool actualizarUsuario(SegUsuarios segUsuario)
        {
            bool respuesta = false;
            try
            {
                SegUsuarios usuario = contexto.SegUsuarios.Where(p => p.id == segUsuario.id).FirstOrDefault<SegUsuarios>();
                usuario.strMatricula = segUsuario.strMatricula;
                usuario.strSemestreActual = segUsuario.strSemestreActual;
                contexto.SegUsuarios.Attach(segUsuario);
                contexto.Entry(segUsuario).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
               
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                string mensajeError = ex.Message;
            }
            return respuesta;
        }
    }
}
