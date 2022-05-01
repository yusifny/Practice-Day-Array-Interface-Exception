using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Day_Array_Interface_Exception.IEntity
{
    interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string ShowInfo();
    }
}
