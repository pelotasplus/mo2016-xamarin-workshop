using System;
using System.Threading.Tasks;

namespace XamarinWorkshop
{
	public interface ApiInterface
	{
		Task<UsersResult> GetUsers(String name);
	}
}