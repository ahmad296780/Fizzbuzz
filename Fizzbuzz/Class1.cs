using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class Class1
    {
        public string check(int num)
        {
            var answer = "";
            if (num % 3 == 0)
            {
                answer = "fizz";
            }
            if (num % 5 ==0)
            {
                answer += "buzz";
                    
            }
            return answer;

        }
        
    }
}
