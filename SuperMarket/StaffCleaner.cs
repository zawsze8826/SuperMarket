using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class StaffCleaner : Staff
    {
        public StaffCleaner(string office, string salary) : base(office, salary)
        {
            Office = office;
            Salary = salary;
        }
        public StaffCleaner()
        { }
        ~StaffCleaner()
        { }
        public override void AddStaff()
        {
            string office = "Cleaner";
            string salary = "15000000";
            Staff cleaner = new StaffCleaner(office, salary);

            bool check = false;

            if (SuperMarket.StaffList.Count != 0)
            {
                SuperMarket.StaffList.Reverse();
                check = true;

                foreach (Staff sta in SuperMarket.StaffList)
                {
                    if (sta.IDStaff.Substring(0, 2) == "CL")
                    {
                        cleaner.IDStaff = "CL" + Convert.ToString(Convert.ToInt32(sta.IDStaff.Substring(2)) + 1);
                        break;
                    }
                    else
                    {
                        cleaner.IDStaff = "CL1";
                    }

                }
                if (check == true)
                {
                    SuperMarket.StaffList.Reverse();
                }
            }
            else
            {
                cleaner.IDStaff = "CL1";
            }

            Console.Write("Nhap ten nhan vien:");
            cleaner.NameStaff = Console.ReadLine();

            Console.Write("Nhap ngay, thang, nam sinh nhan vien:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            cleaner.BirthDayStaff = new DateTime(year, month, day);

            Console.Write("Nhap gioi tinh nhan vien:");
            cleaner.Sex = Console.ReadLine();

            Console.Write("Nhap dia chi nhan vien:");
            cleaner.AddressStaff = Console.ReadLine();

            Console.Write("Nhap cnmd cua nhan vien:");
            cleaner.IDIndividual = Console.ReadLine();

            Console.Write("Nhap sdt nhan vien:");
            cleaner.PhoneNumStaff = Console.ReadLine();

            SuperMarket.StaffList.Add(cleaner);
        }
        public override void UpdateNameStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi ten thanh:");
            string name = Console.ReadLine();
            foreach (Staff cleaner in SuperMarket.StaffList)
            {
                if (idStaff == cleaner.IDStaff)
                {
                    cleaner.NameStaff = name;
                }
            }
        }
        public override void UpdateAddressStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (Staff cleaner in SuperMarket.StaffList)
            {
                if (idStaff == cleaner.IDStaff)
                {
                    cleaner.AddressStaff = address;
                }
            }
        }
        public override void UpdatePhoneNumStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi std thanh:");
            string phoneNum = Console.ReadLine();
            foreach (Staff cleaner in SuperMarket.StaffList)
            {
                if (idStaff == cleaner.IDStaff)
                {
                    cleaner.PhoneNumStaff = phoneNum;
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
            foreach (Staff cleaner in SuperMarket.StaffList)
            {
                if (idStaff == cleaner.IDStaff)
                {
                    cleaner.Sex = sex;
                }
            }
        }
        public override void UpdateIdIndividualStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi CMND thanh:");
            string idIndividual = Console.ReadLine();
            foreach (Staff cleaner in SuperMarket.StaffList)
            {
                if (idStaff == cleaner.IDStaff)
                {
                    cleaner.IDIndividual = idIndividual;
                }
            }
        }
        public override void DeleteStaff()
        {
            Console.WriteLine("Nhap Id nhan vien:");
            string idStaff = Console.ReadLine();
            foreach (Staff cleaner in SuperMarket.StaffList)
            {
                if (idStaff == cleaner.IDStaff)
                {
                    SuperMarket.StaffList.Remove(cleaner);
                    return;
                }
            }
        }
        public override void Display()
        {
            foreach (Staff cleaner in SuperMarket.StaffList)
            {
                if (cleaner.IDStaff.Substring(0, 2) == "CL")
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", cleaner.IDStaff, cleaner.NameStaff, cleaner.Sex, cleaner.BirthDayStaff.ToString("dd/MM/yyyy"), cleaner.AddressStaff, cleaner.IDIndividual, cleaner.PhoneNumStaff, cleaner.Office, cleaner.Salary);
                }
            }
        }
    }
}

