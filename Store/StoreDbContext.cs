using Store.Data;
using Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace Store
{
	public partial class StoreDbContext : DbContext
	{
		public StoreDbContext()
			: base("name=DbConection")
		{
			Database.SetInitializer(new CreateDatabaseIfNotExists<StoreDbContext>());
		}		

		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<Manager> Managers { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		

		
	}
}
