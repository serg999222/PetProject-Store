﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
	public class Category
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public virtual IEnumerable<Product> Products { get; } = new List<Product>();
	}
}
