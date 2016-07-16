using System;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(ApiService))]
namespace XamarinWorkshop.Droid
{
	public class ApiService : ApiInterface
	{
		public ApiService()
		{
		}

		public async Task<UsersResult> GetUsers(string name)
		{
			System.Diagnostics.Debug.WriteLine("Before {0}", DateTime.Now);

			await Task.Delay(5000);

			System.Diagnostics.Debug.WriteLine("After {0}", DateTime.Now);

			return new UsersResult();
		}
	}
}

