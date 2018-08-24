using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculatorWebApplication.Startup))]
namespace CalculatorWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
