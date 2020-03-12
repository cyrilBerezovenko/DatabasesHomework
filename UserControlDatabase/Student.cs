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

		public Student() { }

		public Student(string id, string name, string surname) {
			this.id = id;
			this.name = name;
			this.surname = surname;
		}

		public override string ToString() => 
			surname ?? "<unnamed>";

		public Student Clone() {
			Student other = new Student();
			other.id = id;
			other.name = name;
			other.surname = surname;
			return other;
		}
	}
}
