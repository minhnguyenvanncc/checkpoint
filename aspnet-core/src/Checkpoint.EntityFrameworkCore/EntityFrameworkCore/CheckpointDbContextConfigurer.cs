using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Checkpoint.EntityFrameworkCore
{
    public static class CheckpointDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CheckpointDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CheckpointDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
