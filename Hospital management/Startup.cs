using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hospital_management.Startup))]
namespace Hospital_management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
