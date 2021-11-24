using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class StaffCashier : Staff
    {
        public StaffCashier(string office, string salary) : base(office, salary)
        {
            Office = office;
            Salary = salary;
        }
        public StaffCashier()
        { }
        ~StaffCashier()
        { }
        public override void AddStaff()
        {
            string office = "Cashier";
            string salary = "15000000";
            Staff cash = new StaffCashier(office, salary);
            bool check = false;

            if (SuperMarket.StaffList.Count != 0)
            {
                SuperMarket.StaffList.Reverse();
                check = true;

                foreach (Staff sta in SuperMarket.StaffList)
                {
                    if (sta.IDStaff.Substring(0, 2) == "CA")
                    {
                        cash.IDStaff = "CA" + Convert.ToString(Convert.ToInt32(sta.IDStaff.Substring(2)) + 1);
                        break;
                    }
                    else
                    {
                        cash.IDStaff = "CA1";
                    }

                }
                if (check == true)
                {
                    SuperMarket.StaffList.Reverse();
                }
            }
            else
            {
                cash.IDStaff = "CA1";
            }

            Console.Write("Nhap ten nhan vien:");
            cash.NameStaff = Console.ReadLine();

            Console.Write("Nhap ngay, thang, nam sinh nhan vien:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            cash.BirthDayStaff = new DateTime(year, month, day);

            Console.Write("Nhap gioi tinh nhan vien:");
            cash.Sex = Console.ReadLine();

            Console.Write("Nhap dia chi nhan vien:");
            cash.AddressStaff = Console.ReadLine();

            Console.Write("Nhap cnmd cua nhan vien:");
            cash.IDIndividual = Console.ReadLine();

            Console.Write("Nhap sdt nhan vien:");
            cash.PhoneNumStaff = Console.ReadLine();

            SuperMarket.StaffList.Add(cash);
        }
        public override void UpdateNameStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi ten thanh:");
            string name = Console.ReadLine();
            foreach (Staff cash in SuperMarket.StaffList)
            {
                if (idStaff == cash.IDStaff)
                {
                    cash.NameStaff = name;
                }
            }
        }
        public override void UpdateAddressStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (Staff cash in SuperMarket.StaffList)
            {
                if (idStaff == cash.IDStaff)
                {
                    cash.AddressStaff = address;
                }
            }
        }
        public override void UpdatePhoneNumStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi std thanh:");
            string phoneNum = Console.ReadLine();
            foreach (Staff cash in SuperMarket.StaffList)
            {
                if (idStaff == cash.IDStaff)
                {
                    cash.PhoneNumStaff = phoneNum;
                }
            }
        }
        public override void UpdateBirthDayStaff()
        {

        }
        public override void UpdateSexStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi gio tinh thanh:");
            string sex = Console.ReadLine();
            foreach (Staff cash in SuperMarket.StaffList)
            {
                if (idStaff == cash.IDStaff)
                {
                    cash.Sex = sex;
                }
            }
        }
        public override void UpdateIdIndividualStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi CMND thanh:");
            string idIndividual = Console.ReadLine();
            foreach (Staff cash in SuperMarket.StaffList)
            {
                if (idStaff == cash.IDStaff)
                {
                    cash.IDIndividual = idIndividual;
                }
            }
        }
        public override void DeleteStaff()
        {
            Console.WriteLine("Nhap Id nhan vien:");
            string idStaff = Console.ReadLine();
            foreach (Staff cash in SuperMarket.StaffList)
            {
                if (idStaff == cash.IDStaff)
                {
                    SuperMarket.StaffList.Remove(cash);
                    return;
                }
            }
        }
        public override void Display()
        {
            foreach (Staff cash in SuperMarket.StaffList)
            {
                if (cash.IDStaff.Substring(0, 2) == "CA")
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", cash.IDStaff, cash.NameStaff, cash.Sex, cash.BirthDayStaff.ToString("dd/MM/yyyy"), cash.AddressStaff, cash.IDIndividual, cash.PhoneNumStaff, cash.Office, cash.Salary);
                }
            }
        }
    }
}
