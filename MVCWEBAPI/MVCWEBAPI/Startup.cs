using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWEBAPI.Startup))]
namespace MVCWEBAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
