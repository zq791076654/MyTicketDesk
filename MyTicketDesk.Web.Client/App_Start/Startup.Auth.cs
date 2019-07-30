
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace MyTicketDesk.Web.Client
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/user/sign-in"),
                Provider = new CookieAuthenticationProvider()
                {
                    //OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<>()
                }

            });
        }
    }
}