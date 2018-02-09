using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gesco.Startup))]
namespace gesco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
