using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPVue.Authorization.Roles;
using ABPVue.Authorization.Users;
using ABPVue.MultiTenancy;
using Abp.Localization;

namespace ABPVue.EntityFrameworkCore
{
    public class ABPVueDbContext : AbpZeroDbContext<Tenant, Role, User, ABPVueDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPVueDbContext(DbContextOptions<ABPVueDbContext> options)
            : base(options)
        {
        }

        // add these lines to override max length of property
        // we should set max length smaller than the PostgreSQL allowed size (10485760)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
