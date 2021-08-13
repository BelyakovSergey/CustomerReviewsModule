using VirtoCommerce.Platform.Core.Common;

namespace CustomerReviewsModule.Core.Models.Search
{
    public class CustomerReviewSearchCriteria : SearchCriteriaBase
    {
        public string[] ProductIds { get; set; }
        public bool? IsActive { get; set; }
    }
}
