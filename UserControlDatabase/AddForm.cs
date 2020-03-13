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
	public partial class AddForm : Form {

		private Student student;
		private StudentUserControl uc;
		private MainForm mainForm;

		public AddForm(MainForm mainForm) {
			InitializeComponent();

			KeyPreview = true;
			this.mainForm = mainForm;
			student = new Student();
			uc = new StudentUserControl(student);
		}

		private void AddForm_FormClosed(object sender, FormClosedEventArgs e) {
			mainForm.bs.Add(student);
		}

		private void addButton_Click(object sender, EventArgs e) {
			Close();
		}

		private void AddForm_Load(object sender, EventArgs e) {
			panel.Controls.Add(uc);
		}

		private void AddForm_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Return)
				Close();
		}
	}
}
