using Owin;
using System.Web.Routing;

namespace MyTicketDesk.Web.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            RegisterRoutes(RouteTable.Routes);
            ConfigureAuth(app);
        }
    }
}