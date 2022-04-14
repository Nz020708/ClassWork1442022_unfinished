using System;
using System.Collections.Generic;
using System.Text;

namespace _1442022ClassWork
{
    public class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string message):base(message)
        {

        }
    }
}
