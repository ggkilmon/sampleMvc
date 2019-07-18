using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleMvcCodeSample.Startup))]
namespace SampleMvcCodeSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
