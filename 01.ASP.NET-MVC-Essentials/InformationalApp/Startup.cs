using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InformationalApp.Startup))]

namespace InformationalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
