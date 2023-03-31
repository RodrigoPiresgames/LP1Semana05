using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            Console.WriteLine("Gimme numb");
            string str = Console.ReadLine();
            int numOfDice = Convert.ToInt32(str);

            for (int x = 0; x <= numOfDice - 1; x++)
                Console.WriteLine("{0}", rand.Next(7));
        }
    }
}
