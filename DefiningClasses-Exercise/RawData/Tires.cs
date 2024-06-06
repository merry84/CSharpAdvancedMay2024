
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tires
    {
		private double pressure;
		private int age;
        public Tires(double pressure,int age)
        {
			Pressure = pressure;
            Age = age;

        }

        public int Age
		{
			get { return age; }
			set { age = value; }
		}


		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}

	}
}
