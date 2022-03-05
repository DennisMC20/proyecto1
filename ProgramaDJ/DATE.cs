using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDJ
{
    internal class Date
    {
        private int _year;
        private int _month;
        private int _day;
        //private int _hour;
        //private int _minute;
        //private int _second;
        //private int _millisecond;


        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;

        }
        public override string ToString()
        {
            return _year + "/" + _month + "/" + _day;
        }
    }
}