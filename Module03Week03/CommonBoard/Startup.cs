using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommonBoard.Startup))]
namespace CommonBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
