using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnWeb.Startup))]
namespace LearnWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
