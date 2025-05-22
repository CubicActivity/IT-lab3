using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(amongus.Startup))]
namespace amongus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
