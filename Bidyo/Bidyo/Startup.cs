using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bidyo.Startup))]
namespace Bidyo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
