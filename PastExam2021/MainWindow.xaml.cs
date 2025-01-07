//https://github.com/Akenny05/PastExam2021.git

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PastExam2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Account> accounts = new List<Account>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create 4 accounts 
            CurrentAccount ca1 = new CurrentAccount("Joe", "Doe" , 1000, DateTime.Now.AddYears(-2) , "123456");
            CurrentAccount ca2 = new CurrentAccount("Jane", "Doe", 2000, DateTime.Now.AddYears(-3) , "123576");

            SavingsAccount sa1 = new SavingsAccount("John" , "Smith" , 3000 , DateTime.Now.AddYears(-4), "456732");
            SavingsAccount sa2 = new SavingsAccount("Jane", "Smith", 4000, DateTime.Now.AddYears(-5) , "785873");

            //Add to account list 
            accounts.Add(ca1);
            accounts.Add(ca2);
            accounts.Add(sa1);
            accounts.Add(sa2);

            // Display 
            lbxAccounts.ItemsSource = accounts;
        }

        private void lbxAccounts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what account is selected 
            Account selected = lbxAccounts.SelectedItem as Account;

            //check for null 
            if (selected != null)
            {
                //update display 

                tblkFirstName.Text = selected.FirstName;
                tblkLastName.Text = selected.LastName;
                tblkBalance.Text = selected.Balance.ToString("c");
                tblkAccountType.Text = selected.GetType().Name;
                tblkInterestdate.Text = selected.InterestDate.ToString("d");
            }

           
        }
    }
}