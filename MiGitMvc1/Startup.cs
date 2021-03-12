using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiGitMvc1.Startup))]
namespace MiGitMvc1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
