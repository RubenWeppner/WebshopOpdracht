using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webshop2.Startup))]
namespace Webshop2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
