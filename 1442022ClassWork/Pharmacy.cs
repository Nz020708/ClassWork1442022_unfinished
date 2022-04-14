using System;
using System.Collections.Generic;
using System.Text;

namespace _1442022ClassWork
{
    public class Pharmacy
    {
        public int MedicineLimit { get; set; }
         List<Medicine> list { get; set; }
    
        public Pharmacy(int medicinelimit)
        {
            MedicineLimit = medicinelimit;
            list = new List<Medicine>();
        }
        public void AddMedicine(Medicine medicine)
        {
            bool isExist = false;
            foreach (var item in list)
            {
                if (medicine.Name==item.Name)
                {
                    throw new Exception("Medicine already exists.");
                    isExist = true;
                }
              
                    if (MedicineLimit < medicine.Count)
                    {
                        throw new Exception("Count of medicine is out of capacity");
                    }
                    else
                    {
                        list.Add(medicine);
                        Console.WriteLine("Medicine is added.");
                        isExist = false;
                    }
                
            }
            
        }
        public void GetAllMedicines()
        {
          
            List<Medicine> copylist = new List<Medicine>();
            copylist.AddRange(list);
            foreach (var item in copylist)
            {
                copylist.Add(item);
                Console.WriteLine($" ID:{item.Id}\n Name:{item.Name}\n Price:{item.Price}\n Count:{item.Count}");
                item.IsDeleted = false;
            }
        }
        public void FilterMedicinesByPrice(double minPrice,double maxPrice)
        {
            foreach (var item in list)
            {
                if (item.Price < maxPrice && item.Price > minPrice)
                {
                    Console.WriteLine(item);
                }
            }  
            
        }
        public void GetMedicineByID(int? ID)
        {
            if (ID==null)
            {
                throw new Exception("Id null deyer ala bilmez");
            }
            else
            {
               
                Console.WriteLine($"Id:{ID}");
            }
        }
    }
}
