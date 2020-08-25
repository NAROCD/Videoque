using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Videoque.Startup))]
namespace Videoque
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
