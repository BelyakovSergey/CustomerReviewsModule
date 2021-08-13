using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CustomerReviewsModule.Data.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CustomerReviewsDbContext>
    {
        public CustomerReviewsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CustomerReviewsDbContext>();

            builder.UseSqlServer("Data Source=(local);Initial Catalog=VirtoCommerce3;Trusted_Connection=True;Connect Timeout=30");

            return new CustomerReviewsDbContext(builder.Options);
        }
    }
}
