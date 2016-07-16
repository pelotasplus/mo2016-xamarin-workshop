using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinWorkshop
{
	public partial class XamarinWorkshopPage : ContentPage
	{
		XamarinWorkshopViewModel viewModel;

		public XamarinWorkshopPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new XamarinWorkshopViewModel();

			UsersListView.ItemSelected += (sender, args) =>
			{
				var person = args.SelectedItem as UsersItem;
				if (person == null)
				{
					return;
				}

				UsersListView.SelectedItem = null;

				Navigation.PushAsync(new UserDetails(person));
			};

			//SearchButton.Clicked += (sender, e) =>
			//{
			//	viewModel.loadData(Keyword.Text);
			//};
		}
	}
}