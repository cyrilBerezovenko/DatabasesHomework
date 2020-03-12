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


		public MainForm() {
			InitializeComponent();
			KeyPreview = true;
		}

		private void LoadData() {
			XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

			List<Student> list = new List<Student>();
			using (FileStream fs = new FileStream("../../data.xml", FileMode.Open))
				list = (List<Student>)serializer.Deserialize(fs);

			foreach (Student st in list) 
				studentListBox.Items.Add(st);
		}

		private void SaveData() {

			List<Student> list = new List<Student>();
			foreach (var it in studentListBox.Items)
				list.Add((Student)it);

			XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
			using (FileStream fs = new FileStream("../../data.xml", FileMode.Truncate))
				serializer.Serialize(fs, list);
		}

		public void AddItem(Student student) {
			studentListBox.Items.Add(student);
		}

		private void SelectItem() {
			panel1.Controls.Clear();
			if (studentListBox.SelectedItem == null) return;
			Student student = (Student)studentListBox.SelectedItem;
			StudentUserControl uc = new StudentUserControl(student.Clone());
			panel1.Controls.Add(uc);
		}

		public void SaveStudent() {
			if (studentListBox.SelectedItem == null || panel1.Controls.Count == 0) return;
			var items = studentListBox.Items;
			items[items.IndexOf(studentListBox.SelectedItem)] = ((StudentUserControl)panel1.Controls[0]).student;
		}

		private void addButton_Click(object sender, EventArgs e) {
			AddForm addForm = new AddForm(this);
			addForm.ShowDialog();
		}

		private void deleteButton_Click(object sender, EventArgs e) {
			if (studentListBox.SelectedItem == null) return;
			studentListBox.Items.Remove(studentListBox.SelectedItem);
		}

		private void studentListBox_SelectedIndexChanged(object sender, EventArgs e) =>
			SelectItem();

		private void studentListBox_Click(object sender, EventArgs e) =>
			SelectItem();

		private void MainForm_Load(object sender, EventArgs e) =>
			LoadData();

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) =>
			SaveData();

		private void saveButton_Click(object sender, EventArgs e) =>
			SaveStudent();

		private void MainForm_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Return)
				SaveStudent();
		}
	}
}
