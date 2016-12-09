using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantJISH.Startup))]
namespace RestaurantJISH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
