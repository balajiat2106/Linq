using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            TempData tempData = new TempData();
            IEnumerable<TempData.Employee> temp = tempData.employees;

            //Example of extension method
            int NumberOfEmployees = temp.Ext_Count();
            
            Console.WriteLine($"Number of employees are {NumberOfEmployees}");
            foreach (var q in temp)
            {
                Console.WriteLine($"Employee name is {q.EmpName}\n");
            }

            //Example of Lambda expression
            var newTemp = temp.Where(t => t.EmpName.StartsWith('B'));
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("//Example of Lambda expression");
            foreach (var item in newTemp)
            {
                Console.WriteLine($"\n{item.EmpName} designated as {item.Designation}");
            }

            //Example of normal linq query
            var newTemp1 = from t in temp
                           where t.EmpName.StartsWith('B')
                           select t;
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("//Example of normal linq query");

            foreach (var item in newTemp1)
            {
                Console.WriteLine($"\n{item.EmpName} designated as {item.Designation}");
            }
            Console.ReadLine();
        }
    }
}
