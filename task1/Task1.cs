using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Task1
    {
        public void numberInputSpace( )
        {           
            const char dotKey = '.';
            const char spaceKey = ' ';
            char tempKey = '1';
            int numberInputSpace = 0;
            Console.Write("Input :");
            while (true)
            {
                tempKey = (char)Console.Read();               
                if(spaceKey == tempKey)
                numberInputSpace++;
                if (dotKey == tempKey)
                    break;              
            }
            Console.WriteLine(numberInputSpace);
        }
    }

}
