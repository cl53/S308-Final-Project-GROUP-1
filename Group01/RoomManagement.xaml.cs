using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using Microsoft.Win32;
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
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Window
    {
        public RoomManagement()
        {
            InitializeComponent();
        }

        List<Room> RoomList;
        private void btnReturnToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow demoWindow = new MainWindow();
            demoWindow.Show();
            this.Close();
        }



        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //clear all input fields
            txtCurrentRoomInfo.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            cbxRoomType.SelectedIndex = -1;
        }

        private void btnUpdateRoomInfo_Click(object sender, RoutedEventArgs e)
        {
            double dblUpdatePrice;
            double dblUpdateQuantity;

        }

        private void cbxRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }


        private string GetFilePath(bool withTimestamp)
        {
            //function to get the file path of Customers_Test
            string strFilePath = @"..\..\..\Data\RoomInfo.json";
            return strFilePath;    
        }

        private void LoadSelectedFile(string strFileName)
        {
            //Import from the file selected
            try
            {
                string jsonData = File.ReadAllText(strFileName);
                RoomList = JsonConvert.DeserializeObject<List<Room>>(jsonData);
                ComboBoxItem SelectedItem = (ComboBoxItem)cbxRoomType.SelectedItem;
                string strRoomType = SelectedItem.Content.ToString();
                if (RoomList.Count >= 0)
                {
                    MessageBox.Show(RoomList.Count + " Room Types have been imported.");
                    //Query to get room price
                    Room SelectedRoom = RoomList.Where(R => R.RoomType == strRoomType).FirstOrDefault();
                    //txtCurrentRoomInfo.Text = RoomList.
                }
                else
                    MessageBox.Show("No Rooms has been imported. Please check your file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in import process: " + ex.Message);
            }
        }
    }
}
