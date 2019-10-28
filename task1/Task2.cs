using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Task2
    {       
        public void likeTicket()
            {
            int likeTicketOut;
            string nulle;
            //
            nulle = (Console.ReadLine());
            Console.WriteLine("Input :\n");
            likeTicketOut = int.Parse(Console.ReadLine());
            int likeTicketOutPartOne = likeTicketOut % 1000 / 100+ likeTicketOut % 100 /10 + likeTicketOut % 10;
            int likeTicketOutPartTwo = (likeTicketOut / 1000) % 10 + (likeTicketOut / 10000) % 10 + (likeTicketOut / 100000) % 10;            
            if ((likeTicketOutPartOne - likeTicketOutPartTwo) == 0)
            {
                Console.WriteLine("true"); return ;
            }
            Console.WriteLine("false");
        }
    }
}
