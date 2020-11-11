using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EC1_ashion.Startup))]
namespace EC1_ashion
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
