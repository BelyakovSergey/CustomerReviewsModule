using System.Collections.Generic;
using CustomerReviewsModule.Core.Models;
using VirtoCommerce.Platform.Core.Events;

namespace CustomerReviewsModule.Core.Events
{
    public class CustomerReviewChangedEvent : GenericChangedEntryEvent<CustomerReview>
    {
        public CustomerReviewChangedEvent(IEnumerable<GenericChangedEntry<CustomerReview>> changedEntries) : base(changedEntries)
        {
        }
    }
}
