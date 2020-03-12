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

			this.mainForm = mainForm;
			student = new Student();
			uc = new StudentUserControl(student);
			panel1.Controls.Add(uc);
		}

		private void AddForm_FormClosed(object sender, FormClosedEventArgs e) {
			mainForm.AddItem(student);
		}

		private void button1_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
