using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Task4
    {
        public void outputAB()
    {
            string nulle;           
            nulle = (Console.ReadLine());
            Console.WriteLine("Input : ");
            int A;
            int B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            for (; A <= B; A++)
            {
                int tempA = A;
                while(tempA > 0)
                {
                    Console.Write(A);
                    Console.Write(' ');
                    tempA--;
                }
                Console.Write('\n');
            }
        }                  
     }
}
