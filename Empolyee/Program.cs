using System;
using System.Collections.Generic;

namespace Empolyee
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }

    public class EmployeeOperations
    {
        public List<Employee> empList;
        public EmployeeOperations()
        {
            empList=new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            empList.Add(emp);
        }

        public void RemoveEmployee(Employee emp)
        {
            empList.Remove(emp);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeOperations empOps = new EmployeeOperations();

            Employee emp1 = new Employee() { EmpId= 1, EmpName = "Rahul" };
            Employee emp2 = new Employee() {EmpId = 2, EmpName = "Krushna" };

            empOps.AddEmployee(emp1);
            empOps.AddEmployee (emp2);

            Console.WriteLine("Employees in the list:");
            foreach (Employee emp in empOps.empList)
            {
                Console.WriteLine("EmpID:{0},EmpName:{1}", emp.EmpId, emp.EmpName);
            }

            empOps.RemoveEmployee(emp1);
            Console.WriteLine("Employees in the list after removing employee 1:");
            foreach (Employee emp in empOps.empList)
            {
                Console.WriteLine("EmpId:{0},EmpName:{1}", emp.EmpId, emp.EmpName);
            }

            Console.ReadKey();
        }
    }
}
