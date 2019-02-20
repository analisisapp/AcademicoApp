using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Academico.Startup))]
namespace Academico
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
