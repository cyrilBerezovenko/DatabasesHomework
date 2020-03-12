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
	}
}
