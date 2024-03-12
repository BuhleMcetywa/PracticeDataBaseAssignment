using SQLite;
using System;
using System.Collections.Generic;
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
	}
	 
	
}
