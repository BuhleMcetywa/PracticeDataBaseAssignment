using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOfDataBaseAssignment.Models
{
	public class Cart
	{

		[PrimaryKey, AutoIncrement]
		public int CartId { get; set; }

		public ObservableCollection<ShoppingItem> shoppingItems { get; set; }

		[ForeignKey(typeof(Customer))]
		public int CustomerId { get; set; }

		[OneToOne]
	    public Customer customer {  get; set; }


   }
}
