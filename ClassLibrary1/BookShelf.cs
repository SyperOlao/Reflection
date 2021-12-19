using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BookShelf : Closet
    {
        readonly List<string> _books = new List<string>();

        private int MaxBooks { get; set; }

        public BookShelf(string material, int numOfShelves, int numOfDoors) : base(material, numOfShelves, numOfDoors)
        {
            MaxBooks = 10;
        }

        public override string ToString()
        {
            return "Количество дверей: " + NumOfDoors + "\nКоличество полок: " + NumOfShelves + "\nЛежит книг: " + _books.Count;
        }
    }
}
