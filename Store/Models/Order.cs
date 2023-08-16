using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
	public class Order
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime DateTime { get; } =  DateTime.Now;
		public User User { get; set; }
		public ICollection<Product> Products { get; set; } = new List<Product>();
	}
}
