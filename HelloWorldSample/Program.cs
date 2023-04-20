using System;


namespace HelloWorldSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            Console.Write("Did you know that in 1440 (or thereabouts),");
            Console.WriteLine("Johannes Gutenberg invented the printing press with moveable type?");
            Console.WriteLine("He started out as a goldsmith!");

            Console.Write("4 is greater than -1: ");
            Console.WriteLine(4 > -1);

            Console.WriteLine("\n****** Now make the computer do some harder math!");

            Console.Write("8043.52 minus 4.2 plus 23.0 divided by 56.0 times -76.13 is: ");
            Console.WriteLine((8043.52 - 4.2 + 23) / 56 * (-76.13));

            Console.ReadLine();
        }
    }
}
