using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Warehouse_Management_System.Startup))]
namespace Warehouse_Management_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
