using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Turn1.Startup))]
namespace Turn1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
