using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPVue.Configuration;
using ABPVue.Web;

namespace ABPVue.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPVueDbContextFactory : IDesignTimeDbContextFactory<ABPVueDbContext>
    {
        public ABPVueDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPVueDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPVueDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPVueConsts.ConnectionStringName));

            return new ABPVueDbContext(builder.Options);
        }
    }
}
