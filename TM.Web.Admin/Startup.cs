using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TM.Web.Admin.Startup))]
namespace TM.Web.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
