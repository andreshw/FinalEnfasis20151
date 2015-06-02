using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Enfasis20151.Final.Web.Startup))]
namespace Enfasis20151.Final.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
