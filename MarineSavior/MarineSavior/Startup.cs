using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarineSavior.Startup))]
namespace MarineSavior
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
