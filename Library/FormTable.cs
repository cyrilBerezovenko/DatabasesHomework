using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Library {

	public class FormTable {

		public string file;
		public DataTable table { get; private set; }

		public FormTable(string file) {
			this.file = file;
			LoadData();
		}

		public void LoadData() {
			XmlReader reader;
			reader = XmlReader.Create(file, new XmlReaderSettings());
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			table = dataSet.Tables[0];
			reader.Close();
		}

		public void SaveData() {
			table.WriteXml(file);
		}
	}
}
