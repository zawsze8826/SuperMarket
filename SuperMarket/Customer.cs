using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Customer
    {
        private string idCustomer;
        private string nameCustomer;
        private string addressCustomer;
        private string phoneNumCustomer;
        private DateTime birthDayCustomer;
        private int accumulatedPoints;
        private string rank;
        private double discount;
        public string IDCustomer {   get => idCustomer; set => idCustomer = value; }
        public string NameCustomer { get => nameCustomer; set => nameCustomer = value; }
        public string AddressCustomer { get => addressCustomer; set => addressCustomer = value; }
        public string PhoneNumCustomer { get => phoneNumCustomer; set => phoneNumCustomer = value; }
        public DateTime BirthDayCustomer { get => birthDayCustomer; set => birthDayCustomer = value; }
        public int AccumulatedPoints { get => accumulatedPoints; set => accumulatedPoints = value; }
        public string Rank { get => rank; set => rank = value; }
        public double Discount { get => discount; set => discount = value; }

        public Customer() 
        { }
        ~ Customer()
        { }
        public void CreatecCustumer()
        {
            int temp = 0;
            Customer cus = new Customer();

            if (SuperMarket.CustomerList.Count == 0)
            {
                cus.IDCustomer = "CU1";
            }
            else
            {
                foreach (Customer c in SuperMarket.CustomerList)
                {
                    temp = Convert.ToInt32(c.IDCustomer.Substring(2));
                }
                cus.IDCustomer = "CU" + Convert.ToString(temp + 1);
            }

            Console.Write("Nhap ten khach hang: ");
            cus.NameCustomer = Console.ReadLine();

            Console.Write("Nhap so dien thoai khac hang:");
            cus.PhoneNumCustomer = Console.ReadLine();

            Console.Write("Nhap dia chi khach hang:");
            cus.AddressCustomer = Console.ReadLine();

            Console.Write("Nhap ngay, thang. nam sinh:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            cus.BirthDayCustomer = new DateTime(year, month, day);

            cus.AccumulatedPoints = 0;

            cus.Rank = "UnRank";

            cus.Discount = 0;

            SuperMarket.CustomerList.Add(cus);
        }

        public void UpdateRank()
        {
            Console.Write("Nhap id khach hang:");
            string idCus = Console.ReadLine();
            Console.Write("Nhap so tien khach hang mua them:");
            int newmoney = Int32.Parse(Console.ReadLine());
            foreach (Customer cus in SuperMarket.CustomerList)
            {
                if (idCus == cus.IDCustomer)
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
            foreach (Customer cus in SuperMarket.CustomerList)
            {
                if (idCus == cus.IDCustomer)
                {
                    cus.NameCustomer = name;
                }
            }
        }

        public void UpdateAddressCustumer()
        {
            Console.Write("Nhap id khach hang:");
            string idCus = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (Customer cus in SuperMarket.CustomerList)
            {
                if (idCus == cus.IDCustomer)
                {
                    cus.AddressCustomer = address;
                }
            }
        }

        public void UpdatePhoneNumCustumer()
        {
            Console.Write("Nhap id khach hang:");
            string idCus = Console.ReadLine();
            Console.Write("Doi sdt thanh:");
            string phoneNum = Console.ReadLine();
            foreach (Customer cus in SuperMarket.CustomerList)
            {
                if (idCus == cus.IDCustomer)
                {
                    cus.PhoneNumCustomer = phoneNum;
                }
            }
        }

        public void UpdateBirthDayCustumer()
        {
        }

        public virtual void Display()
        {
            foreach (Customer cus in SuperMarket.CustomerList)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", cus.IDCustomer, cus.NameCustomer, cus.AddressCustomer, cus.PhoneNumCustomer, cus.BirthDayCustomer.ToString("dd/MM/yyyy"), cus.Rank);
            }
        }
    }
}
