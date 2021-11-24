﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class StaffManager : Staff
    {
        public StaffManager(string office, string salary) : base(office, salary)
        {
            Office = office;
            Salary = salary;
        }
        public StaffManager()
        { }
        ~StaffManager()
        { }
        public override void AddStaff()
        {
            string office = "Manager";
            string salary = "15000000";
            Staff man = new StaffManager(office,salary);
            bool check = false;

            if (SuperMarket.StaffList.Count != 0)
            {
                SuperMarket.StaffList.Reverse();
                check = true;

                foreach (Staff sta in SuperMarket.StaffList)
                {
                    if (sta.IDStaff.Substring(0, 2) == "MA")
                    {
                        man.IDStaff = "MA" + Convert.ToString(Convert.ToInt32(sta.IDStaff.Substring(2)) + 1);
                        break;
                    }
                    else
                    {
                        man.IDStaff = "MA1";
                    }

                }
                if (check == true)
                {
                    SuperMarket.StaffList.Reverse();
                }
            }
            else
            {
                man.IDStaff = "MA1";
            }

            Console.Write("Nhap ten nhan vien:");
            man.NameStaff = Console.ReadLine();
            
            Console.Write("Nhap ngay, thang, nam sinh nhan vien:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            man.BirthDayStaff = new DateTime(year, month, day);

            Console.Write("Nhap gioi tinh nhan vien:");
            man.Sex = Console.ReadLine();
            
            Console.Write("Nhap dia chi nhan vien:");
            man.AddressStaff = Console.ReadLine();
               
            Console.Write("Nhap cnmd cua nhan vien:");
            man.IDIndividual = Console.ReadLine();

            Console.Write("Nhap sdt nhan vien:");
            man.PhoneNumStaff = Console.ReadLine();

            SuperMarket.StaffList.Add(man);
        }
        public override void UpdateNameStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi ten thanh:");
            string name = Console.ReadLine();
            foreach (Staff man in SuperMarket.StaffList)
            {
                if (idStaff == man.IDStaff )
                {
                    man.NameStaff = name;
                }
            }
        }
        public override void UpdateAddressStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (Staff man in SuperMarket.StaffList)
            {
                if (idStaff == man.IDStaff)
                {
                    man.AddressStaff = address;
                }
            }
        }
        public override void UpdatePhoneNumStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi std thanh:");
            string phoneNum = Console.ReadLine();
            foreach (Staff man in SuperMarket.StaffList)
            {
                if (idStaff == man.IDStaff)
                {
                    man.PhoneNumStaff = phoneNum;
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
            foreach (Staff man in SuperMarket.StaffList)
            {
                if (idStaff == man.IDStaff)
                {
                    man.Sex = sex;
                }
            }
        }
        public override void UpdateIdIndividualStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi CMND thanh:");
            string idIndividual = Console.ReadLine();
            foreach (Staff man in SuperMarket.StaffList)
            {
                if (idStaff == man.IDStaff)
                {
                    man.IDIndividual = idIndividual;
                }
            }
        }
        public override void DeleteStaff()
        {
            Console.WriteLine("Nhap Id nhan vien:");
            string id = Console.ReadLine();
            foreach (Staff man in SuperMarket.StaffList)
            {
                if (id == man.IDStaff)
                {
                    SuperMarket.StaffList.Remove(man);
                    return;
                }
            }
        }
        public override void Display()
        {
            foreach (Staff man in SuperMarket.StaffList)
            {
                if (man.IDStaff.Substring(0, 2) == "MA")
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", man.IDStaff, man.NameStaff, man.Sex, man.BirthDayStaff.ToString("dd/MM/yyyy"), man.AddressStaff, man.IDIndividual, man.PhoneNumStaff, man.Office, man.Salary);
                }
            }
        }

    }
}
