using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sonBingol.Startup))]
namespace sonBingol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
