using System;

using AnalisisAcademico.Mail.Recursos;
using AnalisisAcademico.Mail.Infraestructura;
using System.Net;
using System.Net.Mail;


namespace AnalisisAcademico.Mail.Dominio
{
    public class EnviarNotificacionHotmail : IEnviarMail
    {
        MailMessage correo = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public bool enviarCorreo(string to, string message)
        {
            try
            {
                correo.From = new MailAddress(RecursosMail.CorreoHotmail);
                correo.Subject = RecursosMail.Subject;
                correo.SubjectEncoding = System.Text.Encoding.UTF8;
                correo.To.Add(new MailAddress(to));
                correo.Body = message;
                correo.BodyEncoding = System.Text.Encoding.UTF8;
                correo.IsBodyHtml = false;
                smtp.Host = RecursosMail.HostHotmail;
                smtp.Port = int.Parse(RecursosMail.PortHotmail);
                smtp.Credentials = new NetworkCredential(RecursosMail.CorreoHotmail, RecursosMail.ContrasenaHotmail);
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
