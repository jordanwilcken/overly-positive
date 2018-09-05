using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OverlyPositive
{
	public class Scraper
    {
		private HttpClient HttpClient { get; }

		public Scraper(HttpClient httpClient)
		{
			HttpClient = httpClient;
		}

		public Task<IScrapingResult> ScrapeReviews()
        {
            throw new NotImplementedException();
        }

		//public Task<StartJobResponse> StartJob(StartJobRequest request) =>
		//	_httpClient
		//		.PostAsync(request.Uri, MakeRequestBody(request))
		//		.ContinueWith(response => StartJobResponse.FromHttpResponse(response.Result).Result);

		//public StringContent MakeRequestBody(StartJobRequest request)
		//{
		//	string bodyString =
		//	""
		//		+ "{"
		//			+ $"\"input\": \"{request.Body}\","
		//			+ $"\"name\": \"{request.Guid}\","
		//			+ "\"stateMachineArn\": \"arn:aws:states:us-east-2:055756163541:stateMachine:jordan_does_state_machines\""
		//		+ "}";

		//	return new StringContent(bodyString, Encoding.UTF8, "application/json");
		//}

		//public static Task<StartJobResponse> FromHttpResponse(HttpResponseMessage response) =>
		//	response.Content
		//		.ReadAsStringAsync()
		//		.ContinueWith(responseStringTask => MapResponse(response.StatusCode, responseStringTask.Result));
	}
}