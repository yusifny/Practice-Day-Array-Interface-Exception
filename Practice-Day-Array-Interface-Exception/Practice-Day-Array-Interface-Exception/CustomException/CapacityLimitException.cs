using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Day_Array_Interface_Exception.CustomException
{
    class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message):base(message)
        {

        }
    }
}
