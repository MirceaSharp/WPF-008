using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_OOP8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employee> EmployeesList = new List<Employee>(); 
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            if(rdWoman.IsChecked ==true)
            {
                BitmapImage image1 = new BitmapImage(new Uri(@"Images\vrouwelijk_teken.jpg", UriKind.Relative));
                if (rdCommission.IsChecked == true)
                {
                    CommissionWorker myCommissionWorker = new CommissionWorker(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtSalary.Text), Convert.ToDecimal(txtCommission.Text), Convert.ToInt32(txtNumber.Text), image1);
                    EmployeesList.Add(myCommissionWorker);
                    lbResult.Items.Add(myCommissionWorker);
                }
                else if (rdEmployee.IsChecked == true)
                {
                    Employee myEmployee = new Employee(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtSalary.Text), image1);
                    EmployeesList.Add(myEmployee);
                    lbResult.ItemsSource = EmployeesList;
                }
                else if (rdHourly.IsChecked == true)

                {
                    HourlyWorker myHourlyWorker = new HourlyWorker(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtSalary.Text), Convert.ToInt32(txtNumber.Text), image1);
                    EmployeesList.Add(myHourlyWorker);
                    lbResult.ItemsSource = EmployeesList;
                }
                else if (rdTemporary.IsChecked == true)
                {
                    TemporaryWorker myTemporaryWorker = new TemporaryWorker(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtSalary), Convert.ToInt32(txtNumber.Text), image1);
                    EmployeesList.Add(myTemporaryWorker);
                    lbResult.Items.Add(myTemporaryWorker);
                }


            }
            else if (rdMan.IsChecked ==true)

            {
                BitmapImage image2 = new BitmapImage(new Uri(@"Images\mannelijk_teken.png", UriKind.Relative));
                if (rdCommission.IsChecked == true)
                {
                    CommissionWorker myCommissionWorker = new CommissionWorker(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtSalary.Text), Convert.ToDecimal(txtCommission.Text), Convert.ToInt32(txtNumber.Text), image2);
                    EmployeesList.Add(myCommissionWorker);
                    lbResult.Items.Add(myCommissionWorker);
                }
                else if (rdEmployee.IsChecked == true)
                {
                    Employee myEmployee = new Employee(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtSalary.Text), image2);
                    EmployeesList.Add(myEmployee);
                    lbResult.ItemsSource = EmployeesList;
                }
                else if (rdHourly.IsChecked == true)

                {
                    HourlyWorker myHourlyWorker = new HourlyWorker(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtSalary.Text), Convert.ToInt32(txtNumber.Text), image2);
                    EmployeesList.Add(myHourlyWorker);
                    lbResult.ItemsSource = EmployeesList;
                }
                else if (rdTemporary.IsChecked == true)
                {
                    TemporaryWorker myTemporaryWorker = new TemporaryWorker(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtSalary.Text), Convert.ToInt32(txtNumber.Text), image2);
                    EmployeesList.Add(myTemporaryWorker);
                    lbResult.Items.Add(myTemporaryWorker);
                }


            }



        }

        
    }
}
