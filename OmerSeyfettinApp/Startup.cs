using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OmerSeyfettinApp.Startup))]
namespace OmerSeyfettinApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
