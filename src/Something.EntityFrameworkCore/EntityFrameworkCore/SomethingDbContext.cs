using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Something.Authorization.Roles;
using Something.Authorization.Users;
using Something.MultiTenancy;

namespace Something.EntityFrameworkCore
{
    public class SomethingDbContext : AbpZeroDbContext<Tenant, Role, User, SomethingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SomethingDbContext(DbContextOptions<SomethingDbContext> options)
            : base(options)
        {
        }
    }
}
