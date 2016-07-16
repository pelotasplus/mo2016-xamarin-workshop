using System.Collections.Generic;
using Newtonsoft.Json;

namespace XamarinWorkshop
{
	public class UsersResult
	{
		[JsonProperty("total_count")]
		public long totalCount = 0;

		[JsonProperty("incomplete_result")]
		public bool incompleteResult = false;

		[JsonProperty("items")]
		public List<UsersItem> items = new List<UsersItem>();
	}
}