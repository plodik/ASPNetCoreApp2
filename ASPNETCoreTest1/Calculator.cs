using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreTest1
{
    public class Calculator
    {
        public int Sum(int input1, int input2)
        {
            if(input1 > 5)
            {
                return input2 + input2 + 5;
            }
            else
            {
                return input1 + input2;
            }
        }
    }
}
