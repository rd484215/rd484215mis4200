using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rd484215mis4200.Startup))]
namespace rd484215mis4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
