using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportStitch.WebMVC.Startup))]
namespace SportStitch.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
