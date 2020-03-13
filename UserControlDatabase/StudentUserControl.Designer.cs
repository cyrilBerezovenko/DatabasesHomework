namespace UserControlDatabase {
	partial class StudentUserControl {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.idLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.SelectImageButton = new System.Windows.Forms.Button();
			this.RemoveImageButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// idTextBox
			// 
			this.idTextBox.Location = new System.Drawing.Point(85, 14);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(100, 20);
			this.idTextBox.TabIndex = 0;
			this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Location = new System.Drawing.Point(85, 69);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
			this.surnameTextBox.TabIndex = 1;
			this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(85, 43);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(100, 20);
			this.nameTextBox.TabIndex = 2;
			this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(3, 17);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(15, 13);
			this.idLabel.TabIndex = 3;
			this.idLabel.Text = "id";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(3, 43);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(33, 13);
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "name";
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(3, 69);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(47, 13);
			this.surnameLabel.TabIndex = 5;
			this.surnameLabel.Text = "surname";
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(210, 17);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(100, 72);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 6;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// SelectImageButton
			// 
			this.SelectImageButton.Location = new System.Drawing.Point(210, 107);
			this.SelectImageButton.Name = "SelectImageButton";
			this.SelectImageButton.Size = new System.Drawing.Size(100, 23);
			this.SelectImageButton.TabIndex = 7;
			this.SelectImageButton.Text = "Select Image...";
			this.SelectImageButton.UseVisualStyleBackColor = true;
			this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
			// 
			// RemoveImageButton
			// 
			this.RemoveImageButton.Location = new System.Drawing.Point(316, 17);
			this.RemoveImageButton.Name = "RemoveImageButton";
			this.RemoveImageButton.Size = new System.Drawing.Size(22, 23);
			this.RemoveImageButton.TabIndex = 8;
			this.RemoveImageButton.Text = "-";
			this.RemoveImageButton.UseVisualStyleBackColor = true;
			this.RemoveImageButton.Click += new System.EventHandler(this.RemoveImageButton_Click);
			// 
			// StudentUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.RemoveImageButton);
			this.Controls.Add(this.SelectImageButton);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.surnameLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(this.idTextBox);
			this.Name = "StudentUserControl";
			this.Size = new System.Drawing.Size(354, 133);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button SelectImageButton;
		private System.Windows.Forms.Button RemoveImageButton;
	}
}
