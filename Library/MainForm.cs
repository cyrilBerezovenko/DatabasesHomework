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

	public partial class MainForm : Form {

		private StorageForm storageForm;
		private ReservedForm reservedForm;
		private UsersForm usersForm;

		public FormTable storage { get; private set; }
		public FormTable reserved { get; private set; }
		public FormTable users { get; private set; }

		public MainForm() {
			InitializeComponent();

			storage = new FormTable("../../resources/storage.xml");
			reserved = new FormTable("../../resources/reserved.xml");
			users = new FormTable("../../resources/users.xml");

			storageForm = new StorageForm(this);
			reservedForm = new ReservedForm(this);
			usersForm = new UsersForm(this);
		}

		private void storageButton_Click(object sender, EventArgs e) {
			storageForm.ShowDialog();
		}

		private void reservedButton_Click(object sender, EventArgs e) {
			reservedForm.ShowDialog();
		}

		private void usersButton_Click(object sender, EventArgs e) {
			usersForm.ShowDialog();
		}
	}
}
