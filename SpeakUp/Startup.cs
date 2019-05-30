using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpeakUp.Startup))]
namespace SpeakUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
