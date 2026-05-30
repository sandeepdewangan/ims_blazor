using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class IMSIdentityContext(DbContextOptions<IMSIdentityContext> options) :
    IdentityDbContext<IMS.WebApp.Data.ApplicationUser>(options)
{
}
