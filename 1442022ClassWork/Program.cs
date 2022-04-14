using System;
using System.Collections.Generic;

namespace _1442022ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Medicine medicine1 = new Medicine();
            {
                
                medicine1.Name = "Paracetamol";
                medicine1.Count = 50;
                medicine1.Price = 3;
                medicine1.IsDeleted = false;

            }
            Medicine medicine2 = new Medicine();
            {
                medicine2.Name = "A";
                medicine2.Count = 50;
                medicine2.Price = 10;
                medicine2.IsDeleted = false;

            }
       
            //medicine1.Sell();
            //medicine1.ShowInfo();
            //List<Medicine> list = new List<Medicine>();
            //list.Add(medicine1);
            //list.Add(medicine2);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Name);
            //}

            Pharmacy medicines = new Pharmacy(100);
            medicines.AddMedicine(medicine1);
            medicines.AddMedicine(medicine2);
            medicines.GetAllMedicines();
            medicines.FilterMedicinesByPrice(5,15) ;
        }
    }
}
