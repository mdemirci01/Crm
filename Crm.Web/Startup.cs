using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crm.Web.Startup))]
namespace Crm.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
