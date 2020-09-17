using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPUnity01.EntityFrameworkCore
{
    public static class ABPUnity01DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPUnity01DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPUnity01DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
