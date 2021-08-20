using System;

namespace SelectionStatementsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranNum = new Random();
            var favNum = ranNum.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number.");
            var userIn = int.Parse(Console.ReadLine());

            if(userIn < favNum)
            {
                Console.WriteLine("Too Low!");
            }
            else if(userIn > favNum)
            {
                Console.WriteLine("Too High!");
            }
            else
            {
                Console.WriteLine("Nevermind!");
            }
        }
    }
}
