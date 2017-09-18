using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllergicBeauty.Startup))]
namespace AllergicBeauty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
