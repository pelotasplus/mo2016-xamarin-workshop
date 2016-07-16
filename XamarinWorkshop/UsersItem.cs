using Newtonsoft.Json;

namespace XamarinWorkshop
{
	public class UsersItem
	{
		[JsonProperty("login")]
		public string login { get; set; }

		[JsonProperty("id")]
		public long id;

		[JsonProperty("avatar_url")]
		public string avatarUrl;

		public string FirstName
		{
			get
			{
				return "Mx. " + login;
			}
		}

		public string LastName
		{
			get
			{
				return "No #" + id;
			}
		}
	}
}