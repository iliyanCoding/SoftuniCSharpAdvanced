using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tires
    {
        public Tires(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

    }
}
