using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppEcommerce.Startup))]
namespace AppEcommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
