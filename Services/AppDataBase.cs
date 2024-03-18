using SQLite;
using SQLiteNetExtensions.Extensions;
using PracticeOfDataBaseAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
//using Android.Views;
//using Android.Widget;


namespace PracticeOfDataBaseAssignment.Services
{
	public class AppDataBase { 

		private SQLiteConnection _dbConnection;
	
		public string GetDatabasePath()
		{
			string filename = "appdata.db";
			string pathToDb= Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			return Path.Combine(pathToDb, filename);
		}
		public AppDataBase() 
		{
			_dbConnection = new SQLiteConnection(GetDatabasePath());

			_dbConnection.CreateTable<Customer>();
			

			SeedDataBase();

		}

		public void SeedDataBase() 
		{
			if (_dbConnection.Table<Customer>().Count() == 0)
			{
				Customer customer = new Customer();
				{
					customer.CustomerId = 1;
					customer.Name = "Mihlali";
					customer.Surname = "Mcetywa";
					customer.EmailAddress = "mihlalimcetywa3@gmail.com";
					customer.Bio = "I am a rugby player";


				};

				_dbConnection.Insert(customer);
			}

			ShoppingItem shoppingItem = new ShoppingItem();
			{
				shoppingItem.ItemName = "PetriDish";
				shoppingItem.ItemQuantity = 60;
				shoppingItem.ItemPrice = 100.10m;

			}

			shoppingItem = new ShoppingItem(); 

			{
				shoppingItem.ItemName = "PetriDish";
				shoppingItem.ItemQuantity = 60;
				shoppingItem.ItemPrice = 100.10m;

			}

			shoppingItem =new ShoppingItem();

			{
				shoppingItem.ItemName = "PetriDish";
				shoppingItem.ItemQuantity = 60;
				shoppingItem.ItemPrice = 100.10m;
			}


			
		}




		public Customer GetCustomerById(int id)
		{
			Customer customer = _dbConnection.Table<Customer>().ToList().Where(x=> x.CustomerId == id).FirstOrDefault();	

			if(customer != null)
			
				_dbConnection.GetChildren(customer, true);

				return customer;
			
		}

		public void UpdateCustomer(Customer currentCustomer)
		{
			_dbConnection.Update(currentCustomer);	
		}
	}
}
