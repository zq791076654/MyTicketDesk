

using Microsoft.AspNet.Identity;
using MyTicketDesk.Web.Identity.Model;

namespace MyTicketDesk.Web.Identity
{
    public class TicketDeskRoleManager : RoleManager<TicketDeskRole>
    {
        public TicketDeskRoleManager(IRoleStore<TicketDeskRole, string> store) : base(store)
        {
        }
    }
}
