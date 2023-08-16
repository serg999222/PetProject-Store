namespace Store.Views
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BackgroundButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BackgroundButton
			// 
			this.BackgroundButton.Location = new System.Drawing.Point(50, 57);
			this.BackgroundButton.Name = "BackgroundButton";
			this.BackgroundButton.Size = new System.Drawing.Size(75, 23);
			this.BackgroundButton.TabIndex = 0;
			this.BackgroundButton.Text = "Background";
			this.BackgroundButton.UseVisualStyleBackColor = true;
			this.BackgroundButton.Click += new System.EventHandler(this.BackgroundButton_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(183, 268);
			this.Controls.Add(this.BackgroundButton);
			this.Location = new System.Drawing.Point(300, 0);
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BackgroundButton;
	}
}