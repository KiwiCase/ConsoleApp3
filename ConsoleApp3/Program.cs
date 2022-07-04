namespace ConsoleApp3
{
    internal class Program
    {
        private static int v2;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Casey's Supremely Perfect Tile Cost Calculator");
                Console.WriteLine("");
                Console.WriteLine("What is the width of the room? (Feet): ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("What is the length of the room? (Feet): ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("What is the size of the tile? (Feet squared): ");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("What is the cost per tile? ($): ");
                int cost = Convert.ToInt32(Console.ReadLine());

                float Area = (width * length);
                float tNeeded = (Area / size);
                float TotalCost = cost * tNeeded;

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
