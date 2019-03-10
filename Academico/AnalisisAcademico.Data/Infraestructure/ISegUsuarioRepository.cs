using AnalisisAcademico.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisAcademico.Data.Infraestructure
{
    public interface ISegUsuarioRepository
    {
        /// <summary>
        /// este metodo busca  a un usuario dentro del sistema
        /// </summary>
        /// <param name="nombre">nombre del usuario</param>
        /// <param name="password">password del usuario</param>
        /// <returns>regresa un segusuario</returns>
        SegUsuarios GetUsuarioLogin(string nombre, string password);
        SegUsuarios GetUsuarioById(int id);
        SegUsuarios GetUsuarioByNombreUsuario(string nombreUsuario);
        SegUsuarios GetUsuarioByMatricula(string matricula);
        bool InsertarSegUsuario(SegUsuarios segUsaurio);
        bool actualizarUsuario(SegUsuarios segUsuario);
    }
}
