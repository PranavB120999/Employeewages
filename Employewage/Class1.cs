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
        int partTimeHour = 4;
        int isFullTime = 1;
        int isPartTime = 2;
        

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
        public  void UC3()
        {
            Console.WriteLine("Wlcome to UC_3");
           
            int partTimeHour = 4;
            
            
            int num = random.Next(0, 3);
            if (num == 0)
            {
                Console.WriteLine("Empoloyee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total Daily wage is: " + dailyWage);
            }
            else if (num == 1)
            {
                Console.WriteLine("Employee is doing Parttime");
                dailyWage = partTimeHour * wagePerHour;
                Console.WriteLine("Total Daily wage is: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Total Daily wage is: " + dailyWage);

            }
        }
        public void UC4()
        {
            Console.WriteLine("Wlcome to UC_4");
            int isFullTime = 1;
            int isPartTime = 2;
            int totalWorkingHour, wagePerHour = 20, totalWage = 0;

            Random random = new Random();
            int randomCheck = random.Next(0, 3);
            switch (randomCheck)
            {
                case 1:
                    totalWorkingHour = 8;
                    Console.WriteLine("Employee is Present");
                    break;
                case 2:
                    totalWorkingHour = 4;
                    Console.WriteLine("Employee is doing parttime:");
                    break;
                default:
                    totalWorkingHour = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            totalWage = wagePerHour * totalWorkingHour;
            Console.WriteLine("Total wage is: " + totalWage);

        }
    }
}
