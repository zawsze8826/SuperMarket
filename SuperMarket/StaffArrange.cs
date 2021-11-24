using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class StaffArrange : Staff
    {
        public StaffArrange(string office, string salary) : base(office, salary)
        {
            Office = office;
            Salary = salary;
        }
        public StaffArrange()
        { }
        ~StaffArrange()
        { }
        public override void AddStaff()
        {
            string office = "Arrange";
            string salary = "15000000";
            Staff arrange = new StaffArrange(office, salary);
            bool check = false;

            if (SuperMarket.StaffList.Count != 0)
            {
                SuperMarket.StaffList.Reverse();
                check = true;

                foreach (Staff sta in SuperMarket.StaffList)
                {
                    if (sta.IDStaff.Substring(0, 2) == "AR")
                    {
                        arrange.IDStaff = "AR" + Convert.ToString(Convert.ToInt32(sta.IDStaff.Substring(2)) + 1);
                        break;
                    }
                    else
                    {
                        arrange.IDStaff = "AR1";
                    }

                }
                if (check == true)
                {
                    SuperMarket.StaffList.Reverse();
                }
            }
            else
            {
                arrange.IDStaff = "AR1";
            }

            Console.Write("Nhap ten nhan vien:");
            arrange.NameStaff = Console.ReadLine();

            Console.Write("Nhap ngay, thang, nam sinh nhan vien:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            arrange.BirthDayStaff = new DateTime(year, month, day);

            Console.Write("Nhap gioi tinh nhan vien:");
            arrange.Sex = Console.ReadLine();

            Console.Write("Nhap dia chi nhan vien:");
            arrange.AddressStaff = Console.ReadLine();

            Console.Write("Nhap cnmd cua nhan vien:");
            arrange.IDIndividual = Console.ReadLine();

            Console.Write("Nhap sdt nhan vien:");
            arrange.PhoneNumStaff = Console.ReadLine();

            SuperMarket.StaffList.Add(arrange);
        }
        public override void UpdateNameStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi ten thanh:");
            string name = Console.ReadLine();
            foreach (Staff arrange in SuperMarket.StaffList)
            {
                if (idStaff == arrange.IDStaff)
                {
                    arrange.NameStaff = name;
                }
            }
        }
        public override void UpdateAddressStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (Staff arrange in SuperMarket.StaffList)
            {
                if (idStaff == arrange.IDStaff)
                {
                    arrange.AddressStaff = address;
                }
            }
        }
        public override void UpdatePhoneNumStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi std thanh:");
            string phoneNum = Console.ReadLine();
            foreach (Staff arrange in SuperMarket.StaffList)
            {
                if (idStaff == arrange.IDStaff)
                {
                    arrange.PhoneNumStaff = phoneNum;
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
            foreach (Staff arrange in SuperMarket.StaffList)
            {
                if (idStaff == arrange.IDStaff)
                {
                    arrange.Sex = sex;
                }
            }
        }
        public override void UpdateIdIndividualStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi CMND thanh:");
            string idIndividual = Console.ReadLine();
            foreach (Staff arrange in SuperMarket.StaffList)
            {
                if (idStaff == arrange.IDStaff)
                {
                    arrange.IDIndividual = idIndividual;
                }
            }
        }
        public override void DeleteStaff()
        {
            Console.WriteLine("Nhap Id nhan vien:");
            string idStaff = Console.ReadLine();
            foreach (Staff arrange in SuperMarket.StaffList)
            {
                if (idStaff == arrange.IDStaff)
                {
                    SuperMarket.StaffList.Remove(arrange);
                    return;
                }
            }
        }
        public override void Display()
        {
            foreach (Staff arrange in SuperMarket.StaffList)
            {
                if (arrange.IDStaff.Substring(0, 2) == "AR")
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", arrange.IDStaff, arrange.NameStaff, arrange.Sex, arrange.BirthDayStaff.ToString("dd/MM/yyyy"), arrange.AddressStaff, arrange.IDIndividual, arrange.PhoneNumStaff, arrange.Office, arrange.Salary);
                }
            }
        }
    }
}

