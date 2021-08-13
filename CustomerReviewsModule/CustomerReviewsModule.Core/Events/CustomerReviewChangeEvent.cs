using System.Collections.Generic;
using CustomerReviewsModule.Core.Models;
using VirtoCommerce.Platform.Core.Events;

namespace CustomerReviewsModule.Core.Events
{
    public class CustomerReviewChangeEvent : GenericChangedEntryEvent<CustomerReview>
    {
        public CustomerReviewChangeEvent(IEnumerable<GenericChangedEntry<CustomerReview>> changedEntries) : base(changedEntries)
        {
        }
    }
}
