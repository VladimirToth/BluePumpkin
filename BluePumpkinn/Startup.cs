using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BluePumpkinn.Startup))]
namespace BluePumpkinn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
