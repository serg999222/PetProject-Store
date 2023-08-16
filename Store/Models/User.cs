using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Login { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public string Password { get; set; }
		public bool IsAdmin { get; set; } = false;
		public int ManagerId { get; set; }
		public Manager Manager { get; set; }
		public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();
	}
}
