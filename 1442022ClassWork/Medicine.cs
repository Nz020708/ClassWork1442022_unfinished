using System;
using System.Collections.Generic;
using System.Text;

namespace _1442022ClassWork
{
    public class Medicine
    {
       
        private static int id { get; set; } 
        public int Id { get; }
     
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }
        public Medicine()
        {
            id++;
            Id = id;
        }
        public void Sell()
        {
            Count--;
        }
        public void ShowInfo()
        {
            Console.WriteLine($" ID:{Id}\n Name:{Name}\n Price:{Price}\n Count:{Count}\n Is deleted? {IsDeleted}");
        }
    }
}
