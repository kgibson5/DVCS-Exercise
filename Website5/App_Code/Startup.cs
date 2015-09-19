using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website5.Startup))]
namespace Website5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
