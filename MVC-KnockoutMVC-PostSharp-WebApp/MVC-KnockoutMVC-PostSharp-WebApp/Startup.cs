using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_KnockoutMVC_PostSharp_WebApp.Startup))]
namespace MVC_KnockoutMVC_PostSharp_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
