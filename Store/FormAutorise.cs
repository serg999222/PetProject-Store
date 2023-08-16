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
