using Practice_Day_Array_Interface_Exception.CustomException;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Day_Array_Interface_Exception.Models
{
    class Department
    {
        private int _employeeLimit;
        public string Name { get; set; }
        public int EmployeeLimit
        {
            get => _employeeLimit;
            set
            {
                if (value > 0)
                {
                    _employeeLimit = value;
                }
            }
        }

        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
        }
        Employee[] employees = new Employee[0];

        public void AddEmployee(Employee employee)
        {
            if (employees.Length < EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
                Console.WriteLine($"{employee}\n [i] Has been added\n-------------------");

            }
            else
            {
                throw new CapacityLimitException("Limit dolub");
            }
        }

        public Employee this[int i]
        {
            get
            {
                if (i < employees.Length)
                {
                    return employees[i];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (i < employees.Length)
                {
                    employees[i] = value;
                    return;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

    }
}
