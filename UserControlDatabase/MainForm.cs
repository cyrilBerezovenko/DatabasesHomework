using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace UserControlDatabase {
	public partial class MainForm : Form {

		public List<Student> list { get; private set; }
		public BindingSource bs;

		public MainForm() {
			InitializeComponent();
		}

		private void LoadData() {
			XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

			using (FileStream fs = new FileStream("../../data.xml", FileMode.Open))
				list = (List<Student>)serializer.Deserialize(fs);

			bs = new BindingSource();
			bs.DataSource = list;
			studentListBox.DataSource = bs;
		}

		private void SaveData() {
			XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
			using (FileStream fs = new FileStream("../../data.xml", FileMode.Truncate))
				serializer.Serialize(fs, list);
		}

		private void addButton_Click(object sender, EventArgs e) {
			AddForm addForm = new AddForm(this);
			addForm.ShowDialog();
		}

		private void editButton_Click(object sender, EventArgs e) {
			EditForm editForm = new EditForm(this);
			editForm.ShowDialog();
		}

		private void deleteButton_Click(object sender, EventArgs e) {
			if (studentListBox.SelectedItem == null) return;
			bs.RemoveAt(studentListBox.SelectedIndex);
		}

		private void MainForm_Load(object sender, EventArgs e) =>
			LoadData();

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) =>
			SaveData();
	}
}
