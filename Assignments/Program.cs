using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Problem statement Index");
            Console.WriteLine("1. Aplphabetical Order");
            Console.WriteLine("2. Area Calculator");
            Console.WriteLine("3. Binary Clock");
            Console.WriteLine("4. Card Ranking");
            Console.WriteLine("5. Centrifuge Problem");
            string assignment = Console.ReadLine();

            switch (assignment)
            {
                case "1":
                    Program.CreateAlphabeticalOrder();
                    break;
                case "2":
                    Program.CreateAreaCalculator();
                    break;
                case "3":
                    Program.CreateBinaryClock();
                    break;
                case "4":
                    Program.CreateCardRanking();
                    break;
                case "5":
                    Program.CreateCentrifugeProblem();
                    break;
            }
            Console.WriteLine("Enter the Input String");

        }
        private static void CreateAlphabeticalOrder()
        {
            string input = Console.ReadLine();
            Console.WriteLine(AlphabeticalOrder.SortAlphabets(input));
        }

        private static void CreateAreaCalculator()
        {
            int radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine(AreaCalculator.CalculateRequiredArea(radius));
        }

        private static void CreateBinaryClock()
        {
            string input = Console.ReadLine().Replace(":", String.Empty).Replace(" ", String.Empty);
            string[] output = BinaryClock.CreateBinaryClock(input);
            Console.WriteLine(" ");
            Console.WriteLine("Binary Time is - ");
            Console.WriteLine(" ");
            for (int i = 0; i < output.Length; i++)
                Console.WriteLine(output[i]);
        }
        private static void CreateCardRanking()
        {
            string[] hand = new string[5];
            for (int i = 0; i < 5; i++)
                hand[i] = Console.ReadLine();

            Console.WriteLine(PokerHand.PokerHandRanking(hand));
        }

        private static void CreateCentrifugeProblem()
        {
            int total = int.Parse(Console.ReadLine());
            int filled = int.Parse(Console.ReadLine());
            Console.WriteLine(Centrifuge.BalanceTheConfiguration(total, filled));
        }

    }
}
