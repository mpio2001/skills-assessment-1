using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzLib;
namespace FizzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz buz = new FizzBuzz();
            Console.WriteLine(buz.GetFizzBuzz(1, 100));
            Console.WriteLine(buz.GetFizzBuzz(1, int.MaxValue));
            Console.WriteLine(buz.GetFizzBuzz(int.MinValue, int.MaxValue));
        }
    }
}
