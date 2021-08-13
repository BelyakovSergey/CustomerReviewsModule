using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerReviewsModule.Core.Events;
using CustomerReviewsModule.Core.Models;
using CustomerReviewsModule.Core.Services;
using CustomerReviewsModule.Data.Models;
using CustomerReviewsModule.Data.Repositories;
using VirtoCommerce.Platform.Core.Caching;
using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.Platform.Core.Events;
using VirtoCommerce.Platform.Data.GenericCrud;
namespace CustomerReviewsModule.Data.Services
{
    public class CustomerReviewService : CrudService<CustomerReview, CustomerReviewEntity, CustomerReviewChangeEvent, CustomerReviewChangedEvent>, ICustomerReviewService
    {
        public CustomerReviewService(Func<ICustomerReviewRepository> repositoryFactory, IPlatformMemoryCache platformMemoryCache, IEventPublisher eventPublisher)
            : base(repositoryFactory, platformMemoryCache, eventPublisher)
        {
        }

        protected override Task<IEnumerable<CustomerReviewEntity>> LoadEntities(IRepository repository, IEnumerable<string> ids, string responseGroup)
        {
            return ((ICustomerReviewRepository)repository).GetByIdsAsync(ids);
        }
    }
}
