using System.Collections.Generic;

namespace ClassLibrary2
{
    public class BookShelf: Closet
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