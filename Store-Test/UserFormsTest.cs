using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Store;
using Store.Models;
using Store.Views;
using System.Windows.Forms;

namespace Store_Test
{
	[TestClass]
	public class UserFormsTest
	{
		[TestMethod]
		public async Task ShouldGenerateFile()
		{
			// Arrange
			var form = new UserForms(2);
			Order newOrder = new Order
			{
				UserId = 2,
				Products = new List<Product>
				{
					new Product { Name = "Product 1", Price = 10.0m },
					new Product { Name = "Product 2", Price = 20.0m }
				},
				TotalPrice = 30,
				User = new User
				{
					Id= 2,
					Name = "Dasha",
					SurName = "Бут",					
				},
			};
			
			//Act
			form.GenerateAndOpenFileAsync(newOrder);


			// Assert
			// Перевіряю, чи було створено файл і чи вміщає він очікувану інформацію
			string directoryPath = Path.Combine("C:\\", "temp");
			if (!Directory.Exists(directoryPath))
			{
				Directory.CreateDirectory(directoryPath);
			}
			string filePath = Path.Combine(directoryPath, "order.txt");
			Assert.IsTrue(File.Exists(filePath));

			string[] fileLines = File.ReadAllLines(filePath);
			Assert.IsTrue(fileLines.Length > 0);
			
		}

		/*[TestMethod]*/
		/*public async Task ShouldCreateOrder()
		{
			// Arrange
			var form = new UserForms(2);
			//Корзина
			var cart = new List<Product>
			{
				new Product { Name = "Product 1", Price = 10.0m },
				new Product { Name = "Product 2", Price = 20.0m }
			};

			form.cart = cart;
			form.Id = 2;

			// Act
			//Викликаємо обробник подій для створення замовлення
			form.OrderButton_Click(null, EventArgs.Empty);

			// Assert
			// Перевірте, чи створено замовлення
			Assert.AreEqual(1, form.UserOrdersDataGried.Rows.Count);

		}*/
	}
}
