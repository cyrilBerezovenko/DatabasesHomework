using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDatabase {

	[Serializable]
	public class Student {

		public string id;
		public string name;
		public string surname;
		public string imageLocation;

		public Student() { }

		public Student(string id, string name, string surname, string imageLocation) {
			this.id = id;
			this.name = name;
			this.surname = surname;
			this.imageLocation = imageLocation;
		}

		public override string ToString() =>
			surname == "" || surname == null ? "<unnamed>" : surname;
	}
}
