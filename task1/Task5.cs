using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Task5
    {
        public void revers()
        {
            string number = "";
            Console.WriteLine("Input : ");                      
            number = Console.ReadLine();
            int LengthNumber = number.Length - 1;
            string tempNumber = "";
            while(LengthNumber >= 0)
            {
                tempNumber += number[LengthNumber];
                LengthNumber--;
            }
            Console.WriteLine(tempNumber);
        }
    }
}
