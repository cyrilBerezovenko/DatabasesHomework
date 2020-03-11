using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDatabase {

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
	}
}
