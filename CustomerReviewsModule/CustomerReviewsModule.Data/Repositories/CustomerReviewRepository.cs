using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerReviewsModule.Data.Models;
using Microsoft.EntityFrameworkCore;
using VirtoCommerce.Platform.Data.Infrastructure;

namespace CustomerReviewsModule.Data.Repositories
{
    public class CustomerReviewRepository : DbContextRepositoryBase<CustomerReviewsDbContext>, ICustomerReviewRepository
    {
        public CustomerReviewRepository(CustomerReviewsDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<CustomerReviewEntity> CustomerReviews => DbContext.Set<CustomerReviewEntity>();

        public Task<IEnumerable<CustomerReviewEntity>> GetByIdsAsync(IEnumerable<string> ids)
        {
            return Task.FromResult<IEnumerable<CustomerReviewEntity>>(CustomerReviews.Where(x => ids.Contains(x.Id)).ToList());
        }
    }
}
