using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOfDataBaseAssignment.Models
{
    public class ShoppingItem
    {
        [PrimaryKey, AutoIncrement]
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }

        public int ItemQuantity { get; set; }

        [ForeignKey(typeof(Cart))]
        public int CartId { get; set; }

        [ManyToOne]
        public Cart cart { get; set; }
    }
}
