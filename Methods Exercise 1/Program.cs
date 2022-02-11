using System;

namespace Methods_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?");
            string userName = Console.ReadLine();

            Console.Write("what is your favorite color?");
            string favColor = Console.ReadLine();

            Console.Write("What is you favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.Write("What is your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"Once Upon a time, ther was a lad named {userName}, they lived in a huge {favColor} castle." );
            Console.WriteLine($"All was going well for {userName} until one day their {favAnimal} was struck by lightning!!");
            Console.WriteLine($"but all at once from the {favAnimal}s ashes, arrose {favBand}");
            Console.WriteLine($"And just like that, once agin, all was well and {userName} lived happily ever after with {favBand}");
        }
    }

}
