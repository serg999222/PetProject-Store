namespace Store.Views
{
	partial class UserForms
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
			this.UserOrdersDataGried = new System.Windows.Forms.DataGridView();
			this.AddToCartButton = new System.Windows.Forms.Button();
			this.Counter = new System.Windows.Forms.DomainUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.CartGridView = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.ProductsComboBox = new System.Windows.Forms.ComboBox();
			this.OrderButton = new System.Windows.Forms.Button();
			this.ErrorTextLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TotalSummLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.UserOrdersDataGried)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// UserOrdersDataGried
			// 
			this.UserOrdersDataGried.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UserOrdersDataGried.Location = new System.Drawing.Point(12, 12);
			this.UserOrdersDataGried.Name = "UserOrdersDataGried";
			this.UserOrdersDataGried.Size = new System.Drawing.Size(776, 150);
			this.UserOrdersDataGried.TabIndex = 1;
			// 
			// AddToCartButton
			// 
			this.AddToCartButton.Location = new System.Drawing.Point(28, 313);
			this.AddToCartButton.Name = "AddToCartButton";
			this.AddToCartButton.Size = new System.Drawing.Size(106, 23);
			this.AddToCartButton.TabIndex = 7;
			this.AddToCartButton.Text = "Додати в кошик";
			this.AddToCartButton.UseVisualStyleBackColor = true;
			this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
			// 
			// Counter
			// 
			this.Counter.Location = new System.Drawing.Point(28, 278);
			this.Counter.Name = "Counter";
			this.Counter.Size = new System.Drawing.Size(138, 20);
			this.Counter.TabIndex = 8;
			this.Counter.Text = "1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 262);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Кількість";
			// 
			// CartGridView
			// 
			this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CartGridView.Location = new System.Drawing.Point(214, 222);
			this.CartGridView.Name = "CartGridView";
			this.CartGridView.Size = new System.Drawing.Size(470, 114);
			this.CartGridView.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(211, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Кошик";
			// 
			// ProductsComboBox
			// 
			this.ProductsComboBox.FormattingEnabled = true;
			this.ProductsComboBox.Location = new System.Drawing.Point(28, 222);
			this.ProductsComboBox.Name = "ProductsComboBox";
			this.ProductsComboBox.Size = new System.Drawing.Size(180, 21);
			this.ProductsComboBox.TabIndex = 12;
			// 
			// OrderButton
			// 
			this.OrderButton.Location = new System.Drawing.Point(690, 248);
			this.OrderButton.Name = "OrderButton";
			this.OrderButton.Size = new System.Drawing.Size(101, 23);
			this.OrderButton.TabIndex = 13;
			this.OrderButton.Text = "Замовити";
			this.OrderButton.UseVisualStyleBackColor = true;
			this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
			// 
			// ErrorTextLabel
			// 
			this.ErrorTextLabel.AutoSize = true;
			this.ErrorTextLabel.Location = new System.Drawing.Point(25, 196);
			this.ErrorTextLabel.Name = "ErrorTextLabel";
			this.ErrorTextLabel.Size = new System.Drawing.Size(0, 13);
			this.ErrorTextLabel.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(690, 206);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "До сплати";
			// 
			// TotalSummLabel
			// 
			this.TotalSummLabel.AutoSize = true;
			this.TotalSummLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.TotalSummLabel.Location = new System.Drawing.Point(690, 222);
			this.TotalSummLabel.MinimumSize = new System.Drawing.Size(80, 0);
			this.TotalSummLabel.Name = "TotalSummLabel";
			this.TotalSummLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.TotalSummLabel.Size = new System.Drawing.Size(80, 23);
			this.TotalSummLabel.TabIndex = 17;
			this.TotalSummLabel.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.label2.Location = new System.Drawing.Point(767, 222);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label2.Size = new System.Drawing.Size(24, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "грн";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Виберіть Продукт";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(693, 330);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "Налаштування";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// UserForms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TotalSummLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ErrorTextLabel);
			this.Controls.Add(this.OrderButton);
			this.Controls.Add(this.ProductsComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CartGridView);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Counter);
			this.Controls.Add(this.AddToCartButton);
			this.Controls.Add(this.UserOrdersDataGried);
			this.Name = "UserForms";
			this.Text = "UserForms";
			this.Load += new System.EventHandler(this.UserForms_Load);
			((System.ComponentModel.ISupportInitialize)(this.UserOrdersDataGried)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.DataGridView UserOrdersDataGried;
		private System.Windows.Forms.Button AddToCartButton;
		private System.Windows.Forms.DomainUpDown Counter;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView CartGridView;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox ProductsComboBox;
		private System.Windows.Forms.Button OrderButton;
		private System.Windows.Forms.Label ErrorTextLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label TotalSummLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}