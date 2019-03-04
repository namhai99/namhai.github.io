using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLTT.Startup))]
namespace QLTT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
