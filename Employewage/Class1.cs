using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employewage
{
    internal class Class1
    {
        public static void UC1()
        {
            Console.WriteLine("Wlcome to UC_1");
            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
