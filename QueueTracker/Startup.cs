using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QueueTracker.Startup))]
namespace QueueTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
