using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAzureAppOnPremiseWcfTest.Startup))]
namespace MvcAzureAppOnPremiseWcfTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
