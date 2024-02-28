using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marek_Ogrodnik_lab0
{
    internal class FizzBuzz
    {
        private int _maxNumber {  get; set; }
        public FizzBuzz(int maxNumber) 
        {
            _maxNumber = maxNumber;
        }

        public void Display()
        {
            for(int i = 1; i <= _maxNumber; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i.ToString());
            }
            


        }
    }
}
