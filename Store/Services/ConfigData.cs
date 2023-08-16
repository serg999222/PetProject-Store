using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Services
{
	public class ConfigData
	{
		public static void LoadConfigData(Form form)
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
					form.BackColor = Color.FromArgb(red, green, blue);
				}
				catch
				{
					MessageBox.Show("Щось не так з налаштуваннями фону");
				}
			}
		}
	}
}
