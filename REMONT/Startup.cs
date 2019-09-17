using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(REMONT.Startup))]
namespace REMONT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
