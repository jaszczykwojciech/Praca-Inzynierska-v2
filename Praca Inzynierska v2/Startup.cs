using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Praca_Inzynierska_v2.Startup))]
namespace Praca_Inzynierska_v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
