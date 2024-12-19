using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day2
{

    public struct HireDate
    {
        public int day;
        public int month;
        public int year;

        public HireDate()
        {
            day = 0;
            month = 0;
            year = 0;
        }

        public HireDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public int getDay() { return day; }
        public int getMonth() { return month; }
        public int getYear() { return year; }

        public void setDay(int _day) { day = _day; }
        public void setMonth(int _month) { month = _month; }
        public void setYear(int _year) { year = _year; }


        public int CompareTo(HireDate other)
        {
            if (year != other.year)
                return year.CompareTo(other.year);
            if (month != other.month)
                return month.CompareTo(other.month);
            return day.CompareTo(other.day);
        }

        public override string ToString()
        {
            return $"{day:00}/{month:00}/{year}";
        }
    }
}
