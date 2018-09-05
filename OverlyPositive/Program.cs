using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OverlyPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<IScrapingResult> scrapingTask = Scraper.ScrapeReviews();

            HandleTheWaiting(scrapingTask);

            switch (scrapingTask.Result)
            {
                case SuccessfulScrape successfulScrape:
                    ReportReviews(successfulScrape);
                    break;
                default:
                    ReportFailedScrape();
                    break;
            }
        }

        private static void ReportReviews(SuccessfulScrape successfulScrape)
        {
            OverlyPositiveReview[] topThreeOverlyPositive =
                successfulScrape
                    .OverlyPositiveReviews
                    .OrderBy(review => review.Severity)
                    .Take(3)
                    .ToArray();
            if (topThreeOverlyPositive.Any())
            {
                foreach (OverlyPositiveReview overlyPositive in topThreeOverlyPositive)
                {
                    Console.WriteLine(overlyPositive.ReviewContent);
                }
            }
            else
            {
                Console.WriteLine("No overly positive reviews detected.");
            }
        }

        /// <summary>
        /// For being asynchronous, which is nice but will require some contortion in this context
        /// </summary>
        static void HandleTheWaiting(Task<IScrapingResult> scrapingTask)
        {
            //Console.WriteLine("Gathering overly positive reviews. Type 'x' or 'q' at any time if you want to bail.");

            //while (scrapingTask.Status == TaskStatus.WaitingForActivation || scrapingTask.Status == TaskStatus.Running)
            //{
            //    var shtuff = Console.ReadLine();
            //    Thread.Sleep(100);
            //}
        }

        private static void ReportFailedScrape() =>
           Console.WriteLine("The review scraper failed.");
    }

    /*The Plan
     * asynchronous
     * load -> transform -> thing
     * follow the outline in the description
     * 
     * Scrape the first five pages of reviews
     * Identify the 3 most overly positive endorsements
     * Output the 3 in order of severity (most severe first)
     */
}
