using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public enum Gender { Male, Female }

    public struct Employee
    {
        public int id;
        public float salary;
        public HireDate hireDate;
        public Gender gender;

        public Employee()
        {
            id = 0;
            salary = 0;
            hireDate = new HireDate();
            gender = Gender.Male;
        }

        public Employee(int _id, float _salary, HireDate _hireDate, Gender _gender)
        {
            id = _id;
            salary = _salary;
            hireDate = _hireDate;
            gender = _gender;
        }

        
        public int getID(){return id;}

        public float getSalary() { return salary; }

        public HireDate getHireDate() {return hireDate;}

        public Gender getGender() {return gender;}


        public void setId(int _id) {id = _id; }

        public void setSalary(int _salary){ salary = _salary;}
        public void setHireDate(HireDate _hireDate){ hireDate = _hireDate;}

        public void setGender(Gender _gender) { gender = _gender; }
    }

    public struct HireDate
    {
        internal int day;
        internal int month;
        public int year;

        public HireDate()
        {
            day = 0;
            month = 0;
            year = 0;
        }

        public int getDay(){return day; }

        public int getMonth(){ return month;}
        public int getYear(){ return year; }

        public void setDay(int _day) { day = _day; }
        public void setMonth(int _month) { month = _month; }
        public void setYear(int _year) { year = _year; }
    }
}
