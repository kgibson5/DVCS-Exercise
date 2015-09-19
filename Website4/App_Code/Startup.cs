using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website4.Startup))]
namespace Website4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
