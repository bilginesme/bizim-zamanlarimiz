using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BenimZamanlarim.Startup))]
namespace BenimZamanlarim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
