using Practice_Day_Array_Interface_Exception.CustomException;
using Practice_Day_Array_Interface_Exception.Models;
using System;

namespace Practice_Day_Array_Interface_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Employees

                Employee employee1 = new Employee("Loghman Alizada", 20, 350.31);

                Employee employee2 = new Employee("Yusif Nazarbayov", 21, 2899.00);

                Employee employee3 = new Employee("Murad Aslanov", 20, 150.69);

            #endregion

            #region Departments

            Department department = new Department("Software Development", 5);
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);

            #endregion


        }
    }
}
