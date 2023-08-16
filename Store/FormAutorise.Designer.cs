using System.Windows.Forms;

namespace Store
{
	partial class FormAutorise
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
			this.LoginField = new System.Windows.Forms.TextBox();
			this.labelSurName = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelErrorPass = new System.Windows.Forms.Label();
			this.labelErrorSurName = new System.Windows.Forms.Label();
			this.labelErrorName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PasswordField = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LoginField
			// 
			this.LoginField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LoginField.Location = new System.Drawing.Point(92, 75);
			this.LoginField.Multiline = true;
			this.LoginField.Name = "LoginField";
			this.LoginField.Size = new System.Drawing.Size(223, 22);
			this.LoginField.TabIndex = 1;
			// 
			// labelSurName
			// 
			this.labelSurName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelSurName.AutoSize = true;
			this.labelSurName.Location = new System.Drawing.Point(177, 59);
			this.labelSurName.Name = "labelSurName";
			this.labelSurName.Size = new System.Drawing.Size(34, 13);
			this.labelSurName.TabIndex = 3;
			this.labelSurName.Text = "Логін";
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Location = new System.Drawing.Point(147, 207);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 20);
			this.button1.TabIndex = 4;
			this.button1.Text = "Підтвердити";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelErrorPass);
			this.panel1.Controls.Add(this.labelErrorSurName);
			this.panel1.Controls.Add(this.labelErrorName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.PasswordField);
			this.panel1.Controls.Add(this.labelPassword);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.LoginField);
			this.panel1.Controls.Add(this.labelSurName);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(415, 270);
			this.panel1.TabIndex = 5;
			// 
			// labelErrorPass
			// 
			this.labelErrorPass.AutoSize = true;
			this.labelErrorPass.Location = new System.Drawing.Point(170, 185);
			this.labelErrorPass.Name = "labelErrorPass";
			this.labelErrorPass.Size = new System.Drawing.Size(0, 13);
			this.labelErrorPass.TabIndex = 11;
			// 
			// labelErrorSurName
			// 
			this.labelErrorSurName.AutoSize = true;
			this.labelErrorSurName.Location = new System.Drawing.Point(169, 99);
			this.labelErrorSurName.Name = "labelErrorSurName";
			this.labelErrorSurName.Size = new System.Drawing.Size(0, 13);
			this.labelErrorSurName.TabIndex = 10;
			// 
			// labelErrorName
			// 
			this.labelErrorName.AutoSize = true;
			this.labelErrorName.Location = new System.Drawing.Point(169, 42);
			this.labelErrorName.Name = "labelErrorName";
			this.labelErrorName.Size = new System.Drawing.Size(0, 13);
			this.labelErrorName.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(186, 230);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 8;
			// 
			// PasswordField
			// 
			this.PasswordField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PasswordField.Location = new System.Drawing.Point(92, 132);
			this.PasswordField.Multiline = true;
			this.PasswordField.Name = "PasswordField";
			this.PasswordField.Size = new System.Drawing.Size(223, 22);
			this.PasswordField.TabIndex = 6;
			// 
			// labelPassword
			// 
			this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(177, 117);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(45, 13);
			this.labelPassword.TabIndex = 7;
			this.labelPassword.Text = "Пароль";
			// 
			// FormAutorise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 270);
			this.Controls.Add(this.panel1);
			this.Name = "FormAutorise";
			this.Text = "Авторизація";
			this.Load += new System.EventHandler(this.FormAutorise_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private TextBox LoginField;
		private Label labelSurName;
		private Button button1;
		private Panel panel1;
		private TextBox PasswordField;
		private Label labelPassword;
		private Label label1;
		private Label labelErrorPass;
		private Label labelErrorSurName;
		private Label labelErrorName;
	}
}

