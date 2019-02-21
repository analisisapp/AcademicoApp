using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisAcademico.Mail.Infraestructura
{
    public interface IEnviarMail
    {
        bool enviarCorreo(string to, string message);
    }
}
