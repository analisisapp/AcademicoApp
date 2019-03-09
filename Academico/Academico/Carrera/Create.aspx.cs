using AnalisisAcademico.Data.Infraestrucutra;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unity.WebForms.Configuration;
using Unity;
using Microsoft.Practices.Unity;
namespace Academico.Carrera
{
    public partial class Create : System.Web.UI.Page
    {
        [Dependency]
        public ICarreraRepository carreraRepository { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}