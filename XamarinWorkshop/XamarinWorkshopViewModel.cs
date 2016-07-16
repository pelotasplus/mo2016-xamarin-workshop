using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinWorkshop
{
	public class XamarinWorkshopViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public ObservableCollection<UsersItem> Users { get; private set; } = new ObservableCollection<UsersItem>();

		private UsersItem selectedPerson;
		public UsersItem SelectedPerson
		{
			get
			{
				return selectedPerson;
			}
			set
			{
				selectedPerson = value;
				NotifyPropertyChanged();
			}
		}

		public String Keyword { get; set; }

		public ICommand SearchCommand { get; set; }

		public XamarinWorkshopViewModel()
		{
			SearchCommand = new Command(DoSearch);

			//Users.Add(new Person("Aleksander Piotrowski"));
			//Users.Add(new Person("Przemyslaw Jakubczyk"));
			//Users.Add(new Person("Lukasz Przytula"));

			//loadData();
		}

		void DoSearch()
		{
			System.Diagnostics.Debug.WriteLine("XXX Keyword {0}", Keyword);
			loadData(Keyword);
		}

		public async void loadData(string keyword)
		{
			var apiService = DependencyService.Get<ApiService>();
			var result = await apiService.GetUsers(keyword);
			foreach (UsersItem item in result.items)
			{
				Users.Add(item);
			}
		}
	}
}