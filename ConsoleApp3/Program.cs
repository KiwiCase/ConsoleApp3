namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Casey's Supremely Perfect Tile Cost Calculator");
                Console.WriteLine("");
                Console.WriteLine("What is the width of the room? (Feet): ");
                string width = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("What is the length of the room? (Feet): ");
                string length = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("What is the size of the tile? (Feet squared): ");
                string size = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("What is the cost per tile? ($): ");
                string cost = Console.ReadLine();

                float rWidth = (float.Parse(width));
                float rLength = (float.Parse(length));
                float tSize = (float.Parse(size));
                float tCost = (float.Parse(cost));

                float Area = (rWidth * rLength);
                float tNeeded = (Area / tSize);
                float TotalCost = (tCost * tNeeded);

                Console.WriteLine("");
                Console.WriteLine("Area of Tiling = " + Area + " square feet.");
                Console.WriteLine("Number of Tiles needed = " + tNeeded);
                Console.WriteLine("");
                Console.WriteLine("Total Cost = $" + TotalCost);
                Console.ReadLine();
                break;
            }



        }
    }
}