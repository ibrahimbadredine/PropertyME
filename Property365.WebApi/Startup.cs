using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Property365.WebApi.Startup))]
namespace Property365.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
