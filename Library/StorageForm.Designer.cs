namespace Library {
	partial class StorageForm {
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
			this.gridView = new System.Windows.Forms.DataGridView();
			this.giveButton = new System.Windows.Forms.Button();
			this.reserveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// gridView
			// 
			this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView.Location = new System.Drawing.Point(22, 25);
			this.gridView.Name = "gridView";
			this.gridView.Size = new System.Drawing.Size(560, 280);
			this.gridView.TabIndex = 0;
			// 
			// giveButton
			// 
			this.giveButton.Location = new System.Drawing.Point(136, 358);
			this.giveButton.Name = "giveButton";
			this.giveButton.Size = new System.Drawing.Size(100, 50);
			this.giveButton.TabIndex = 1;
			this.giveButton.Text = "Give";
			this.giveButton.UseVisualStyleBackColor = true;
			this.giveButton.Click += new System.EventHandler(this.giveButton_Click);
			// 
			// reserveButton
			// 
			this.reserveButton.Location = new System.Drawing.Point(313, 358);
			this.reserveButton.Name = "reserveButton";
			this.reserveButton.Size = new System.Drawing.Size(100, 50);
			this.reserveButton.TabIndex = 2;
			this.reserveButton.Text = "Reserve";
			this.reserveButton.UseVisualStyleBackColor = true;
			// 
			// StorageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 431);
			this.Controls.Add(this.reserveButton);
			this.Controls.Add(this.giveButton);
			this.Controls.Add(this.gridView);
			this.Name = "StorageForm";
			this.Text = "StorageForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StorageForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Button giveButton;
		private System.Windows.Forms.Button reserveButton;
	}
}