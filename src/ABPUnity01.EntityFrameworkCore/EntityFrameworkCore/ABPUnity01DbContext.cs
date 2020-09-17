using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPUnity01.Authorization.Roles;
using ABPUnity01.Authorization.Users;
using ABPUnity01.MultiTenancy;
using ABPUnity01.Entitys;

namespace ABPUnity01.EntityFrameworkCore
{
    public class ABPUnity01DbContext : AbpZeroDbContext<Tenant, Role, User, ABPUnity01DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPUnity01DbContext(DbContextOptions<ABPUnity01DbContext> options)
            : base(options)
        {
        }
        public DbSet<UserInfo> users { get; set; }
    }
}
