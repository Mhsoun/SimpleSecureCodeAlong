using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleSecureCodeAlong.Startup))]
namespace SimpleSecureCodeAlong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
