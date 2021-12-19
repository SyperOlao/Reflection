using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClothShelf : Closet
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
