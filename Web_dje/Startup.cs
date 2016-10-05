using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_dje.Startup))]
namespace Web_dje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
