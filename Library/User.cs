using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {

	[Serializable]
	public class User {

		public string Name { get; set; }
		public List<Book> Books { get; set; }

		public User() { }

		public User(string name, List<Book> books) {
			Name = name;
			Books = books;
		}
	}
}
