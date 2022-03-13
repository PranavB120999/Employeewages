using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employewage
{
  public class Class1
    {
        int totalWorkingHour = 8;
        int wagePerHour = 20;
        int dailyWage = 0; 

        Random random = new Random();
        public  void UC1()
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

        public void UC2()
        {
            Console.WriteLine("Wlcome to UC_2");
            
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("Empoloyee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total Daily wage is: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Total Daily wage is: " + dailyWage);
            }

        }
    }
}
