using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website3.Startup))]
namespace Website3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
