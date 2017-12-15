using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW1.Startup))]
namespace HW1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
