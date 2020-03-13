namespace UserControlDatabase {
	partial class EditForm {
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
			this.panel = new System.Windows.Forms.Panel();
			this.saveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Location = new System.Drawing.Point(23, 12);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(354, 133);
			this.panel.TabIndex = 0;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(148, 160);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 195);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.panel);
			this.Name = "EditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EditForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditForm_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Button saveButton;
	}
}