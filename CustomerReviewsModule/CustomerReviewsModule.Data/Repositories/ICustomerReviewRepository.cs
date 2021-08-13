using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerReviewsModule.Data.Models;
using VirtoCommerce.Platform.Core.Common;

namespace CustomerReviewsModule.Data.Repositories
{
    public interface ICustomerReviewRepository : IRepository
    {
        IQueryable<CustomerReviewEntity> CustomerReviews { get; }

        Task<IEnumerable<CustomerReviewEntity>> GetByIdsAsync(IEnumerable<string> ids);
    }
}
