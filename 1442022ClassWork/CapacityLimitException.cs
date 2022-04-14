using System;
using System.Collections.Generic;
using System.Text;

namespace _1442022ClassWork
{
    public class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message) : base(message)
        {

        }
    }
}
