using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GFBTF_SimpleWebDemo.Startup))]
namespace GFBTF_SimpleWebDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
