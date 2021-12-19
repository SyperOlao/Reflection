namespace ClassLibrary2
{
    public class Closet: Furniture
    {
        public int NumOfShelves { get; set; }

        public int NumOfDoors { get; set; }

        public string material { get; set; }

        public Closet(string material, int numOfShelves, int numOfDoors)
        {
            this.material = material;
            this.NumOfShelves = numOfShelves;
            this.NumOfDoors = numOfDoors;
        }

        public string anyFurnitureMethod1()
        {
            return "anyFurnitureMethod1";
        }

        public string anyFurnitureMethod2()
        {
            return "anyFurnitureMethod2";
        }

        public void changeNumOfShelves(int diff)
        {
            NumOfShelves += diff;
        }

        public void changeNumOfDoors(int diff)
        {
            NumOfDoors += diff;
        }
    }
}