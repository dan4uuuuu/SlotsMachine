using SlotsMachineBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotsMachine
{
    class Program
    {
        static void Main()
        {
           Play();
        }

        private static void Play()
        {
            Console.WriteLine("Please deposit money you would like to play with: ");
            var deposit = Int32.Parse(Console.ReadLine());

            var stake = 0;
            do
            {
                Console.WriteLine("\r\nEnter stake amount: ");
                stake = Int32.Parse(Console.ReadLine());
                BedeSlotMachine bede = new BedeSlotMachine();
                var spinResult = bede.SpinBedeSlotMachine();
                var amountWon = bede.CalculateWinnings(spinResult, deposit, stake);

                int rowCount = spinResult.Count;
                int columnCount = spinResult.First().Count;

                for (int i = 0; i < columnCount; i++)
                {
                    for (int j = 0; j < rowCount; j++)
                    {
                        Console.Write(spinResult[j][i].Name + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\r\nYou have won: " + amountWon.AmountWon);
                Console.WriteLine("\r\nYour current balance is: " + amountWon.CurrentBalance);
            }
            while (stake > deposit || deposit != 0);

        }
    }
}
