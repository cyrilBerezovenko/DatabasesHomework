using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library {

	public partial class UsersForm : Form {

		private MainForm mainForm;
		private DataTable storageTable { get => mainForm.storage.table; }
		private DataTable reservedTable { get => mainForm.reserved.table; }
		private DataTable usersTable { get => mainForm.users.table; }

		public UsersForm(MainForm mainForm) {
			InitializeComponent();

			this.mainForm = mainForm;
			gridView.DataSource = usersTable;
		}

		private void UsersForm_FormClosing(object sender, FormClosingEventArgs e) {
			mainForm.users.SaveData();
		}
	}
}
