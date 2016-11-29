using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PS_StoreFinal1.Startup))]
namespace PS_StoreFinal1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
