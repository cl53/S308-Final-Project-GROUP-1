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
    /// Interaction logic for RoomPreview.xaml
    /// </summary>
    /// 
    ///All Images for the rooms are from JW Marriot Indianapolis. 
    public partial class RoomPreview : Window
    {
        public RoomPreview()
        {
            InitializeComponent();

           
        }


        private void btnReturnToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow demoWindow = new MainWindow();
            demoWindow.Show();
            this.Close();
        }

        private void cbxRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int intRoomIndex;
            intRoomIndex = cbxRoomType.SelectedIndex;

            if (intRoomIndex == 0)
            {
                imgRooms.Source = new BitmapImage(new Uri(@"Images/one_king_room.jpg", UriKind.Relative));
            }
            else if (intRoomIndex == 1)
            {
                imgRooms.Source = new BitmapImage(new Uri(@"Images/one_king_Deluxe.jpg", UriKind.Relative));
            }
            else if (intRoomIndex == 2)
            {
                imgRooms.Source = new BitmapImage(new Uri(@"Images/two_queen.jpg", UriKind.Relative));
            }
            else if (intRoomIndex == 3)
            {
                imgRooms.Source = new BitmapImage(new Uri(@"Images/two_queen_deluxe.jpg", UriKind.Relative));
            }
            else if (intRoomIndex == 4)
            {
                imgRooms.Source = new BitmapImage(new Uri(@"Images/one_king_suite.jpg", UriKind.Relative));
            }
            else if (intRoomIndex == 5)
            {
                imgRooms.Source = new BitmapImage(new Uri(@"Images/one_king_presidential_Suite.jpg", UriKind.Relative));
            }
            else MessageBox.Show("Please select a room type from the dropdown");


        }
    }
}
