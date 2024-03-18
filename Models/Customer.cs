using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOfDataBaseAssignment.Models
{
	public class Customer
	{
		[PrimaryKey, AutoIncrement]
		public int CustomerId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string EmailAddress { get; set; }
		public string Bio { get; set; }

		[ForeignKey(typeof(Cart))]
		public int CartId { get; set; }

		[OneToMany(CascadeOperations =CascadeOperation.All)]
		public List<ShoppingItem> shoppingItems { get; set; }

		public Customer() 
		{ 
			shoppingItems = new List<ShoppingItem>();
		}

	}
	 
	
}
