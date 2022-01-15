using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplikacjaCloudProjekt.Startup))]
namespace AplikacjaCloudProjekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
