//using Android.Service.Voice;
//using Bumptech.Glide.Load.Model;
using PracticeOfDataBaseAssignment.Models;
using PracticeOfDataBaseAssignment.Services;

namespace PracticeOfDataBaseAssignment
{
	public partial class MainPage : ContentPage
	{
		private AppDataBase _database;

		
		private Customer _currentCustomer;

		public Customer CurrentCustomer
		{
			get { return _currentCustomer; }
			set
			{
				_currentCustomer = value;

				OnPropertyChanged();

			}
		}


		public MainPage()
		{
			InitializeComponent();

			_database = new AppDataBase();

			BindingContext = this;


		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			LoadData();
		}

		private void ReloadButton_Clicked(object sender, EventArgs e)
		{
			
		}

		private void LoadData()
		{
			Customer customer = _database.GetCustomerById(1);

			CurrentCustomer = customer;
		}

		private void OnSaveClicked(object sender, EventArgs e)
		{
			_database.UpdateCustomer(CurrentCustomer);
		}
	}

}
