using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicCRUD.Startup))]
namespace BasicCRUD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
