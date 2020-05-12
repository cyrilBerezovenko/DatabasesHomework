using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {

	[Serializable]
	public class Book {

		public string Name { get; set; }
		public string Author { get; set; }
		public Genre Genre { get; set; }
		public Language Language { get; set; }

		public Book() { }

		public Book(string name, string author, Genre genre, Language language) {
			Name = name;
			Author = author;
			Genre = genre;
			Language = language;
		}
	}
}
