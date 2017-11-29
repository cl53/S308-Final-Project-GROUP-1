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

namespace Group01
{
    /// <summary>
    /// Interaction logic for ReservationReport.xaml
    /// </summary>
    public partial class ReservationReport : Window
    {
        public ReservationReport()
        {
            InitializeComponent();
        }

        private void btnReturnToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow demoWindow = new MainWindow();
            demoWindow.Show();
            this.Close();
        }

        private void btnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            string strFirstName, strLastName, strReport;
            DateTime? dtStartDate, dtEndDate;
            int intNumOfNights;
            strFirstName = txtFirstName.Text;
            strLastName = txtLastName.Text;
            dtStartDate = dtpFromThisDate.SelectedDate;
            dtEndDate = dtpToThisDate.SelectedDate;
            intNumOfNights = 0;

            //validate if user selected a date
            if (dtStartDate == null || dtEndDate == null)
            {
                if (dtStartDate == null) { MessageBox.Show("Please pick a date for Start Date"); dtpFromThisDate.Focus(); }
                else {
                    MessageBox.Show("Please Pick a date for End date"); dtpToThisDate.Focus();
                    dtpFromThisDate.DisplayDateStart = Convert.ToDateTime(dtpFromThisDate.SelectedDate).AddDays(1);
                }

                return;
            }

            // validate if end date is before start date
            if (dtEndDate <= dtStartDate)
            {
                MessageBox.Show("End Date must be after the Start Date");
                dtpToThisDate.SelectedDate = null;
                dtpToThisDate.DisplayDateStart = Convert.ToDateTime(dtpFromThisDate.SelectedDate).AddDays(1);
                return;
            }

            //validate that the user entered a last name
            if (strLastName == "")
            {
                MessageBox.Show("Please enter a name into the last name box");
                txtLastName.Focus();
                return;
            }
            //validate that the user entered a first name
            if ( strFirstName == "")
            {
                MessageBox.Show("Please enter a name into the first name box");
                txtFirstName.Focus();
                return;
            }
                        
            //validate that the user selected a room type
            if (cbxRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room type from the dropdown.");
                cbxRoomType.Focus();
                return;
            }

            // declare a datetime (Convcert and cast value)
            DateTime dtDatetime1 = Convert.ToDateTime(dtStartDate), dtDateTime2 = Convert.ToDateTime(dtEndDate);

            //calculate the length of stay -- currently a placeholder until we determine info storage
            TimeSpan tspLengthOfStay = dtDateTime2 - dtDatetime1;
            intNumOfNights = Convert.ToInt32(tspLengthOfStay.TotalDays);

            //Fill in the text box
            strReport = "HOTEL INFOMRATION" + Environment.NewLine;
            strReport = strReport+"Check-In Date: " + Environment.NewLine;
            strReport = strReport + "Number of Nights: " + intNumOfNights.ToString() + Environment.NewLine;
            strReport = strReport + "Room Type: " + cbxRoomType.Text+ Environment.NewLine;
            strReport = strReport + "Number of Rooms: " + Environment.NewLine;
            strReport = strReport + "Room Price: " + Environment.NewLine;
            strReport = strReport + "Total: " + Environment.NewLine+Environment.NewLine;
            strReport = strReport + "CUSTOMER INFORMATION" + Environment.NewLine;
            strReport = strReport + "First Name: " + txtFirstName.Text + Environment.NewLine;
            strReport = strReport + "Last Name: " + txtLastName.Text + Environment.NewLine;
            strReport = strReport + "Phone: " + Environment.NewLine;
            strReport = strReport + "Email: " + Environment.NewLine;

            txtRoomReport.Text = strReport;

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            dtpFromThisDate.SelectedDate = null;
            dtpToThisDate.SelectedDate = null;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cbxRoomType.SelectedIndex = -1;
            txtRoomReport.Text = "";
        }
    }
}
