using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcRecords.Startup))]
namespace MvcRecords
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
