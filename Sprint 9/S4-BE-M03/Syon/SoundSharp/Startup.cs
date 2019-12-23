using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoundSharp.Startup))]
namespace SoundSharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
