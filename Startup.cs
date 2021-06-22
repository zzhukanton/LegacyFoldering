using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LegacyFoldering.Startup))]
namespace LegacyFoldering
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
