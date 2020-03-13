using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDatabase {
	public partial class StudentUserControl : UserControl {

		public Student student;

		public StudentUserControl(Student student) {
			InitializeComponent();

			this.student = student;
			idTextBox.Text = student.id;
			nameTextBox.Text = student.name;
			surnameTextBox.Text = student.surname;
			pictureBox.ImageLocation = student.imageLocation;
		}

		private void idTextBox_TextChanged(object sender, EventArgs e) {
			student.id = idTextBox.Text;
		}

		private void nameTextBox_TextChanged(object sender, EventArgs e) {
			student.name = nameTextBox.Text;
		}

		private void surnameTextBox_TextChanged(object sender, EventArgs e) {
			student.surname = surnameTextBox.Text;
		}

		private void RemoveImageButton_Click(object sender, EventArgs e) {
			student.imageLocation = null;
			pictureBox.ImageLocation = null;
		}

		private void SelectImageButton_Click(object sender, EventArgs e) {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
			if (dialog.ShowDialog() != DialogResult.OK) return;
			student.imageLocation = dialog.FileName;
			pictureBox.ImageLocation = dialog.FileName;
		}

		private void pictureBox_Click(object sender, EventArgs e) {
			Form form = new Form();
			form.Size = pictureBox.Image.Size;
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.MaximizeBox = form.MinimizeBox = false;
			form.StartPosition = FormStartPosition.CenterScreen;

			var box = new PictureBox();
			box.ImageLocation = pictureBox.ImageLocation;
			box.Size = pictureBox.Image.Size;
			form.Controls.Add(box);
			form.ShowDialog();
		}
	}
}
