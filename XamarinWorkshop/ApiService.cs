using System;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;
using XamarinWorkshop;

[assembly: Xamarin.Forms.Dependency(typeof(ApiService))]
namespace XamarinWorkshop
{
	public class ApiService : ApiInterface
	{
		GithubApiInterface githubApi;
		//String address = "https://api-github-com-16werhyjmqvv.runscope.net";
		String address = "https://api.github.com";

		public ApiService() {
			var httpClient = new HttpClient
			{
				BaseAddress = new Uri(address),
				DefaultRequestHeaders = { { "User-Agent", "Refit" } }
			};
			githubApi = RestService.For<GithubApiInterface>(httpClient);
		}

		public async Task<UsersResult> GetUsers(string name)
		{
			return await githubApi.GetUsers(name);
		}
	}
}

