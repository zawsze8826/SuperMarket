using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    abstract class Staff
    {
        private string iDStaff;
        private string nameStaff;
        private DateTime birthDayStaff;
        private string sex;
        private string addressStaff;
        private string iDIndividual;
        private string phoneNumStaff;
        private string office;
        private string salary;

        public string IDStaff { get => iDStaff; set => iDStaff = value; }
        public string NameStaff { get => nameStaff; set => nameStaff = value; }
        public DateTime BirthDayStaff { get => birthDayStaff; set => birthDayStaff = value; }
        public string Sex { get => sex; set => sex = value; }
        public string AddressStaff { get => addressStaff; set => addressStaff = value; }
        public string IDIndividual { get => iDIndividual; set => iDIndividual = value; }
        public string PhoneNumStaff { get => phoneNumStaff; set => phoneNumStaff = value; }
        public string Office { get => office; set => office = value; }
        public string Salary { get => salary; set => salary = value; }

        public Staff(string office, string salary)
        {}
        public Staff()
        { }
        ~ Staff()
        { }
        public abstract void AddStaff();
        public abstract void UpdateNameStaff();
        public abstract void UpdateAddressStaff();
        public abstract void UpdatePhoneNumStaff();
        public abstract void UpdateBirthDayStaff();
        public abstract void UpdateSexStaff();
        public abstract void UpdateIdIndividualStaff();
        public abstract void DeleteStaff();
        public abstract void Display();
    }
}
