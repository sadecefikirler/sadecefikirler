using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sadecefikirler.Startup))]
namespace sadecefikirler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
