using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpaBaliNew.Startup))]
namespace SpaBaliNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
