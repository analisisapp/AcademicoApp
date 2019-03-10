using AnalisisAcademico.Data.Infraestructure;
using AnalisisAcademico.Data.Model;
using Microsoft.Practices.Unity;
using System;
using System.Data.Linq;
using System.IO;
using System.Web;

namespace Academico.Handler
{
    /// <summary>
    /// Descripción breve de vizualizarFoto
    /// </summary>
    public class vizualizarFoto : IHttpHandler
    {
        [Dependency]
        public ISegUsuarioRepository segUsuarioRepository { get; set; } //inyectamos la dependencia del objeto

        public void ProcessRequest(HttpContext context)
        {
            Int32 id;
            if (context.Request.QueryString["id"] != null)
                id = Convert.ToInt32(context.Request.QueryString["id"]);

            else
                throw new ArgumentException("No parameter specified");

            context.Response.ContentType = "image/jpeg";
            Stream strm = MostrarImagen(id);

            if (strm != null)
            {
                byte[] buffer = new byte[4096]; ///tamaño maximo 4MB
                int byteSeq = strm.Read(buffer, 0, 4096);

                while (byteSeq > 0)
                {
                    context.Response.OutputStream.Write(buffer, 0, byteSeq);
                    byteSeq = strm.Read(buffer, 0, 4096);
                }
            }
        }
        #region Metodo que se encarga de mostrar la imagen de un usuario con perfil de alumno
        public Stream MostrarImagen(int _idUsuario)
        {
            try
            {
                SegUsuarios segUsuario = segUsuarioRepository.GetUsuarioById(_idUsuario);
                System.Data.Linq.Binary fotoData = null;
                fotoData = (Binary)segUsuario.foto;
                if (fotoData != null)
                {
                    byte[] arreglo = fotoData.ToArray();
                    return new MemoryStream(arreglo);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        //#region Metodo para consultar la imagen de un usuario administrativo
        //public Stream MostrarImagenAdministrativo(int _idUsuario)
        //{
        //    try
        //    {

        //        IRepositorioSegPersonalAdministrativo isegUsuario = new RepositorySegPersonalAdministrativo();
        //        SegPersonalAdministrativo segUsuario = isegUsuario.consultarUsuarioByIdAdministrativo(_idUsuario);
        //        System.Data.Linq.Binary fotoData = null;
        //        fotoData = (Binary)segUsuario.foto;
        //        byte[] arreglo = fotoData.ToArray();
        //        return new MemoryStream(arreglo);
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        //#endregion

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}