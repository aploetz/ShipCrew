using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShipCrew.Startup))]
namespace ShipCrew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
