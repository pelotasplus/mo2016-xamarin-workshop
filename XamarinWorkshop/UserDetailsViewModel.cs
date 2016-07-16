namespace XamarinWorkshop
{
	public class UserDetailsViewModel
	{
		private UsersItem user;
		public UsersItem User
		{
			get
			{
				return user;
			}

			private set
			{
				user = value;
			}
		}

		public UserDetailsViewModel(UsersItem person)
		{
			User = person;
		}
	}
}