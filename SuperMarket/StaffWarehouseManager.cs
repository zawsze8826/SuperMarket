using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class StaffWarehouseManager : Staff
    {
        public StaffWarehouseManager(string office, string salary) : base(office, salary)
        {
            Office = office;
            Salary = salary;
        }
        public StaffWarehouseManager()
        { }
        ~StaffWarehouseManager()
        { }
        public override void AddStaff()
        {
            string office = "WarehouseManager";
            string salary = "10000000";
            Staff wMan = new StaffWarehouseManager(office, salary);
            bool check = false;

            if (SuperMarket.StaffList.Count != 0)
            {
                SuperMarket.StaffList.Reverse();
                check = true;

                foreach (Staff sta in SuperMarket.StaffList)
                {
                    if (sta.IDStaff.Substring(0, 2) == "WM")
                    {
                        wMan.IDStaff = "WM" + Convert.ToString(Convert.ToInt32(sta.IDStaff.Substring(2)) + 1);
                        break;
                    }
                    else
                    {
                        wMan.IDStaff = "WM1";
                    }
                }
                if (check == true)
                {
                    SuperMarket.StaffList.Reverse();
                }
            }
            else
            {
                wMan.IDStaff = "WM1";
            }

            Console.Write("Nhap ten nhan vien:");
            wMan.NameStaff = Console.ReadLine();

            Console.Write("Nhap ngay, thang, nam sinh nhan vien:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            wMan.BirthDayStaff = new DateTime(year, month, day);

            Console.Write("Nhap gioi tinh nhan vien:");
            wMan.Sex = Console.ReadLine();

            Console.Write("Nhap dia chi nhan vien:");
            wMan.AddressStaff = Console.ReadLine();

            Console.Write("Nhap cnmd cua nhan vien:");
            wMan.IDIndividual = Console.ReadLine();

            Console.Write("Nhap sdt nhan vien:");
            wMan.PhoneNumStaff = Console.ReadLine();

            SuperMarket.StaffList.Add(wMan);
        }
        public override void UpdateNameStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi ten thanh:");
            string name = Console.ReadLine();
            foreach (StaffWarehouseManager wMan in SuperMarket.StaffList)
            {
                if (idStaff == wMan.IDStaff)
                {
                    wMan.NameStaff = name;
                }
            }
        }
        public override void UpdateAddressStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (StaffWarehouseManager wMan in SuperMarket.StaffList)
            {
                if (idStaff == wMan.IDStaff)
                {
                    wMan.AddressStaff = address;
                }
            }
        }
        public override void UpdatePhoneNumStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi std thanh:");
            string phoneNum = Console.ReadLine();
            foreach (StaffWarehouseManager wMan in SuperMarket.StaffList)
            {
                if (idStaff == wMan.IDStaff)
                {
                    wMan.PhoneNumStaff = phoneNum;
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
            foreach (StaffWarehouseManager wMan in SuperMarket.StaffList)
            {
                if (idStaff == wMan.IDStaff)
                {
                    wMan.Sex = sex;
                }
            }
        }
        public override void UpdateIdIndividualStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi CMND thanh:");
            string idIndividual = Console.ReadLine();
            foreach (StaffWarehouseManager wMan in SuperMarket.StaffList)
            {
                if (idStaff == wMan.IDStaff)
                {
                    wMan.IDIndividual = idIndividual;
                }
            }
        }
        public override void DeleteStaff()
        {
            Console.WriteLine("Nhap Id nhan vien:");
            string idStaff = Console.ReadLine();
            foreach (StaffWarehouseManager wMan in SuperMarket.StaffList)
            {
                if (idStaff == wMan.IDStaff)
                {
                    SuperMarket.StaffList.Remove(wMan);
                    return;
                }
            }
        }
        public override void Display()
        {
            foreach (Staff wMan in SuperMarket.StaffList)
            {
                if (wMan.IDStaff.Substring(0, 2) == "WM")
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", wMan.IDStaff, wMan.NameStaff, wMan.Sex, wMan.BirthDayStaff.ToString("dd/MM/yyyy"), wMan.AddressStaff, wMan.IDIndividual, wMan.PhoneNumStaff, wMan.Office, wMan.Salary);
                }
            }
        }
    }


}
