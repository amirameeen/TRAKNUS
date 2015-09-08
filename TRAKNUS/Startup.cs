using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TRAKNUS.Startup))]
namespace TRAKNUS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
