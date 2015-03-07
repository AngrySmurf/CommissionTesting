using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommissionTesting.Startup))]
namespace CommissionTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
