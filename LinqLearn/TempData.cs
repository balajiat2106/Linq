using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLearn
{
    sealed class TempData
    {
        public List<Employee> employees = new List<Employee>() {
            new Employee{EmpID=123,EmpName="Balaji",Designation="Tech Lead"},
            new Employee{EmpID=223, EmpName="Rakesh",Designation="QA Lead"},
            new Employee{EmpID=3234,EmpName="Balaji1",Designation="Tech Lead"},
            new Employee{EmpID=42345, EmpName="Rakesh1",Designation="QA Lead"}
        };


        public class Employee
        {
            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public string Designation { get; set; }
        }

    }
}
