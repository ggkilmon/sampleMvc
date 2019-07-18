using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BizStreamCodeSample.Startup))]
namespace BizStreamCodeSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
