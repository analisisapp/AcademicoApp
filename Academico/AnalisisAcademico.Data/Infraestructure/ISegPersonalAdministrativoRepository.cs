using AnalisisAcademico.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisAcademico.Data.Infraestructure
{
    public interface ISegPersonalAdministrativoRepository
    {
        bool InsertarPersonalAdministrativo(SegPersonalAdministrativo segPersonalAdministrativo);
        bool ValidarRegistroUsuarioAdministrativo(SegPersonalAdministrativo segPersonalAdministrativo);
        SegPersonalAdministrativo ValidarLoginAdministrativo(string nombre, string password);
        SegPersonalAdministrativo consultarUsuarioByIdAdministrativo(int id);
    }
}
