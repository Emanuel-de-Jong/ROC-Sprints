using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoundSharpMVC.Startup))]
namespace SoundSharpMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
