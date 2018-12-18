using Microsoft.AspNet.Identity;
using ModelFirstFramework.Models;
using Owin;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin;

namespace ModelFirstFramework
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DevBuildMoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            app.CreatePerOwinContext(() => new IdentityDbContext<AppUser>(connectionString));

            app.CreatePerOwinContext<RoleManager<AppRole>>((options, context) =>
                new RoleManager<AppRole>(
                    new RoleStore<AppRole>(context.Get<IdentityDbContext<AppUser>>())));

            app.CreatePerOwinContext<UserManager<AppUser>>((options, context) => 
                new UserManager<AppUser>(
                    new UserStore<AppUser>(context.Get<IdentityDbContext<AppUser>>())));

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Identity/Login"),
            });
        }
    }
}