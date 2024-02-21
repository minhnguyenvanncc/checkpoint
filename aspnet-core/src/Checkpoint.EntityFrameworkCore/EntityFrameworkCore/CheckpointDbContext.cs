using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Checkpoint.Authorization.Roles;
using Checkpoint.Authorization.Users;
using Checkpoint.MultiTenancy;

namespace Checkpoint.EntityFrameworkCore
{
    public class CheckpointDbContext : AbpZeroDbContext<Tenant, Role, User, CheckpointDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CheckpointDbContext(DbContextOptions<CheckpointDbContext> options)
            : base(options)
        {
        }
    }
}
