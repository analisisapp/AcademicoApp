using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisisAcademico.Web.Control
{
    public class CtrlValidaciones
    {
        public bool soloFormatoPDF(string extension)
        {
            try
            {
                extension = extension.Substring(extension.LastIndexOf("." + 1)).ToLower();
                String[] formatos = new String[] { "pdf" };
                if (Array.IndexOf(formatos, extension) < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return false;
            }
        }

        public bool soloFormatoImagen(string extension)
        {
            try
            {
                extension = extension.Substring(extension.LastIndexOf("." + 1)).ToLower();
                String[] formatos = new String[] { "jpg", "png", "jpeg", "bmp" };
                if (Array.IndexOf(formatos, extension) < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return false;
            }
        }
    }
}
