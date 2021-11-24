using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class CustomerSilver : Customer
    {
        public override void Display()
        {
            foreach (Customer cus in SuperMarket.CustomerList)
            {
                if (cus.Rank == "Silver")
                {
                    Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", cus.IDCustomer, cus.NameCustomer, cus.AddressCustomer, cus.PhoneNumCustomer, cus.BirthDayCustomer.ToString("dd/MM/yyyy"), cus.Rank);
                }
            }
        }
    }
}
