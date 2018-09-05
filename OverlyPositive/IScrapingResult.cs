using System.Collections.Generic;
using System.Threading.Tasks;

namespace OverlyPositive
{
    public interface IScrapingResult
    {
    }

    public class SuccessfulScrape : IScrapingResult
    {
        public IEnumerable<OverlyPositiveReview> OverlyPositiveReviews { get; internal set; }
    }

    public class FailedScrape : IScrapingResult
    {

    }
}