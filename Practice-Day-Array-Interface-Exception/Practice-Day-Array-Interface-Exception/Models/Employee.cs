using Practice_Day_Array_Interface_Exception.IEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Day_Array_Interface_Exception.Models
{
    class Employee : IPerson
    {
        private static int _id;
        private int _age;
        public double _salary { get; set; }
        public string Name { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if (value > 16)
                {
                    _age = value;
                }
            }
        }
        public int Id { get; }
        public double Salary
        {
            get => _salary;
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }

        public Employee(string name, int age, double salary)
        {
            _id++;
            Id = _id;
            Name = name;
            Age = age;
            Salary = salary;

        }

        public string ShowInfo()
        {
            return $" Id: {Id}\n Name: {Name}\n Age: {Age}\n Salary: {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
