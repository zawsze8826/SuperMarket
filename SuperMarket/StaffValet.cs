using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class StaffValet : Staff
    {
        public StaffValet(string office, string salary) : base(office, salary)
        {
            Office = office;
            Salary = salary;
        }
        public StaffValet()
        { }
        ~StaffValet()
        { }
        public override void AddStaff()
        {
            string office = "Valet";
            string salary = "15000000";
            Staff valet = new StaffValet(office, salary);
            bool check = false;

            if (SuperMarket.StaffList.Count != 0)
            {
                SuperMarket.StaffList.Reverse();
                check = true;

                foreach (Staff sta in SuperMarket.StaffList)
                {
                    if (sta.IDStaff.Substring(0, 2) == "VA")
                    {
                        valet.IDStaff = "VA" + Convert.ToString(Convert.ToInt32(sta.IDStaff.Substring(2)) + 1);
                        break;
                    }
                    else
                    {
                        valet.IDStaff = "VA1";
                    }

                }
                if (check == true)
                {
                    SuperMarket.StaffList.Reverse();
                }
            }
            else
            {
                valet.IDStaff = "VA1";
            }

            Console.Write("Nhap ten nhan vien:");
            valet.NameStaff = Console.ReadLine();

            Console.Write("Nhap ngay, thang, nam sinh nhan vien:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            valet.BirthDayStaff = new DateTime(year, month, day);

            Console.Write("Nhap gioi tinh nhan vien:");
            valet.Sex = Console.ReadLine();

            Console.Write("Nhap dia chi nhan vien:");
            valet.AddressStaff = Console.ReadLine();

            Console.Write("Nhap cnmd cua nhan vien:");
            valet.IDIndividual = Console.ReadLine();

            Console.Write("Nhap sdt nhan vien:");
            valet.PhoneNumStaff = Console.ReadLine();

            SuperMarket.StaffList.Add(valet);
        }
        public override void UpdateNameStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi ten thanh:");
            string name = Console.ReadLine();
            foreach (Staff valet in SuperMarket.StaffList)
            {
                if (idStaff == valet.IDStaff)
                {
                    valet.NameStaff = name;
                }
            }
        }
        public override void UpdateAddressStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi dia chi thanh:");
            string address = Console.ReadLine();
            foreach (Staff valet in SuperMarket.StaffList)
            {
                if (idStaff == valet.IDStaff)
                {
                    valet.AddressStaff = address;
                }
            }
        }
        public override void UpdatePhoneNumStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi std thanh:");
            string phoneNum = Console.ReadLine();
            foreach (Staff valet in SuperMarket.StaffList)
            {
                if (idStaff == valet.IDStaff)
                {
                    valet.PhoneNumStaff = phoneNum;
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
            foreach (Staff valet in SuperMarket.StaffList)
            {
                if (idStaff == valet.IDStaff)
                {
                    valet.Sex = sex;
                }
            }
        }
        public override void UpdateIdIndividualStaff()
        {
            Console.Write("Nhap id nhan vien:");
            string idStaff = Console.ReadLine();
            Console.Write("Doi CMND thanh:");
            string idIndividual = Console.ReadLine();
            foreach (Staff valet in SuperMarket.StaffList)
            {
                if (idStaff == valet.IDStaff)
                {
                    valet.IDIndividual = idIndividual;
                }
            }
        }
        public override void DeleteStaff()
        {
            Console.WriteLine("Nhap Id nhan vien:");
            string idStaff = Console.ReadLine();
            foreach (Staff valet in SuperMarket.StaffList)
            {
                if (idStaff == valet.IDStaff)
                {
                    SuperMarket.StaffList.Remove(valet);
                    return;
                }
            }
        }
        public override void Display()
        {
            foreach (Staff valet in SuperMarket.StaffList)
            {
                if (valet.IDStaff.Substring(0, 2) == "VA")
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", valet.IDStaff, valet.NameStaff, valet.Sex, valet.BirthDayStaff.ToString("dd/MM/yyyy"), valet.AddressStaff, valet.IDIndividual, valet.PhoneNumStaff, valet.Office, valet.Salary);
                }
            }
        }
    }
}
