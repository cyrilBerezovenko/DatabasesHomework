using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDatabase {
	public partial class EditForm : Form {

		private Student student;
		private StudentUserControl uc;
		private MainForm mainForm;

		public EditForm(MainForm mainForm) {
			InitializeComponent();

			KeyPreview = true;
			this.mainForm = mainForm;
			Student student = (Student)mainForm.studentListBox.SelectedItem;
			StudentUserControl uc = new StudentUserControl(student);
			this.student = student;
			this.uc = uc;
			panel.Controls.Add(uc);
		}

		private void saveButton_Click(object sender, EventArgs e) =>
			Close();

		private void EditForm_FormClosing(object sender, FormClosingEventArgs e) {
			mainForm.bs.ResetItem(mainForm.studentListBox.SelectedIndex);
		}

		private void EditForm_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Return)
				Close();
		}
	}
}
