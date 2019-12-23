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
using AudioDevices.Tracks;

namespace Tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static TrackList mainTracklist = new TrackList();
        public static TrackList MainTracklist { get { return mainTracklist; } set { mainTracklist = value; } }
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);
            mainTracklist.Add(t1);
            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);
            mainTracklist.Add(t2);
            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);
            mainTracklist.Add(t3);
        }

        private void NewTrackClick(object sender, RoutedEventArgs e)
        {
            NewTrack NewTrackWindow = new NewTrack();
            NewTrackWindow.Show();
        }

        private void ShowTracksClick(object sender, RoutedEventArgs e)
        {
            //ShowTracks ShowTracksWindow = new ShowTracks();
            //ShowTracksWindow.Show();
        }

        private void DeleteTracklistClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Wilt u echt de hele lijst wissen?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                mainTracklist.Clear();
            }
        }
    }
}
