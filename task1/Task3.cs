using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Task3
    {
        public void upToDown()
        {           
            const char spaceKey =  ' ';          
            char tempKey = '1';
            string str = "";
            int magicNumber = 32;         
            Console.WriteLine("Input :");
            while(true)
            {
            tempKey = (char)Console.Read();
                if (tempKey >= 'A' && tempKey <= 'Z')
                {
                    tempKey = (char)(tempKey + magicNumber);
                    str += tempKey;                  
                }
                else if (tempKey >= 'a' && tempKey <= 'z')
                {
                tempKey = (char)(tempKey - magicNumber);
                    str += tempKey;                    
                }                      
               // BREAK
               if(tempKey == spaceKey)
                {
                    break;
                }
            }
            Console.WriteLine(str);
        }
    }
}