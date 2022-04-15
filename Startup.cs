using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rice_Agency.Startup))]
namespace Rice_Agency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
