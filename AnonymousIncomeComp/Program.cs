using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComp
{
    class Program
    {
        static void Main()
        {
            // Print "Anonymous Income Comparison Program"

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // Print "Person 1" then get from user; Hourly Rate and Hours worked per week

            Console.WriteLine("Person 1:");
            Console.WriteLine("Please enter your Hourly Rate ");
            string person1Rate = Console.ReadLine();
            double hourlyRate1 = Convert.ToDouble(person1Rate);
            Console.WriteLine("Please enter your Hours worked per week ");
            string person1Week = Console.ReadLine();
            double hoursPerWeek1 = Convert.ToDouble(person1Week);

            // Print "Person 2" then get from user; Hourly Rate and Hours worked per week

            Console.WriteLine("Person 2:");
            Console.WriteLine("Please enter your Hourly Rate ");
            string person2Rate = Console.ReadLine();
            double hourlyRate2 = Convert.ToDouble(person2Rate);
            Console.WriteLine("Please enter your Hours worked per week ");
            string person2Week = Console.ReadLine();
            double hoursPerWeek2 = Convert.ToDouble(person2Week);

            // Print "Annual salary of Person 1:" and then print below the exact salary

            Console.WriteLine("Annual salary of Person 1: ");
            double person1Salary = hourlyRate1 * hoursPerWeek1 * 52;
            Console.WriteLine(person1Salary);
            Console.ReadLine();

            // Print "Annual salary of Person 2:" and then print below the exact salary

            Console.WriteLine("Annual salary of Person 2: ");
            double person2Salary = hourlyRate2 * hoursPerWeek2 * 52;
            Console.WriteLine(person2Salary);
            Console.ReadLine();

            // Print "Does Person 1 make more money than Person 2?" and return true or false

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryComparison = person1Salary > person2Salary;
            Console.WriteLine(salaryComparison);
            Console.ReadLine();
        }
    }
}
