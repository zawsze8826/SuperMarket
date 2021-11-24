using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Custumer
    {
        private string idCustumer;
        private string nameCustumer;
        private string addressCustumer;
        private string phoneNumCustumer;
        private DateTime birthDayCustumer;
        private int accumulatedPoints;
        private string rank;
        private double discount;
        public string IdCustumer {   get => idCustumer; set => idCustumer = value; }
        public string NameCustumer { get => nameCustumer; set => nameCustumer = value; }
        public string AddressCustumer { get => addressCustumer; set => addressCustumer = value; }
        public string PhoneNumCustumer { get => phoneNumCustumer; set => phoneNumCustumer = value; }
        public DateTime BirthDayCustumer { get => birthDayCustumer; set => birthDayCustumer = value; }
        public int AccumulatedPoints { get => accumulatedPoints; set => accumulatedPoints = value; }
        public string Rank { get => rank; set => rank = value; }
        public double Discount { get => discount; set => discount = value; }

        public Custumer() 
        { }
        ~ Custumer()
        { }
        public void CreatecCustumer()
        {
            int temp = 0;
            Custumer cus = new Custumer();

            if (SuperMarket.CustumerList.Count == 0)
            {
                cus.IdCustumer = "CU1";
            }
            else
            {
                foreach (Custumer c in SuperMarket.CustumerList)
                {
                    temp = Convert.ToInt32(c.IdCustumer.Substring(2));
                }
                cus.IdCustumer = "CU" + Convert.ToString(temp + 1);
            }

            Console.Write("Nhap ten khach hang: ");
            cus.NameCustumer = Console.ReadLine();

            Console.Write("Nhap so dien thoai khac hang:");
            cus.PhoneNumCustumer = Console.ReadLine();

            Console.Write("Nhap dia chi khach hang:");
            cus.AddressCustumer = Console.ReadLine();

            Console.Write("Nhap ngay, thang. nam sinh:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            cus.BirthDayCustumer = new DateTime(year, month, day);

            cus.AccumulatedPoints = 0;

            cus.Rank = "UnRank";

            cus.Discount = 0;

            SuperMarket.CustumerList.Add(cus);
        }

        public void UpdateRank()
        {
            Console.Write("Nhap id khach hang:");
            string idCus = Console.ReadLine();
            Console.Write("Nhap so tien khach hang mua them:");
            int newmoney = Int32.Parse(Console.ReadLine());
            foreach (Custumer cus in SuperMarket.CustumerList)
            {
                if (idCus == cus.IdCustumer)
                {
                    int updatemoney = cus.AccumulatedPoints + newmoney;
                    cus.AccumulatedPoints = updatemoney;
                }
                if (cus.AccumulatedPoints <= 500000) cus.Rank = "Unrank";
                else if ((cus.AccumulatedPoints > 500000) && (cus.AccumulatedPoints <= 2000000))
                {
                    cus.Rank = "Bronze";
                    cus.discount = 5;
                }
                else if ((cus.AccumulatedPoints > 2000000) && (cus.AccumulatedPoints <= 5000000))
                {
                    cus.Rank = "Silver";
                    cus.Discount = 10;
                }
                else if ((cus.AccumulatedPoints > 5000000) && (cus.AccumulatedPoints <= 10000000))
                {
                    cus.Rank = "Gold";
                    cus.Discount = 20;
                }
                else
                {
                    cus.Rank = "Dimond";
                    cus.Discount = 30;
                }
            }
        }

        public void UpdateNameCustumer()
        {
            Console.Write("Nhap id khach hang:");
            string idCus = Console.ReadLine();
            Console.Write("Doi ten thanh:");
            string name = Console.ReadLine();
            foreach (Custumer cus in SuperMarket.CustumerList)
            {
                if (idCus == cus.IdCustumer)
                {
                    cus.NameCustumer = name;
                }
            }
        }

        public void UpdateAddressCustumer()
        {
            Console.Write("Nhap id khach hang:");
            string idCus = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (Custumer cus in SuperMarket.CustumerList)
            {
                if (idCus == cus.IdCustumer)
                {
                    cus.AddressCustumer = address;
                }
            }
        }

        public void UpdatePhoneNumCustumer()
        {
            Console.Write("Nhap id khach hang:");
            string idCus = Console.ReadLine();
            Console.Write("Doi sdt thanh:");
            string phoneNum = Console.ReadLine();
            foreach (Custumer cus in SuperMarket.CustumerList)
            {
                if (idCus == cus.IdCustumer)
                {
                    cus.PhoneNumCustumer = phoneNum;
                }
            }
        }

        public void UpdateBirthDayCustumer()
        {
        }

        public virtual void Display()
        {
            foreach (Custumer cus in SuperMarket.CustumerList)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", cus.IdCustumer, cus.NameCustumer, cus.AddressCustumer, cus.PhoneNumCustumer, cus.BirthDayCustumer.ToString("dd/MM/yyyy"), cus.Rank);
            }
        }
    }
}
