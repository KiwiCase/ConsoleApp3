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
                String Width = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("What is the length of the room? (Feet): ");
                String Length = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("What is the size of the tile? (Feet squared): ");
                String Size = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("what is the cost per tile? ($): ");
                String Cost = Console.ReadLine();

                float rWidth = (float.Parse(Width));
                float rLength = (float.Parse(Length));
                float tSize = (float.Parse(Size));
                float tCost = (float.Parse(Cost));


            }



        }
    }
}