using System.Collections.Generic;

namespace ClassLibrary2
{
    public class ClothShelf: Closet
    {
        private List<string> cloth = new List<string>();

        private int MaxCloth { get; set; }
        public ClothShelf(string material, int numOfShelves, int numOfDoors) : base(material, numOfShelves, numOfDoors)
        {
            MaxCloth = 25;
        }

        public override string ToString()
        {
            return "Количество дверей: " + NumOfDoors + "\nКоличество полок: " + NumOfShelves + "\nЛежит вещей: " + cloth.Count;
        }
    }
}