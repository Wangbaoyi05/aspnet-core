using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPUnity01.Configuration;
using ABPUnity01.Web;

namespace ABPUnity01.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPUnity01DbContextFactory : IDesignTimeDbContextFactory<ABPUnity01DbContext>
    {
        public ABPUnity01DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPUnity01DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPUnity01DbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPUnity01Consts.ConnectionStringName));

            return new ABPUnity01DbContext(builder.Options);
        }
    }
}
