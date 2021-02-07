using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_OOP8
{
    class CommissionWorker:Employee
    {
        private int _number;
        private decimal _commission;
        public int Number { get; set; }
        public decimal Commission { get; set; }



        public CommissionWorker(string firstName, string lastName, decimal salary, decimal commission,int number,BitmapImage gender):base(firstName, lastName, salary, gender)
        {
            this.Number = number;
            this.Commission = commission;
        }



        public virtual decimal Income()
        {
            return Salary;
        }
        public override string ToString()
        {
            return FirstName + LastName + Salary ;
        }




    }
}
