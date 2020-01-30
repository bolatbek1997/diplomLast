using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiplomLast.Startup))]
namespace DiplomLast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
