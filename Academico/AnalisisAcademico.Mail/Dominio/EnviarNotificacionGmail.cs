using System;

using System.Net;
using System.Net.Mail;
using AnalisisAcademico.Mail.Infraestructura;
using AnalisisAcademico.Mail.Recursos;

namespace AnalisisAcademico.Mail.Dominio
{
    public class EnviarNotificacionGmail: IEnviarMail
    {
        MailMessage correo = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public bool enviarCorreo(string to, string message)
        {
            try
            {
                correo.From = new MailAddress(RecursosMail.CorreoGmail);
                correo.To.Add(new MailAddress(to));
                correo.Body = message;
                //correo.IsBodyHtml = true;
                smtp.Host = RecursosMail.HostGmail;      //"smtp.gmail.com";
                smtp.Port = int.Parse(RecursosMail.PortGmail);
                smtp.Credentials = new NetworkCredential(RecursosMail.CorreoGmail, RecursosMail.ContrasenaGmail);
                smtp.EnableSsl = true;
                smtp.Send(correo);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
    }
}
