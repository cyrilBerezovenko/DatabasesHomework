namespace Library {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.storageButton = new System.Windows.Forms.Button();
			this.reservedButton = new System.Windows.Forms.Button();
			this.usersButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// storageButton
			// 
			this.storageButton.Location = new System.Drawing.Point(40, 40);
			this.storageButton.Name = "storageButton";
			this.storageButton.Size = new System.Drawing.Size(100, 50);
			this.storageButton.TabIndex = 0;
			this.storageButton.Text = "Storage";
			this.storageButton.UseVisualStyleBackColor = true;
			this.storageButton.Click += new System.EventHandler(this.storageButton_Click);
			// 
			// reservedButton
			// 
			this.reservedButton.Location = new System.Drawing.Point(170, 40);
			this.reservedButton.Name = "reservedButton";
			this.reservedButton.Size = new System.Drawing.Size(100, 50);
			this.reservedButton.TabIndex = 1;
			this.reservedButton.Text = "Reserved";
			this.reservedButton.UseVisualStyleBackColor = true;
			this.reservedButton.Click += new System.EventHandler(this.reservedButton_Click);
			// 
			// usersButton
			// 
			this.usersButton.Location = new System.Drawing.Point(300, 40);
			this.usersButton.Name = "usersButton";
			this.usersButton.Size = new System.Drawing.Size(100, 50);
			this.usersButton.TabIndex = 2;
			this.usersButton.Text = "Users";
			this.usersButton.UseVisualStyleBackColor = true;
			this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 131);
			this.Controls.Add(this.usersButton);
			this.Controls.Add(this.reservedButton);
			this.Controls.Add(this.storageButton);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button storageButton;
		private System.Windows.Forms.Button reservedButton;
		private System.Windows.Forms.Button usersButton;
	}
}