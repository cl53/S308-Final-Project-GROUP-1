using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Group01
{
    /// <summary>
    /// Interaction logic for MakeReservation.xaml
    /// </summary>
    public partial class MakeReservation : Window
    {
        public MakeReservation()
        {
            InitializeComponent();
        }

        private void btnReturnToNewReservation_Click(object sender, RoutedEventArgs e)
        {
            NewReservation demoWindow = new NewReservation();
            demoWindow.Show();
            this.Close();
        }

        private void btnReturnToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow demoWindow = new MainWindow();
            demoWindow.Show();
            this.Close();

        }





        private void btnMakeReservation_Click(object sender, RoutedEventArgs e)
        {
            long lngOut;
            long lngphoneNumber;
            bool bolValid = false;

            int i;
            int intCheckDigit;
            int intCheckSum = 0;

            string strCardType;
            string strFirstName = txtFirstName.Text;
            string strLastName = txtLastName.Text;
            string strEmail = txtEmail.Text;
            string strPhoneNumber = txtPhoneNumber.Text;
            string strCardNum = txtCreditCard.Text.Trim().Replace(" ", "");

            if (strFirstName == "")
            {
                MessageBox.Show("Please enter your first name");
                txtFirstName.Focus();
                return;
            }
            else if (strLastName == "")
            {
                MessageBox.Show("Please enter your last name");
                txtLastName.Focus();
                return;
            }

            else if (strPhoneNumber == "")
            {
                MessageBox.Show("Please enter your phone number");
                txtPhoneNumber.Focus();
                return;
            }

            else if (strEmail == "")
            {
                MessageBox.Show("Please enter your  email address");
                txtEmail.Focus();
                return;
            }

            else if (!strEmail.Contains("@") || !strEmail.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address");
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            else if (!Int64.TryParse(strPhoneNumber, out lngphoneNumber))
            {
                MessageBox.Show("Phone number only contain number");
                txtPhoneNumber.Text = "";
                txtPhoneNumber.Focus();
                return;
            }

            txtCreditCard.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            lblResult.Content = "";
            lblResult.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            imgCard.Visibility = Visibility.Hidden;

            if (!Int64.TryParse(strCardNum, out lngOut))
            {
                MessageBox.Show("Credit card numbers contain only numbers.");
                txtCreditCard.Background = new SolidColorBrush(Color.FromRgb(255, 200, 200));
                lblResult.Content = "The Credit Card Is Not Valid";
                return;
            }



            if (strCardNum.Length != 13 && strCardNum.Length != 15 && strCardNum.Length != 16)
            {
                MessageBox.Show("Credit card numbers must contain 13, 15, or 16 digits.");
                txtCreditCard.Background = new SolidColorBrush(Color.FromRgb(255, 200, 200));
                lblResult.Content = "The Credit Card Is Not Valid";
                return;
            }


            if (strCardNum.StartsWith("34") || strCardNum.StartsWith("37"))
                strCardType = "AMEX";
            else if (strCardNum.StartsWith("6011"))
                strCardType = "Discover";
            else if (strCardNum.StartsWith("51") || strCardNum.StartsWith("52") || strCardNum.StartsWith("53") || strCardNum.StartsWith("54") || strCardNum.StartsWith("55"))
                strCardType = "MasterCard";
            else if (strCardNum.StartsWith("4"))
                strCardType = "VISA";
            else
                strCardType = "Unknown Card Type";

            //5.
            strCardNum = ReverseString(strCardNum);

            for (i = 0; i < strCardNum.Length; i++)
            {
                intCheckDigit = Convert.ToInt32(strCardNum.Substring(i, 1));

                if ((i + 1) % 2 == 0)
                {
                    intCheckDigit *= 2;

                    if (intCheckDigit > 9)
                    {
                        intCheckDigit -= 9;
                    }
                }

                intCheckSum += intCheckDigit;
            }

            if (intCheckSum % 10 == 0)
            {
                bolValid = true;
            }


            if (bolValid)
            {
                switch (strCardType)
                {
                    case "AMEX":
                        imgCard.Source = new BitmapImage(new Uri(@"/Images/american_express_logo.png", UriKind.Relative));
                        imgCard.Width = 22;
                        imgCard.Height = 22;
                        break;
                    case "Discover":
                        imgCard.Source = new BitmapImage(new Uri(@"/Images/discover_logo.png", UriKind.Relative));
                        imgCard.Width = 32;
                        imgCard.Height = 22;
                        break;
                    case "MasterCard":
                        imgCard.Source = new BitmapImage(new Uri(@"/Images/mastercard_logo.png", UriKind.Relative));
                        imgCard.Width = 37;
                        imgCard.Height = 22;
                        break;
                    case "VISA":
                        imgCard.Source = new BitmapImage(new Uri(@"/Images/visa_logo.png", UriKind.Relative));
                        imgCard.Width = 35;
                        imgCard.Height = 22;
                        break;
                }

                imgCard.Visibility = Visibility.Visible;
                txtCreditCard.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                lblResult.Content = "The Credit Card Is A Valid " + strCardType;
                lblResult.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            }
            else
            {
                txtCreditCard.Background = new SolidColorBrush(Color.FromRgb(255, 200, 200));
                lblResult.Content = "The Credit Card Is Not Valid";
            }
        }

        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtCreditCard.Text = "";
            lblResult.Content = "";
        }
    }
}
      