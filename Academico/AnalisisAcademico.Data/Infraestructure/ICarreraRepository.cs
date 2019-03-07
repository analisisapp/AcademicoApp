using AnalisisAcademico.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisAcademico.Data.Infraestrucutra
{
    public interface ICarreraRepository
    {
        CatCarrera GetConsultarCatCarrera(int idCarrera);
        CatCarrera GetConsultarCatCarreraPorUsuario(int idUsuario);
    }
}
