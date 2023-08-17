using Store.Data;
using Store.Models;
using Store.Services;
using Store.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
	public partial class FormAutorise : Form
	{
		public FormAutorise()
		{
			InitializeComponent();
		}
		private StoreDbContext db = new StoreDbContext();
		private void SeedInitialData()
		{
			User userHas = db.Users.FirstOrDefault(u => u.Id == 1);
			if (userHas == null)
			{
				db.Managers.AddRange(new List<Manager>
			{
				new Manager { Id = 1, Name = "Vasil", SurName = "Perepel" },
				new Manager { Id = 2, Name = "Mariya", SurName = "Legichko" }
			});

				db.Users.AddRange(new List<User> {
				new User { Id = 1, IsAdmin = true, Name = "Admin", SurName = "Admin", Password = "123", Login = "Admin",ManagerId = 1 },
				new User { Id = 2, Name = "User", SurName = "User", Password = "123", Login = "User",ManagerId = 1 }});


				db.Categories.AddRange(new List<Category>
			{
				new Category { Id = 1, Name = "Cheese" },
				new Category { Id = 2, Name = "Meat" },
				new Category { Id = 3, Name = "Fish" },
				new Category { Id = 4, Name = "Bread" }
			});

				db.Products.AddRange(new List<Product>
			{
				new Product { Id = 1, CategoryId = 1, Name = "Cheddar", Price = 200 },
				new Product { Id = 2, CategoryId = 1, Name = "Brie" , Price = 150},
				new Product { Id = 3, CategoryId = 1, Name = "Stilton", Price = 220 },
				new Product { Id = 4, CategoryId = 1, Name = "Cheshire", Price = 300 },
				new Product { Id = 5, CategoryId = 1, Name = "Swiss", Price = 310.5m },
				new Product { Id = 6, CategoryId = 1, Name = "Gruyere", Price = 195.9m },
				new Product { Id = 7, CategoryId = 1, Name = "Colby", Price = 233 },
				new Product { Id = 8, CategoryId = 1, Name = "Mozzela", Price = 255 },
				new Product { Id = 9, CategoryId = 1, Name = "Ricotta", Price = 289 },
				new Product { Id = 10, CategoryId = 1, Name = "Parmesan", Price = 500 },
				new Product { Id = 11, CategoryId = 2, Name = "Ham", Price = 410 },
				new Product { Id = 12, CategoryId = 2, Name = "Beef", Price = 222 },
				new Product { Id = 13, CategoryId = 2, Name = "Chicken", Price = 100 },
				new Product { Id = 14, CategoryId = 2, Name = "Turkey", Price = 95.8m },
				new Product { Id = 15, CategoryId = 2, Name = "Prosciutto", Price = 280 },
				new Product { Id = 16, CategoryId = 2, Name = "Bacon", Price = 285 },
				new Product { Id = 17, CategoryId = 2, Name = "Mutton", Price = 266 },
				new Product { Id = 18, CategoryId = 2, Name = "Pastrami", Price = 362 },
				new Product { Id = 19, CategoryId = 2, Name = "Hazlet", Price =550 },
				new Product { Id = 20, CategoryId = 2, Name = "Salami", Price = 265 },
				new Product { Id = 21, CategoryId = 3, Name = "Salmon", Price = 650 },
				new Product { Id = 22, CategoryId = 3, Name = "Tuna", Price = 330 },
				new Product { Id = 23, CategoryId = 3, Name = "Mackerel", Price = 600 },
				new Product { Id = 24, CategoryId = 4, Name = "Rye", Price = 350 },
				new Product { Id = 25, CategoryId = 4, Name = "Wheat", Price = 260 },
				new Product { Id = 26, CategoryId = 4, Name = "Brioche", Price = 450 },
				new Product { Id = 27, CategoryId = 4, Name = "Naan", Price = 268 },
				new Product { Id = 28, CategoryId = 4, Name = "Focaccia", Price = 253 },
				new Product { Id = 29, CategoryId = 4, Name = "Malted", Price = 356 },
				new Product { Id = 30, CategoryId = 4, Name = "Sourdough", Price = 258 },
				new Product { Id = 31, CategoryId = 4, Name = "Corn", Price = 458 },
				new Product { Id = 32, CategoryId = 4, Name = "White", Price = 265 },
				new Product { Id = 33, CategoryId = 4, Name = "Soda", Price = 356 }
			});


				db.SaveChanges();
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(LoginField.Text) || string.IsNullOrEmpty(PasswordField.Text))
			{
				
				if (string.IsNullOrEmpty(LoginField.Text))
				{
					labelErrorSurName.ForeColor = Color.Red;
					labelErrorSurName.Text = "Поле обов'язкове";
				}
				else
				{
					labelErrorSurName.Text = "";
				}
				if (string.IsNullOrEmpty(PasswordField.Text))
				{
					labelErrorPass.ForeColor = Color.Red;
					labelErrorPass.Text = "Поле обов'язкове";
				}
				else
				{
					labelErrorPass.Text = "";
				}
			}
			else
			{
				SeedInitialData();
				var user = db.Users.Where(u =>
				u.Login == LoginField.Text &&
				u.Password == PasswordField.Text).FirstOrDefault();
				LoginField.Text = "";
				PasswordField.Text = "";
				labelErrorName.Text = "";
				labelErrorSurName.Text = "";
				labelErrorPass.Text = "";
				if (user != null)
				{
					if (user.IsAdmin)
					{
						AdminForms adminForms = new AdminForms();
						adminForms.Show();

						this.Hide();
					}
					else
					{

						UserForms userForms = new UserForms(user.Id);
						userForms.Show();

						this.Hide();
					}
				}
				else
				{
					label1.ForeColor = Color.Red;
					label1.Text = "Невірний логін або пароль!";
				}

			}
		}

		private void FormAutorise_Load(object sender, EventArgs e)
		{
			ConfigData.LoadConfigData(this);
		}
	}
}
