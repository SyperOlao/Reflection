namespace ClassLibrary2
{
    public class Closet: IFurniture
    {
        public int NumOfShelves { get; set; }

        public int NumOfDoors { get; set; }

        public string Material { get; set; }

        public Closet(string material, int numOfShelves, int numOfDoors)
        {
            this.Material = material;
            this.NumOfShelves = numOfShelves;
            this.NumOfDoors = numOfDoors;
        }

        public string AnyFurnitureMethod1()
        {
            return "anyFurnitureMethod1";
        }

        public string AnyFurnitureMethod2()
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