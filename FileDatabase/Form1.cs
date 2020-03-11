using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FileDatabase {
	public partial class Form1 : Form {

		public Form1() {
			InitializeComponent();
		}

		private void SaveData() {

			List<Student> list = new List<Student>();

			foreach (DataGridViewRow el in table.Rows) {
				var cells = el.Cells;
				Student st = new Student();
				st.id = cells["id"].FormattedValue.ToString();
				st.name = cells["name"].FormattedValue.ToString();
				st.surname = cells["surname"].FormattedValue.ToString();
				list.Add(st);
			}

			list.RemoveAt(list.Count - 1);

			XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

			using (FileStream fs = new FileStream("../../data.xml", FileMode.Truncate)) {
				try {
					serializer.Serialize(fs, list);
				} catch (Exception) { }
  			}
			
		}

		private void LoadData() {
			XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
			List<Student> list;

			using (FileStream fs = new FileStream("../../data.xml", FileMode.Open))
				list = (List<Student>)serializer.Deserialize(fs);
			
			foreach(Student st in list)
				table.Rows.Add(st.id, st.name, st.surname);
		}

		private void Form1_Load(object sender, EventArgs e) => LoadData();

		private void button1_Click(object sender, EventArgs e) => SaveData();

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) => SaveData();

	}
}
