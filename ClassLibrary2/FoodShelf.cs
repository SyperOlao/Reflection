using System;
using System.Collections.Generic;

namespace ClassLibrary2
{
    public class FoodShelf: Closet
    {
        private List<string> _foods = new List<string>();

        private int Temperature { get; set; }


        public FoodShelf(string material, int numOfShelves, int numOfDoors) : base(material, numOfShelves, numOfDoors)
        {
            Temperature = new Random().Next(18);
        }

        public override string ToString()
        {
            return "Количество дверей: " + NumOfDoors + "\nКоличество полок: " + NumOfShelves + "\nТекущая температура: " + Temperature;
        }
    }
}