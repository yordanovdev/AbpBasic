using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Something.EntityFrameworkCore
{
    public static class SomethingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SomethingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SomethingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
