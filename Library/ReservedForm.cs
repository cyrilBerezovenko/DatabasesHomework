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

	public partial class ReservedForm : Form {

		private MainForm mainForm;
		private DataTable storageTable { get => mainForm.storage.table; }
		private DataTable reservedTable { get => mainForm.reserved.table; }
		private DataTable usersTable { get => mainForm.users.table; }

		public ReservedForm(MainForm mainForm) {
			InitializeComponent();

			this.mainForm = mainForm;
			gridView.DataSource = reservedTable;
		}

		private void ReservedForm_FormClosing(object sender, FormClosingEventArgs e) =>
			mainForm.reserved.SaveData();
	}
}
