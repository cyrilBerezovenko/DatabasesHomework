using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library {
	public partial class TableSelector : UserControl {

		public DataGridViewRow selectedRow { get; private set; }

		public TableSelector(DataTable dataTable) {
			InitializeComponent();
			gridView.DataSource = dataTable;
		}

		private void selectButton_Click(object sender, EventArgs e) {
			if (gridView.SelectedRows.Count != 1) {
				MessageBox.Show("You should select one row");
				return;
			}
			selectedRow = gridView.SelectedRows[0];
			((Form)TopLevelControl).Close();
		}
	}
}
