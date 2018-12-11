using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MACARENA.Startup))]
namespace MACARENA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
