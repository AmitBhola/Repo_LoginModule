using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginModule.Startup))]
namespace LoginModule
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
