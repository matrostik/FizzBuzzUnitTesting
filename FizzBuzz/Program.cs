using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public string FizzBuzz(int num)
        {
            if (num % 3 == 0)
                return "Fizz";
            return num.ToString();
        }
    }
}
