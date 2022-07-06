namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Casey's Supremely Perfect Tile Cost Calculator\n");
                Console.WriteLine("What is the width of the room? (Feet): ");
                var rWidth = Console.ReadLine();
                decimal width;
                while(!decimal.TryParse(rWidth, out width))
                {
                    Console.WriteLine("Please enter a number or numbers");
                    Console.WriteLine("What is the width of the room? (Feet): ");
                    rWidth = Console.ReadLine();
                }              
                Console.WriteLine("");

                Console.WriteLine("What is the length of the room? (Feet): ");
                var rLength = Console.ReadLine();
                decimal length;
                while(!decimal.TryParse(rLength, out length))
                {
                    Console.WriteLine("Please enter a number or numbers");
                    Console.WriteLine("What is the length of the room? (Feet): ");
                    rLength = Console.ReadLine();
                }
                Console.WriteLine("");

                Console.WriteLine("What is the size of the tile? (Feet squared): ");
                var tSize = Console.ReadLine();
                decimal size;
                while(!decimal.TryParse(tSize, out size))
                {
                    Console.WriteLine("Please enter a number or numbers");
                    Console.WriteLine("What is the size of the tile? (Feet squared): ");
                    tSize = Console.ReadLine();
                }
                Console.WriteLine("");

                Console.WriteLine("What is the cost per tile? ($): ");
                var tCost = Console.ReadLine();
                decimal cost;
                while(!decimal.TryParse(tCost, out cost))
                {
                    Console.WriteLine("Please enter a number or numbers");
                    Console.WriteLine("What is the size of the tile? (Feet squared): ");
                    tCost = Console.ReadLine();
                }
                Console.WriteLine("");

                decimal area = (width * length);
                decimal tNeeded = (area / size);
                decimal totalCost = cost * tNeeded;

                Console.WriteLine("");
                Console.WriteLine("Area of Tiling = " + area + " square feet.");
                Console.WriteLine("Number of Tiles needed = " + tNeeded);
                Console.WriteLine("");
                Console.WriteLine("Total Cost = $" + totalCost);
                Console.ReadLine();




        }
    }
}