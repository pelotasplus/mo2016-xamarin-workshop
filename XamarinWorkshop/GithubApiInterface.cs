using System.Threading.Tasks;
using Refit;

namespace XamarinWorkshop
{
	public interface GithubApiInterface
	{
		[Get("/search/users?q={query}+in:name")]
		Task<UsersResult> GetUsers(string query);
	}
}