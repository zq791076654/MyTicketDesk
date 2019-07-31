using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace MyTicketDesk.Web.Identity.Model
{
    public class TicketDeskRole : IdentityRole
    {
        [Required]
        public string DisplayName { get; set; }
        public string Description { get; set; }

        public TicketDeskRole() : base()
        { }

        public TicketDeskRole(string roleName, string displayName, string description)
            : base(roleName)
        {
            DisplayName = displayName;
            Description = description;
        }
    }
}
