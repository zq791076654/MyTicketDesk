using Microsoft.AspNet.Identity.EntityFramework;
using MyTicketDesk.Web.Identity.Model;
using System.Data.Entity;

namespace MyTicketDesk.Web.Identity
{
    public class TdIdentityContext : IdentityDbContext<TicketDeskUser>
    {
        public TdIdentityContext():base("TicketDesk",true)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TicketDeskUser>().ToTable("IdentityUsers");
            modelBuilder.Entity<TicketDeskRole>().ToTable("IdentityRoles");
            //modelBuilder.Entity<IdentityRole>().ToTable("IdentityRoles");
            modelBuilder.Entity<IdentityUserRole>().ToTable("IdentityUserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("IdentityUserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("IdentityUserClaims");
        }
    }
}
