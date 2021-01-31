using System.Windows.Media.Imaging;

namespace WPF_OOP8
{
    class TemporaryWorker : Employee
    {

        private int _number;
        public int Number { get; set; }

        public TemporaryWorker(string firstName, string lastName, decimal salaryPerAssignment, int number, BitmapImage gender) : base(firstName, lastName, salaryPerAssignment, gender)
        {
            this.Number = number;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public virtual decimal Income()
        {
            return Salary
        }
    }
}
