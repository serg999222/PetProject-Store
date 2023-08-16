using Store.Models;
using Store.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Store.Views
{
	public partial class AdminForms : Form
	{
		private StoreDbContext db;
		public AdminForms()
		{
			InitializeComponent();
		    db = new StoreDbContext();
		}
		
		public void AdminForms_Load(object sender, EventArgs e)
		{

			ConfigData.LoadConfigData(this);

			db.Orders.Load();
			OrdersdataGridView.DataSource = db.Orders.Local.ToBindingList();

			db.Products.Load();
			ProductdataGridView.DataSource = db.Products.Local.ToBindingList();

			db.Managers.Load();
			ManagerdataGridView.DataSource = db.Managers.Local.ToBindingList();

			db.Users.Load();
			UserdataGridView.DataSource = db.Users.Local.ToBindingList();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty && LoginField.Text != String.Empty && ManagerIdField.Text != String.Empty)
			{
				int managerId;
				if (int.TryParse(ManagerIdField.Text, out managerId))
				{
					Manager manager = db.Managers.FirstOrDefault(m => m.Id == managerId);
					if(manager != null)
					{
						User newUser = new User()
						{
							Name = textBox1.Text,
							SurName = textBox2.Text,
							Password = textBox3.Text,
							Login = LoginField.Text,
							ManagerId = managerId
						};
						db.Users.Add(newUser);
						db.SaveChanges();
						UserdataGridView.Refresh();
						IDtextBox.Text = String.Empty;
						textBox1.Text = String.Empty;
						textBox2.Text = String.Empty;
						textBox3.Text = String.Empty;
						ErrorLabel.Text = String.Empty;
						LoginField.Text = String.Empty;
						ManagerIdField.Text = String.Empty;
					}
					else
					{
						ErrorLabel.Text = "Такого менеджера не існує";
					}
					
				}
				else
				{
					ErrorLabel.Text = "Поле \"Id Менеджера\" заповнено не коректно";
				}
				
			}
			else
			{
				ErrorLabel.Text = "Не всі поля заповнені!";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(!(string.IsNullOrEmpty(IDtextBox.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(LoginField.Text)))
			{

				int id;
				if (int.TryParse(IDtextBox.Text,out id))
				{
					var user = db.Users.FirstOrDefault(u => u.Id == id);
					if(user != null)
					{
						User UpdateUser = new User()
						{
							Id = id,
							Name = textBox1.Text,
							SurName = textBox2.Text,
							Password = textBox3.Text,
							Login = LoginField.Text
						};
						db.Users.AddOrUpdate(UpdateUser);
						db.SaveChanges();
						UserdataGridView.Refresh();
						IDtextBox.Text = String.Empty;
						textBox1.Text = String.Empty;
						textBox2.Text = String.Empty;
						textBox3.Text = String.Empty;
						ErrorLabel.Text = String.Empty;
						LoginField.Text = String.Empty;
						ManagerIdField.Text = String.Empty;
					}
					else
					{
						ErrorLabel.Text = "Такого користувача не знайдено";
					}
					
				}
				else
				{
					ErrorLabel.Text = "Не вірний ввід поля Id";
				}
				
			}
			else
			{
				ErrorLabel.Text = "Не всі поля заповнені!";
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(IDtextBox.Text))
			{
				int id;
				if (int.TryParse(IDtextBox.Text, out id))
				{
					var deleteUser = db.Users.FirstOrDefault(u => u.Id == id);
					if (deleteUser != null)
					{
						db.Users.Remove(deleteUser);
						db.SaveChanges();
						UserdataGridView.Refresh();
						IDtextBox.Text = String.Empty;
						textBox1.Text = String.Empty;
						textBox2.Text = String.Empty;
						textBox3.Text = String.Empty;
						ErrorLabel.Text = String.Empty;
						LoginField.Text = String.Empty;
						ManagerIdField.Text = String.Empty;
					}
					else
					{
						ErrorLabel.Text = $"Користувача з Id = {id} не знайдено";					}
				}
			}
			else
			{
				ErrorLabel.Text = "Поле Id обов'язкове для видалення";
			}
		}

		private void SettingsButton_Click(object sender, EventArgs e)
		{
			SettingsForm settingsForm = new SettingsForm(this);
			settingsForm.Show();
		}

	
	}
}
