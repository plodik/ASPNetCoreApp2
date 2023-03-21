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
                return input1 + input2 + 4;
                //throw new Exception();

                // comment 1

                // comment 2

                // comment 3

                // comment 5

                // comment 6 from browser

                // comment 7

                // comment 8
            }
            else
            {
                return input1 + input2;
            }
        }
    }
}