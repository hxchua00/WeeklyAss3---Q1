using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyAss3___Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool loop = true;
           
            LotteryManager LM = new LotteryManager();
            LM.LotteryEvent += EventMessage;

            while (loop)
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to buy a ticket?");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");
                Console.WriteLine("3) Exit");
                Console.WriteLine();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LM.BuyLottery();
                        count++;
                        break;
                    case 2:
                        if (count >= 10)
                        {
                            Console.WriteLine("We have enough tickets to decide for the winner!");
                            Console.WriteLine();
                            LM.SelectWinner();
                        }
                        else
                        {
                            Console.WriteLine("Sorry! Not enough tickets to decide for the winner!");
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Option not available!");
                        Console.WriteLine();
                        break;
                }
            }
            
            
            Console.ReadLine();
        }

        public static void EventMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Thank you for participating in this lottery!");
            Console.WriteLine("Good luck next time too!");
            Console.WriteLine();
        }
    }
}
