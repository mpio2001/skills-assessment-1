using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLib
{
    public class FizzBuzz
    {
        public int Start { get; set; }
        public int End { get; set; }
        public List<string> GetFizzBuzz(int start = 1, int end = 100)
        {

            List<string> ret = new List<string>();

            try
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 3 == 0)
                        ret.Add("Fizz");
                    else if (i % 5 == 0)
                        ret.Add("Buzz");
                    else if (i % 5 == 0 && i % 3 == 0)
                        ret.Add("FizzBuzz");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
    }
}
