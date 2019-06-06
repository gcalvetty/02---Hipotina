using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hipotina_GECN.Startup))]
namespace Hipotina_GECN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
