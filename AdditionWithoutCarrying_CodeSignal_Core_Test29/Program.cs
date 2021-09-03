using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionWithoutCarrying_CodeSignal_Core_Test29
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 500;
            int y = 456;
            int res = additionWithoutCarrying(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static int additionWithoutCarrying(int param1, int param2)
        {
            if (param1 == 0 || param2 == 0) return param1 + param2;
            return additionWithoutCarrying(param1 / 10, param2 / 10) * 10 + (param1 + param2) % 10;
        }
    }
}
