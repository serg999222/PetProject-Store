using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Store.Views
{
	public partial class SettingsForm : Form
	{
		Form WatsForm;
		AdminForms AdminForms;
		UserForms UserForms;
		public SettingsForm(Form form)
		{
			InitializeComponent();
			WatsForm = form;
		}
		
	



		private void BackgroundButton_Click(object sender, EventArgs e)
		{
			if(WatsForm is AdminForms)
			{
				AdminForms = (AdminForms)WatsForm;
				string redString = string.Empty;
				string greenString = string.Empty;
				string blueString = string.Empty;

				using (ColorDialog colorDialog = new ColorDialog())
				{
					if (colorDialog.ShowDialog() == DialogResult.OK)
					{
						string colorName = colorDialog.Color.Name;
						var rgb = colorDialog.Color.ToArgb();

						byte a = (byte)((rgb >> 24) & 0xFF); // Альфа-канал (не використовується)
						byte r = (byte)((rgb >> 16) & 0xFF); // Червоний
						byte g = (byte)((rgb >> 8) & 0xFF);  // Зелений
						byte b = (byte)(rgb & 0xFF);         // Синій

						redString = r.ToString();
						greenString = g.ToString();
						blueString = b.ToString();

						this.BackColor = colorDialog.Color;
						AdminForms.BackColor = colorDialog.Color;
					}
				}

				XmlDocument docConfig = LoadConfigDoc();
				XmlNode node = docConfig.SelectSingleNode("//appSettings");

				string[] keys = new string[]
				{
				"BackgroundColor.R",
				"BackgroundColor.G",
				"BackgroundColor.B"
				};
				string[] values = new string[]
				{
				redString,
				greenString,
				blueString
				};

				for (int i = 0; i < keys.Length; i++)
				{
					XmlElement element = node.SelectSingleNode(string.Format("//add[@key='{0}']", keys[i])) as XmlElement;

					if (element != null)
					{
						element.SetAttribute("value", values[i]);
					}
					else
					{
						element = docConfig.CreateElement("add");
						element.SetAttribute("key", keys[i]);
						element.SetAttribute("value", values[i]);
						node.AppendChild(element);

					}
				}
				docConfig.Save(Assembly.GetExecutingAssembly().Location + ".config");
			}
			else if(WatsForm is UserForms)
			{
				UserForms = (UserForms)WatsForm;
				string redString = string.Empty;
				string greenString = string.Empty;
				string blueString = string.Empty;

				using (ColorDialog colorDialog = new ColorDialog())
				{
					if (colorDialog.ShowDialog() == DialogResult.OK)
					{
						string colorName = colorDialog.Color.Name;
						var rgb = colorDialog.Color.ToArgb();

						byte a = (byte)((rgb >> 24) & 0xFF); // Альфа-канал (не використовується)
						byte r = (byte)((rgb >> 16) & 0xFF); // Червоний
						byte g = (byte)((rgb >> 8) & 0xFF);  // Зелений
						byte b = (byte)(rgb & 0xFF);         // Синій

						redString = r.ToString();
						greenString = g.ToString();
						blueString = b.ToString();

						this.BackColor = colorDialog.Color;
						UserForms.BackColor = colorDialog.Color;
					}
				}

				XmlDocument docConfig = LoadConfigDoc();
				XmlNode node = docConfig.SelectSingleNode("//appSettings");

				string[] keys = new string[]
				{
				"BackgroundColor.R",
				"BackgroundColor.G",
				"BackgroundColor.B"
				};
				string[] values = new string[]
				{
				redString,
				greenString,
				blueString
				};

				for (int i = 0; i < keys.Length; i++)
				{
					XmlElement element = node.SelectSingleNode(string.Format("//add[@key='{0}']", keys[i])) as XmlElement;

					if (element != null)
					{
						element.SetAttribute("value", values[i]);
					}
					else
					{
						element = docConfig.CreateElement("add");
						element.SetAttribute("key", keys[i]);
						element.SetAttribute("value", values[i]);
						node.AppendChild(element);

					}
				}
				docConfig.Save(Assembly.GetExecutingAssembly().Location + ".config");
			}
			else
			{
				MessageBox.Show("Помилка налаштування");
			}
			
			

		}

		private static XmlDocument LoadConfigDoc()
		{
			XmlDocument config = null;
			try
			{
				config = new XmlDocument();
				config.Load(Assembly.GetExecutingAssembly().Location + ".config");
				return config;
			}
			catch
			{
				throw new Exception("Конфігураційний файл не знайдено");
			}
		}
		private void SettingsForm_Load(object sender, EventArgs e)
		{
			var backgroundColorSetting = ConfigurationManager.AppSettings;
			if (backgroundColorSetting.Count < 1)
			{
				MessageBox.Show("Щось не так з налаштуваннями фону");
			}
			else
			{
				try
				{
					int red = Convert.ToInt32(backgroundColorSetting["BackgroundColor.R"]);
					int green = Convert.ToInt32(backgroundColorSetting["BackgroundColor.G"]);
					int blue = Convert.ToInt32(backgroundColorSetting["BackgroundColor.B"]);
					this.BackColor = Color.FromArgb(red, green, blue);
				}
				catch
				{
					MessageBox.Show("Щось не так з налаштуваннями фону");
				}
			}

		}
	}
}
