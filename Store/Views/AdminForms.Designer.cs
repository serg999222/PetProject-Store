namespace Store.Views
{
	partial class AdminForms
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
			this.OrderLabel = new System.Windows.Forms.Label();
			this.OrdersdataGridView = new System.Windows.Forms.DataGridView();
			this.ProductdataGridView = new System.Windows.Forms.DataGridView();
			this.ProductLabel = new System.Windows.Forms.Label();
			this.ManagerdataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.UserdataGridView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.AddUserButton = new System.Windows.Forms.Button();
			this.ChangeUserButton = new System.Windows.Forms.Button();
			this.DeleteUserButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.ErrorLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.IDtextBox = new System.Windows.Forms.TextBox();
			this.SettingsButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.LoginField = new System.Windows.Forms.TextBox();
			this.ManagerIdLabel = new System.Windows.Forms.Label();
			this.ManagerIdField = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.OrdersdataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ManagerdataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// OrderLabel
			// 
			this.OrderLabel.AutoSize = true;
			this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OrderLabel.Location = new System.Drawing.Point(61, 9);
			this.OrderLabel.Name = "OrderLabel";
			this.OrderLabel.Size = new System.Drawing.Size(129, 25);
			this.OrderLabel.TabIndex = 0;
			this.OrderLabel.Text = "Замовлення";
			// 
			// OrdersdataGridView
			// 
			this.OrdersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrdersdataGridView.Location = new System.Drawing.Point(12, 37);
			this.OrdersdataGridView.Name = "OrdersdataGridView";
			this.OrdersdataGridView.Size = new System.Drawing.Size(240, 150);
			this.OrdersdataGridView.TabIndex = 1;
			// 
			// ProductdataGridView
			// 
			this.ProductdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductdataGridView.Location = new System.Drawing.Point(276, 37);
			this.ProductdataGridView.Name = "ProductdataGridView";
			this.ProductdataGridView.Size = new System.Drawing.Size(240, 150);
			this.ProductdataGridView.TabIndex = 2;
			// 
			// ProductLabel
			// 
			this.ProductLabel.AutoSize = true;
			this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ProductLabel.Location = new System.Drawing.Point(338, 9);
			this.ProductLabel.Name = "ProductLabel";
			this.ProductLabel.Size = new System.Drawing.Size(102, 25);
			this.ProductLabel.TabIndex = 3;
			this.ProductLabel.Text = "Продукти";
			// 
			// ManagerdataGridView
			// 
			this.ManagerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ManagerdataGridView.Location = new System.Drawing.Point(548, 37);
			this.ManagerdataGridView.Name = "ManagerdataGridView";
			this.ManagerdataGridView.Size = new System.Drawing.Size(240, 150);
			this.ManagerdataGridView.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(616, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Менеджери";
			// 
			// UserdataGridView
			// 
			this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UserdataGridView.Location = new System.Drawing.Point(12, 229);
			this.UserdataGridView.Name = "UserdataGridView";
			this.UserdataGridView.Size = new System.Drawing.Size(387, 150);
			this.UserdataGridView.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Користувачі";
			// 
			// AddUserButton
			// 
			this.AddUserButton.Location = new System.Drawing.Point(578, 217);
			this.AddUserButton.Name = "AddUserButton";
			this.AddUserButton.Size = new System.Drawing.Size(191, 23);
			this.AddUserButton.TabIndex = 8;
			this.AddUserButton.Text = "Додати користувача";
			this.AddUserButton.UseVisualStyleBackColor = true;
			this.AddUserButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// ChangeUserButton
			// 
			this.ChangeUserButton.Location = new System.Drawing.Point(578, 258);
			this.ChangeUserButton.Name = "ChangeUserButton";
			this.ChangeUserButton.Size = new System.Drawing.Size(191, 23);
			this.ChangeUserButton.TabIndex = 9;
			this.ChangeUserButton.Text = "Змінити дані користувача";
			this.ChangeUserButton.UseVisualStyleBackColor = true;
			this.ChangeUserButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// DeleteUserButton
			// 
			this.DeleteUserButton.Location = new System.Drawing.Point(581, 300);
			this.DeleteUserButton.Name = "DeleteUserButton";
			this.DeleteUserButton.Size = new System.Drawing.Size(191, 23);
			this.DeleteUserButton.TabIndex = 10;
			this.DeleteUserButton.Text = "Видалити користувача";
			this.DeleteUserButton.UseVisualStyleBackColor = true;
			this.DeleteUserButton.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(415, 258);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(145, 20);
			this.textBox1.TabIndex = 11;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(415, 303);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(145, 20);
			this.textBox2.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(414, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Ім\'я";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(414, 287);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Прізвище";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(410, 409);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Пароль";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(413, 425);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(145, 20);
			this.textBox3.TabIndex = 15;
			// 
			// ErrorLabel
			// 
			this.ErrorLabel.AutoSize = true;
			this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.ErrorLabel.Location = new System.Drawing.Point(578, 192);
			this.ErrorLabel.Name = "ErrorLabel";
			this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
			this.ErrorLabel.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(414, 199);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Id";
			// 
			// IDtextBox
			// 
			this.IDtextBox.Location = new System.Drawing.Point(415, 217);
			this.IDtextBox.Name = "IDtextBox";
			this.IDtextBox.Size = new System.Drawing.Size(145, 20);
			this.IDtextBox.TabIndex = 18;
			// 
			// SettingsButton
			// 
			this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.SettingsButton.Location = new System.Drawing.Point(686, 415);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Size = new System.Drawing.Size(102, 23);
			this.SettingsButton.TabIndex = 20;
			this.SettingsButton.Text = "Налаштування";
			this.SettingsButton.UseVisualStyleBackColor = false;
			this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(412, 370);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "Логін";
			// 
			// LoginField
			// 
			this.LoginField.Location = new System.Drawing.Point(413, 386);
			this.LoginField.Name = "LoginField";
			this.LoginField.Size = new System.Drawing.Size(145, 20);
			this.LoginField.TabIndex = 21;
			// 
			// ManagerIdLabel
			// 
			this.ManagerIdLabel.AutoSize = true;
			this.ManagerIdLabel.Location = new System.Drawing.Point(412, 331);
			this.ManagerIdLabel.Name = "ManagerIdLabel";
			this.ManagerIdLabel.Size = new System.Drawing.Size(78, 13);
			this.ManagerIdLabel.TabIndex = 24;
			this.ManagerIdLabel.Text = "Id Менеджера";
			// 
			// ManagerIdField
			// 
			this.ManagerIdField.Location = new System.Drawing.Point(413, 347);
			this.ManagerIdField.Name = "ManagerIdField";
			this.ManagerIdField.Size = new System.Drawing.Size(145, 20);
			this.ManagerIdField.TabIndex = 23;
			// 
			// AdminForms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ManagerIdLabel);
			this.Controls.Add(this.ManagerIdField);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.LoginField);
			this.Controls.Add(this.SettingsButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.IDtextBox);
			this.Controls.Add(this.ErrorLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.DeleteUserButton);
			this.Controls.Add(this.ChangeUserButton);
			this.Controls.Add(this.AddUserButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.UserdataGridView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ManagerdataGridView);
			this.Controls.Add(this.ProductLabel);
			this.Controls.Add(this.ProductdataGridView);
			this.Controls.Add(this.OrdersdataGridView);
			this.Controls.Add(this.OrderLabel);
			this.Name = "AdminForms";
			this.Text = "AdminForms";
			this.Load += new System.EventHandler(this.AdminForms_Load);
			((System.ComponentModel.ISupportInitialize)(this.OrdersdataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ManagerdataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label OrderLabel;
		private System.Windows.Forms.DataGridView OrdersdataGridView;
		private System.Windows.Forms.DataGridView ProductdataGridView;
		private System.Windows.Forms.Label ProductLabel;
		private System.Windows.Forms.DataGridView ManagerdataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView UserdataGridView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button AddUserButton;
		private System.Windows.Forms.Button ChangeUserButton;
		private System.Windows.Forms.Button DeleteUserButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label ErrorLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox IDtextBox;
		private System.Windows.Forms.Button SettingsButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox LoginField;
		private System.Windows.Forms.Label ManagerIdLabel;
		private System.Windows.Forms.TextBox ManagerIdField;
	}
}