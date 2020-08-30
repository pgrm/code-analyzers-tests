using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Test.RCS1151
{
    public static class ExtensionMethods
    {
        public static DbContextOptionsBuilder UseCustomMigrations(this DbContextOptionsBuilder optionsBuilder)
        {
            ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(new CustomExtension());

            return optionsBuilder;
        }
    }
}
