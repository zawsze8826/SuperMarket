using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Supplier
    {
        private string idSupplier;
        private string nameSupplier;
        private string addressSupplier;
        private string phoneNumSupplier;
        private string itemOffered;
        public string IdSupplier { get => idSupplier; set => idSupplier = value; }
        public string NameSupplier { get => nameSupplier; set => nameSupplier = value; }
        public string AddressSupplier { get => addressSupplier; set => addressSupplier = value; }
        public string PhoneNumSupplier { get => phoneNumSupplier; set => phoneNumSupplier = value; }
        public string ItemOffered { get => itemOffered; set => itemOffered = value; }
        public Supplier()
        {
        }

        public void AddSupplier()
        {
            int temp = 0;
            Supplier sup = new Supplier();

            if (SuperMarket.SupplierList.Count == 0)
            {
                sup.IdSupplier = "SU1";
            }
            else
            {
                foreach (Supplier s in SuperMarket.SupplierList)
                {
                    temp = Convert.ToInt32(s.IdSupplier.Substring(2));
                }
                sup.IdSupplier = "SU" + Convert.ToString(temp + 1);
            }

            Console.Write("Nhap ten nha cung cap:");
            sup.NameSupplier = Console.ReadLine();

            Console.Write("Nhap dia chi nha cung cap:");
            sup.AddressSupplier = Console.ReadLine();

            Console.Write("Nhap sdt nha cung cap:");
            sup.PhoneNumSupplier = Console.ReadLine();

            Console.Write("Nhap mat hang cung cap:");
            sup.ItemOffered = Console.ReadLine();

            SuperMarket.SupplierList.Add(sup);
        }

        public void UpdateNameGoods()
        {
            Console.Write("Nhap id nha cung cap:");
            string idSupplier = Console.ReadLine();
            Console.Write("Doi ten thanh:");
            string name = Console.ReadLine();
            foreach (Supplier sup in SuperMarket.SupplierList)
            {
                if (idSupplier == sup.IdSupplier)
                {
                    sup.IdSupplier = name;
                }
            }
        }

        public void UpdateAddressGoods()
        {
            Console.Write("Nhap id nha cung cap:");
            string idSupplier = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (Supplier sup in SuperMarket.SupplierList)
            {
                if (idSupplier == sup.IdSupplier)
                {
                    sup.AddressSupplier = address;
                }
            }
        }

        public void UpdatePhoneNumGoods()
        {
            Console.Write("Nhap id nha cung cap:");
            string idSupplier = Console.ReadLine();
            Console.Write("Doi sdt thanh:");
            string phoneNum = Console.ReadLine();
            foreach (Supplier sup in SuperMarket.SupplierList)
            {
                if (idSupplier == sup.IdSupplier)
                {
                    sup.PhoneNumSupplier = phoneNum;
                }
            }
        }

        public void UpdateItemOffered()
        {
            Console.Write("Nhap id nha cung cap:");
            string idSupplier = Console.ReadLine();
            Console.Write("Ten mat hang cung cap khac:");
            string item = Console.ReadLine();
            foreach (Supplier sup in SuperMarket.SupplierList)
            {
                if (idSupplier == sup.IdSupplier)
                {
                    sup.ItemOffered = item;
                }
            }
        }

        public void DeleteGoods()
        {
            Console.Write("Nhap id nha cung cap:");
            string idSupplier = Console.ReadLine();
            foreach (Supplier sup in SuperMarket.SupplierList)
            {
                if (idSupplier == sup.IdSupplier)
                {
                    SuperMarket.SupplierList.Remove(sup);
                }
            }
        }

        public void DisPlay()
        {
            foreach (Supplier sup in SuperMarket.SupplierList)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", sup.IdSupplier, sup.NameSupplier, sup.AddressSupplier, sup.PhoneNumSupplier, sup.ItemOffered);
            }
        }
    }
}
