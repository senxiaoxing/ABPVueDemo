using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPVue.EntityFrameworkCore
{
    public static class ABPVueDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPVueDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql(
                connectionString,
                options => options.SetPostgresVersion(new Version(9, 6)));
        }

        public static void Configure(DbContextOptionsBuilder<ABPVueDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseNpgsql(connection);
        }
    }
}
