using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyAss3___Q1
{
    delegate void LotteryEventHandler(object sender, EventArgs e);
    class LotteryManager
    {
        public event LotteryEventHandler LotteryEvent;

        Random rand = new Random();
        int[] LotteryNum = new int[12];
        List<int[]> LotteryTickets = new List<int[]>();

        public void BuyLottery()
        {
            for(int i = 0; i < LotteryNum.Length; i++)
            {
                LotteryNum[i] = rand.Next(0, 9);
            }

            LotteryTickets.Add(LotteryNum);

            Console.WriteLine("Ticket bought!");
            Console.WriteLine("Your number is: ");
            for(int i = 0; i< LotteryNum.Length; i++)
            {
                Console.Write(LotteryNum[i]);
            }
            Console.WriteLine();
           
        }

        public void SelectWinner()
        {
            int wincondition = 0;
            int[] WinningTicket = new int[12];
            for (int i = 0; i < WinningTicket.Length; i++)
            {
                WinningTicket[i] = rand.Next(0, 9);
            }

            int[] checkTicket = new int[12];
           
          
                for (int i = 0; i < LotteryTickets.Count; i++)
                {
                    checkTicket = LotteryTickets[i];
                }

                for(int i =0; i< WinningTicket.Length; i++)
                {
                    if(WinningTicket[i] == checkTicket[i])
                    {
                        wincondition++;
                    }else if (wincondition == 12)
                    {
                        Console.WriteLine("CONGRATULATIONS! WE HAVE A WINNER!");
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("Sorry! The numbers do not match!");
                        Console.WriteLine("You lose!");
                        Console.WriteLine();
                        break;
                    }
                }
            
            
            LotteryEventSub(EventArgs.Empty);
        }

        protected virtual void LotteryEventSub(EventArgs e)
        {
            LotteryEvent?.Invoke(this, e);
        }
    }
}
