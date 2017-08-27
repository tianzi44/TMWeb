using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TM.Web.Merchant.Startup))]
namespace TM.Web.Merchant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
