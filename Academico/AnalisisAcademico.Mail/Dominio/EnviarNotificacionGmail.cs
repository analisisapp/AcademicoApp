using System;

using System.Net;
using System.Net.Mail;
using AnalisisAcademico.Mail.Infraestructura;
using AnalisisAcademico.Mail.Recursos;

namespace AnalisisAcademico.Mail.Dominio
{
    public class EnviarNotificacionGmail: IEnviarMail
    {
        

        public bool enviarCorreo(string to, string message)
        {
            try
            {
                MailMessage correo = new MailMessage();
                SmtpClient smtp = new SmtpClient();

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

        //Metodo completo para enviar correo
//        public bool enviarMensaje(string correoUsuario, string message)
//        {
//            try
//            {
//                using (MailMessage mm = new MailMessage(correoUsuario, RecursosMail.CorreoGmail))
//                {    
//                    mm.From = new MailAddress(RecursosMail.CorreoGmail);
//                    mm.To.Add(new MailAddress(correoUsuario));
//                    mm.Subject = RecursosMail.Subject;
//                    mm.Body = message;
//                    mm.IsBodyHtml = false;
//                    SmtpClient smtp = new SmtpClient();
//                    smtp.Host = "smtp.gmail.com";
//                    smtp.EnableSsl = true;
//                    NetworkCredential networkCred = new NetworkCredential(RecursosMail.CorreoGmail, RecursosMail.ContrasenaGmail);
//                    smtp.UseDefaultCredentials = false;
//                    smtp.Credentials = networkCred;
//                    smtp.Port = 587;
//                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
//                    smtp.Send(mm);
//                }
//                return true;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.StackTrace);
//                return false;
//            }
//}
    }
}
