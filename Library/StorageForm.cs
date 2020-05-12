using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Library {

	public partial class StorageForm : Form {

		private MainForm mainForm;
		private DataTable storageTable { get => mainForm.storage.table; }
		private DataTable reservedTable { get => mainForm.reserved.table; }
		private DataTable usersTable { get => mainForm.users.table; }

		public StorageForm(MainForm mainForm) {
			InitializeComponent();

			this.mainForm = mainForm;
			gridView.DataSource = storageTable;
		}

		private void StorageForm_FormClosing(object sender, FormClosingEventArgs e) =>
			mainForm.storage.SaveData();

		private void giveButton_Click(object sender, EventArgs e) {
			if (gridView.SelectedRows.Count != 1) {
				MessageBox.Show("You should select one row");
				return;
			}

			TableSelector selector = new TableSelector(usersTable);
			Form form = new Form();
			form.Controls.Add(selector);
			form.ShowDialog();

			DataGridViewRow userRow = selector.selectedRow;
			DataGridViewRow bookRow = gridView.SelectedRows[0];

			((List<Book>)userRow.Cells[1].Value).Add((Book)bookRow.DataBoundItem);
		}
	}
}
