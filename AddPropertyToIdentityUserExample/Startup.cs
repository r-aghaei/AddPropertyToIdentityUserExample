using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddPropertyToIdentityUserExample.Startup))]
namespace AddPropertyToIdentityUserExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
