using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreetingsWebApp.Startup))]
namespace GreetingsWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
