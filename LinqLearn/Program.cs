using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity;

namespace LinqLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            TempData tempData = new TempData();
            FuncAndAction funcAndAction = new FuncAndAction();
            IEnumerable<TempData.Employee> temp = tempData.employees;
            
            //Example of extension method
            int NumberOfEmployees = temp.Ext_Count();
            funcAndAction.actionToWriteStar();

            Console.WriteLine($"Number of employees are {NumberOfEmployees}");
            foreach (var q in temp)
            {
                Console.WriteLine($"Employee name is {q.EmpName}\n");
            }

            //Example of Lambda expression
            var newTemp = temp.Where(t => t.EmpName.StartsWith('B'));
            funcAndAction.actionToWriteStar();


            Console.WriteLine("//Example of Lambda expression");
            foreach (var item in newTemp)
            {
                Console.WriteLine($"\n{item.EmpName} designated as {item.Designation}");
            }

            //Example of normal linq query
            var newTemp1 = from t in temp
                           where t.EmpName.StartsWith('B')
                           select t;
            funcAndAction.actionToWriteStar();

            Console.WriteLine("//Example of normal linq query");

            foreach (var item in newTemp1)
            {
                Console.WriteLine($"\n{item.EmpName} designated as {item.Designation}");
            }

            //Usage of Action<> to write
            funcAndAction.actionToWriteStar();
            funcAndAction.actionToWrite($"Square func for 10 is {funcAndAction.func(10)}");

            funcAndAction.actionToWriteStar();
            funcAndAction.actionToWrite($"Cube func for 10,5,1 is {funcAndAction.func1(10,5,1)}");

            funcAndAction.actionToWriteStar();
            funcAndAction.actionToWrite($"Square func for 10 is {funcAndAction.funcLambdaWithBody(10)}");
            
            Console.ReadLine();

        }
    }
}
