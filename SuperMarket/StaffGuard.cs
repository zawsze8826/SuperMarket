using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class StaffGuard : Staff
    {
        public StaffGuard(string office, string salary) : base(office, salary)
        {
            Office = office;
            Salary = salary;
        }
        public StaffGuard()
        { }
        ~StaffGuard()
        { }
        public override void AddStaff()
        {
            string office = "Guard";
            string salary = "15000000";
            Staff guard = new StaffGuard(office, salary);
            bool check = false;

            if (SuperMarket.StaffList.Count != 0)
            {
                SuperMarket.StaffList.Reverse();
                check = true;

                foreach (Staff sta in SuperMarket.StaffList)
                {
                    if (sta.IDStaff.Substring(0, 2) == "GU")
                    {
                        guard.IDStaff = "GU" + Convert.ToString(Convert.ToInt32(sta.IDStaff.Substring(2)) + 1);
                        break;
                    }
                    else
                    {
                        guard.IDStaff = "GU1";
                    }

                }
                if (check == true)
                {
                    SuperMarket.StaffList.Reverse();
                }
            }
            else
            {
                guard.IDStaff = "GU1";
            }

            Console.Write("Nhap ten nhan vien:");
            guard.NameStaff = Console.ReadLine();

            Console.Write("Nhap ngay, thang, nam sinh nhan vien:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            guard.BirthDayStaff = new DateTime(year, month, day);

            Console.Write("Nhap gioi tinh nhan vien:");
            guard.Sex = Console.ReadLine();

            Console.Write("Nhap dia chi nhan vien:");
            guard.AddressStaff = Console.ReadLine();

            Console.Write("Nhap cnmd cua nhan vien:");
            guard.IDIndividual = Console.ReadLine();

            Console.Write("Nhap sdt nhan vien:");
            guard.PhoneNumStaff = Console.ReadLine();

            SuperMarket.StaffList.Add(guard);
        }
        public override void UpdateNameStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi ten thanh:");
            string name = Console.ReadLine();
            foreach (Staff guard in SuperMarket.StaffList)
            {
                if (idStaff == guard.IDStaff)
                {
                    guard.NameStaff = name;
                }
            }
        }
        public override void UpdateAddressStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (Staff guard in SuperMarket.StaffList)
            {
                if (idStaff == guard.IDStaff)
                {
                    guard.AddressStaff = address;
                }
            }
        }
        public override void UpdatePhoneNumStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi std thanh:");
            string phoneNum = Console.ReadLine();
            foreach (Staff guard in SuperMarket.StaffList)
            {
                if (idStaff == guard.IDStaff)
                {
                    guard.PhoneNumStaff = phoneNum;
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
            foreach (Staff guard in SuperMarket.StaffList)
            {
                if (idStaff == guard.IDStaff)
                {
                    guard.Sex = sex;
                }
            }
        }
        public override void UpdateIdIndividualStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi CMND thanh:");
            string idIndividual = Console.ReadLine();
            foreach (Staff guard in SuperMarket.StaffList)
            {
                if (idStaff == guard.IDStaff)
                {
                    guard.IDIndividual = idIndividual;
                }
            }
        }
        public override void DeleteStaff()
        {
            Console.WriteLine("Nhap Id nhan vien:");
            string idStaff = Console.ReadLine();
            foreach (Staff guard in SuperMarket.StaffList)
            {
                if (idStaff == guard.IDStaff)
                {
                    SuperMarket.StaffList.Remove(guard);
                    return;
                }
            }
        }
        public override void Display()
        {
            foreach (Staff guard in SuperMarket.StaffList)
            {
                if (guard.IDStaff.Substring(0, 2) == "GU")
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", guard.IDStaff, guard.NameStaff, guard.Sex, guard.BirthDayStaff.ToString("dd/MM/yyyy"), guard.AddressStaff, guard.IDIndividual, guard.PhoneNumStaff, guard.Office, guard.Salary);
                }
            }
        }
    }
}

