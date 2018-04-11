using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.AL.Startup))]
namespace Web.AL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
