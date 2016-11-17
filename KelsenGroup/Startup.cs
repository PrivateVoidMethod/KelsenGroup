using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KelsenGroup.Startup))]
namespace KelsenGroup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
