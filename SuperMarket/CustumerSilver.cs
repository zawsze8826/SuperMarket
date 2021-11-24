using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class CustumerSilver : Custumer
    {
        public override void Display()
        {
            foreach (Custumer cus in SuperMarket.CustumerList)
            {
                if (cus.Rank == "Silver")
                {
                    Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", cus.IdCustumer, cus.NameCustumer, cus.AddressCustumer, cus.PhoneNumCustumer, cus.BirthDayCustumer.ToString("dd/MM/yyyy"), cus.Rank);
                }
            }
        }
    }
}
