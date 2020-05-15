using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalLogin.Startup))]
namespace FinalLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
