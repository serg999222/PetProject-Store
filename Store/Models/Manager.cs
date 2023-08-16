﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
	public class Manager
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public  ICollection<User> Users { get; set; } = new List<User>();

	}
}
