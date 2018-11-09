using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLearn
{
    class TempData
    {
        List<Employee> employees = new List<Employee>() {
            new Employee{EmpID=1,EmpName="Balaji",Designation="Tech Lead"},
            new Employee{EmpID=2, EmpName="Rakesh",Designation="QA Lead"}
        };

        private class Employee
        {
            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public string Designation { get; set; }
        }
    }
}
