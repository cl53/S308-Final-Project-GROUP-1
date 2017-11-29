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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Group01
{
    ///Dakota Coates, Chenqi Li, Yuqi Xiao
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Enterprise Logo is from Memory-Alpha
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
     ///Dakota Coates, Chenqi Li, Yuqi Xiao
            InitializeComponent();
        }

        private void btnNavToNewReservation_Click(object sender, RoutedEventArgs e)
        {
            NewReservation demoWindow = new NewReservation();
            demoWindow.Show();
            this.Close();

        }

        private void btnNavToRoomMgmt_Click(object sender, RoutedEventArgs e)
        {
            RoomManagement demoWindow = new RoomManagement();
            demoWindow.Show();
            this.Close();
        }

        private void btnNavToReservationReport_Click(object sender, RoutedEventArgs e)
        {
            ReservationReport demoWindow = new ReservationReport();
            demoWindow.Show();
            this.Close();
        }

        private void btnNavToRoomPreview_Click(object sender, RoutedEventArgs e)
        {
            RoomPreview demoWindow = new RoomPreview();
            demoWindow.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
