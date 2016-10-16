using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketMeisterIII.Startup))]
namespace TicketMeisterIII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
