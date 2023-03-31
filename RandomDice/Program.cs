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

            int result = 0;

            for (int x = 0; x <= numOfDice - 1; x++)
            {
                int diceValue = rand.Next(1, 7);

                result += diceValue;
            }

            Console.WriteLine(result);
        }
    }
}
