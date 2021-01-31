using System.Windows.Media.Imaging;

namespace WPF_OOP8
{
    class Employee
    {
        private BitmapImage gender;
        private decimal _salary;
        private string _lastName;
        private string _firstName;

        public string Data { get; }
        public BitmapImage Gender { get; set; }
        public decimal Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName, decimal salary, BitmapImage gender)

        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Gender = gender;
        }

        public virtual decimal Income()
        {

            return Salary;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
