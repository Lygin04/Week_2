using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPT.Task_4
{
    internal class Date
    {
        int day, month, year;
        public Date() { }
        public Date(int day, int month)
        {
            this.day = day;
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }
}
