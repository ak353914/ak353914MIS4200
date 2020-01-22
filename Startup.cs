using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ak353914MIS4200.Startup))]
namespace ak353914MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
