using Store.Models;
using Store.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Views
{
	public partial class UserForms : Form
	{

		public int Id { get; set; }
		StoreDbContext db;
		public List<Product> cart { get; set; }
		public decimal TotalCartSumm { get; set; }
		string[] products;
		private List<Product> cartForOrderTicket;
		public UserForms(int id)
		{
			InitializeComponent();
			db = new StoreDbContext();
			Id = id;
			cart = new List<Product>();
			cartForOrderTicket = new List<Product>();
			TotalCartSumm = 0;
		    products = db.Products.Select(i => i.Name).ToArray(); 
			
		}

		private void UserForms_Load(object sender, EventArgs e)
		{
			ConfigData.LoadConfigData(this);
			CartGridView.DataSource = cart;
			
			TotalSummLabel.Text = TotalCartSumm.ToString();
			UserOrdersDataGried.DataSource = db.Orders.Local.Where(o => o.UserId == Id).ToList();
			for (int i = 0; i < 10; i++)
			{
				Counter.Items.Add($"{i + 1}");
			}
			Counter.SelectedItem = "1";
			ProductsComboBox.DataSource = products;


		}

		private void AddToCartButton_Click(object sender, EventArgs e)
		{
			Product productChange = db.Products.FirstOrDefault(p => p.Name == ProductsComboBox.SelectedItem);
			string count = Counter.SelectedItem as string;
			if(productChange != null && count != null)
			{
				decimal total = productChange.Price * Convert.ToDecimal(count);
				TotalCartSumm += total;
				for (int i = 0; i < Convert.ToInt32(count); i++)
				{
					cart.Add(productChange);
				}
				CartGridView.DataSource = null;
				CartGridView.DataSource = cart;
				TotalSummLabel.Text = TotalCartSumm.ToString();
				Counter.SelectedItem = "1";
				ProductsComboBox.DataSource = null;
				ProductsComboBox.DataSource = products;
			}
			else
			{
				ErrorTextLabel.Text = "Спочатку зробіть свій вибір";
			}
		}
		public async void GenerateAndOpenFileAsync(Order newOrder )
		{
			try
			{
				string directoryPath = Path.Combine("C:\\", "temp");
				if (!Directory.Exists(directoryPath))
				{
					Directory.CreateDirectory(directoryPath);
				}

				string filePath = Path.Combine(directoryPath, "order.txt");

				using (StreamWriter writer = new StreamWriter(filePath))
				{
					await writer.WriteLineAsync($"Замовлення номер: {newOrder.Id}");
					await writer.WriteLineAsync($"Покупець: {newOrder.User.Name} {newOrder.User.SurName}");
					await writer.WriteLineAsync($"Загальна сумма: {newOrder.TotalPrice}");
					await writer.WriteLineAsync($"Дата та час здійснення операції: {newOrder.DateTime}");
					await writer.WriteLineAsync($"Перелік Товарів:");
					foreach (Product product in cartForOrderTicket)
					{
						await writer.WriteLineAsync($"{product.Name}, Ціна - {product.Price}");
					}

				}

				System.Diagnostics.Process.Start(filePath); // Відкриваємо файл
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void OrderButton_Click(object sender, EventArgs e)
		{
			Order newOrder = new Order
			{
				UserId = Id,
				Products = cart,
				TotalPrice = TotalCartSumm,
				User = db.Users.FirstOrDefault(c => c.Id == Id),				
			};
			db.Orders.Add(newOrder);
			db.SaveChanges();
			UserOrdersDataGried.DataSource = null;
			UserOrdersDataGried.DataSource = db.Orders.Local.Where(o => o.UserId == Id).ToList();
			foreach(Product product1 in cart)
			{
				cartForOrderTicket.Add(product1);
			}
			cart.Clear();
			CartGridView.DataSource = null;
			CartGridView.DataSource = cart;
			TotalSummLabel.Text = "0";
			TotalCartSumm = 0;
			
			 GenerateAndOpenFileAsync(newOrder);
		}

		private void button1_Click(object sender, EventArgs e)
		{			
			SettingsForm settingsForm = new SettingsForm(this);
			settingsForm.Show();			
		}
	}
}
