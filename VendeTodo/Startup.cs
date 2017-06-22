using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VendeTodo.Startup))]
namespace VendeTodo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
