using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Modeling.Startup))]
namespace Modeling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
