using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataLayer.Startup))]
namespace DataLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
