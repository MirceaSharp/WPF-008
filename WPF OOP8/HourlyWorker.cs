using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_OOP8
{
    class HourlyWorker:Employee
    {

        private double _hournumberOfHours;
        public double NumberOFHours { get; set; }

        public HourlyWorker(string firstName, string lastName, decimal salary, int numberOfHours, BitmapImage gender) : base(firstName, lastName, salary, gender)
        {
            this.NumberOFHours = numberOfHours;
        }

        public virtual decimal Income()
        {
            return Salary;
        }


    }
}
