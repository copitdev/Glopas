using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GLOBAS.Startup))]
namespace GLOBAS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
