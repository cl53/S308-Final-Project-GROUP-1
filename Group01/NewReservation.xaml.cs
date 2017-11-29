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
using Newtonsoft.Json;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace Group01
{
    /// <summary>
    /// Interaction logic for NewReservation.xaml
    /// </summary>
    public partial class NewReservation : Window
    {
        List<Room> RoomList;
        public NewReservation()
        {
            InitializeComponent();
            RoomList = new List<Room>();
            dtpCheckIn.DisplayDateStart = DateTime.Now;
            dtpCheckOut.DisplayDateStart = DateTime.Now.AddDays(1);

        }

        private void btnGetQuote_Click(object sender, RoutedEventArgs e)
        {
            Quote newQuote;
            string strResults, strNumOfNights, strNumOfRooms, strRoomType, strRate, strSubTotal, strTax, strConFee, strTotal;
            double dblRatePerNight, dblTaxRate, dblTax, dblSubTotal, dblTotal;
            int intNumberOfRooms,intNumOfNights, intConvinienceFee;
            DateTime? dtStartDate, dtEndDate;
            strNumOfRooms = txtNumOfRooms.Text.Trim();
            dtStartDate = dtpCheckIn.SelectedDate;
            dtEndDate = dtpCheckOut.SelectedDate;
            dblTaxRate = .07;
        

            //Validations
            if (strNumOfRooms == "")
            {
                MessageBox.Show("Please enter a number for Number of Rooms!");
                txtNumOfRooms.Text = "";
                txtNumOfRooms.Focus();
                return;
            
            }
                    
            if (!int.TryParse(strNumOfRooms, out intNumberOfRooms))
            {
                MessageBox.Show("Please enter a whole number less than 100 and greater than 0for Number of Rooms!");
                txtNumOfRooms.Text = "";
                txtNumOfRooms.Focus();
                return;
            }

            // 30 should be dynamic 
            if (!(intNumberOfRooms > 0 && intNumberOfRooms <= 30))
            {
                MessageBox.Show("Please enter a whole number greater than 0 and less than 100 for the room type you selected");
                txtNumOfRooms.Text = "";
                txtNumOfRooms.Focus();
                return;

            }
            //validate if user selected an item in the comboBox
            if (cbxRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room type in the dropdown box");
                cbxRoomType.Focus();
                return;
            }

            //validate if user selected a date
            if (dtStartDate == null || dtEndDate == null)
            {
                if (dtStartDate == null) { MessageBox.Show("Please pick a date for Start Date"); dtpCheckIn.Focus(); }
                else {
                    MessageBox.Show("Please Pick a date for End date"); dtpCheckOut.Focus();
                    dtpCheckIn.DisplayDateStart = Convert.ToDateTime(dtpCheckIn.SelectedDate).AddDays(1);
                }

                return;
            }
            //validate if start date is before today
            if (dtStartDate < DateTime.Now)
            {
                MessageBox.Show("Start Date cannot be in the past");
                dtpCheckIn.SelectedDate = null;
                dtpCheckOut.Focus();
                return;
            }
            // validate if end date is before start date
            if (dtEndDate <= dtStartDate)
            {
                MessageBox.Show("End Date must be after the Start Date");
                dtpCheckOut.SelectedDate = null;
                dtpCheckOut.DisplayDateStart = Convert.ToDateTime(dtpCheckIn.SelectedDate).AddDays(1);
                return;
            }
            // declare a datetime (Convcert and cast value)
            DateTime dtDatetime1 = Convert.ToDateTime(dtStartDate), dtDateTime2 = Convert.ToDateTime(dtEndDate);

            //calculate the length of stay 
            TimeSpan tspLengthOfStay = dtDateTime2 - dtDatetime1;
            intNumOfNights = Convert.ToInt32(tspLengthOfStay.TotalDays);
            strNumOfNights = intNumOfNights.ToString();

            //Store the number of rooms
            intNumberOfRooms = Convert.ToInt32(txtNumOfRooms.Text);

            //Convert the comboBox item to string
            ComboBoxItem SelectedItem = (ComboBoxItem)cbxRoomType.SelectedItem;
            strRoomType = SelectedItem.Content.ToString();

            //Import json file
            //1.Prompt user to select a file to import
            //2.if user selected a file, import data from the file selected
            //3.Refresh the datagrid

            //1.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                //2.
                LoadSelectedFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Import Failure. Please check your file.");
            }

            
           

            //Query to get room price
            Room SelectedRoom = RoomList.Where(R => R.RoomType == strRoomType).FirstOrDefault();
            strRate = SelectedRoom.RoomPrice.ToString("C2");
            dblRatePerNight = SelectedRoom.RoomPrice;

            //Calculate Subtotal
            dblSubTotal = intNumOfNights * dblRatePerNight *intNumberOfRooms;
            strSubTotal = dblSubTotal.ToString("C2");

            //Calculate the tax
            dblTax = dblSubTotal * dblTaxRate;
            strTax = dblTax.ToString("C2");

            //Calculate the Convenience Fee
            intConvinienceFee = 10 * intNumOfNights;
            strConFee = intConvinienceFee.ToString("C2");

            //Calculate the Total
            dblTotal = dblSubTotal + dblTax + intConvinienceFee;
            strTotal = dblTotal.ToString("C2");


            //Input the text into strResults

            strResults = "Number of Nights: " + strNumOfNights + Environment.NewLine + "Rate Per Night: " + strRate + Environment.NewLine + "*****************" + Environment.NewLine + "Subtotal: "+ strSubTotal + Environment.NewLine + "Tax: "+ strTax + Environment.NewLine + "Convenience Fee: " + strConFee + Environment.NewLine + "Total: "+strTotal;

            //Fill in the Room Quote text box
            txtRoomQuote.Text = strResults;

        }

        private void btnReturnToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow demoWindow = new MainWindow();
            demoWindow.Show();
            this.Close();

        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            MakeReservation demoWindow = new MakeReservation();
            demoWindow.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumOfRooms.Text = "";
            txtRoomQuote.Text = "";
            cbxRoomType.SelectedIndex = -1;
            dtpCheckIn.Text = "";
            dtpCheckOut.Text = "";
            dtpCheckIn.DisplayDateStart = DateTime.Now;
            dtpCheckOut.DisplayDateStart = DateTime.Now.AddDays(1);

        }

        private void dtpCheckIn_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dtpCheckOut.SelectedDate = null;
            dtpCheckOut.DisplayDateStart = Convert.ToDateTime(dtpCheckIn.SelectedDate).AddDays(1);
        }
        #region Helper Functions
        private void Clear()
        {
            //clear all input fields
            txtNumOfRooms.Text = "";
            dtpCheckIn.Text = "";
            dtpCheckOut.Text = "";
            txtRoomQuote.Text = "";
            cbxRoomType.SelectedIndex = -1;
        }
       
        private string GetFilePath(bool withTimestamp)
        {
            //function to get the file path of Customers_Test
            string strFilePath = @"..\..\..\Data\RoomInfo";
            string strTimestamp = DateTime.Now.Ticks.ToString();

            if (withTimestamp)
            {
                strFilePath += "_" + strTimestamp;
            }
            strFilePath += ".json";

            return strFilePath;
        }

        private void LoadSelectedFile(string strFileName)
        {
            //Import from the file selected
            try
            {
                string jsonData = File.ReadAllText(strFileName);
                RoomList = JsonConvert.DeserializeObject<List<Room>>(jsonData);
                if (RoomList.Count >= 0)
                    MessageBox.Show(RoomList.Count + " Room Types have been imported.");
                else
                    MessageBox.Show("No Rooms has been imported. Please check your file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in import process: " + ex.Message);
            }
        }

        
        #endregion
    }

}
