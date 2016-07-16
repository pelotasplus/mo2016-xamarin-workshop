using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinWorkshop
{
	public partial class UserDetails : ContentPage
	{
		public UserDetails(UsersItem person)
		{
			InitializeComponent();

			BindingContext = new UserDetailsViewModel(person);

			Title = person.login;

			Avatar.Source = ImageSource.FromUri(new Uri(person.avatarUrl));
		}
	}
}

