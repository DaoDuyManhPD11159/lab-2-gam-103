using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_bai_2
{
    class Class1
    {
        static void Main()
        {
            int y = 10;
            Action<int> anoMethod = delegate(int x) 
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("sum"+sum);
                Console.WriteLine("sub" + sub);
            };
            anoMethod(5);
        }

    }
}
