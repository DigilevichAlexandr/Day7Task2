using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task2
{
    class Fibonacci:IEnumerable<int>
    {
        //public static IEnumerator<int> GetNumber()
        //{

        //}

        public IEnumerator<int> GetEnumerator()
        {
            int number1 = 0;
            yield return number1;
            int number2  = 1;
            yield return number2;
            int number3;
            while(true)
            {
                number3 = number1 + number2;
                yield return number3;
                number1 = number2;
                number2 = number3;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
