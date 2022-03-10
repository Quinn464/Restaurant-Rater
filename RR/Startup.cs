using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RR.Startup))]
namespace RR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
