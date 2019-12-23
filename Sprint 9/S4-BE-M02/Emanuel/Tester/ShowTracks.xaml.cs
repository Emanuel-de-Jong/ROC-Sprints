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
using AudioDevices.Tracks;

namespace Tester
{
    /// <summary>
    /// Interaction logic for ShowTracks.xaml
    /// </summary>
    public partial class ShowTracks : Window
    {
        public ShowTracks()
        {
            InitializeComponent();
            TrackGrid.ItemsSource = GridData();
        }
        //updates the datagrid data with 'MainTracklist'
        public List<Track> GridData()
        {
            //updates a label with info about the datagrid
            txtInfo.Content = $"Totaal {MainWindow.MainTracklist.Count} tracks met een totale lengte van {MainWindow.MainTracklist.TotalTime}";
            return MainWindow.MainTracklist.GetAllTracks();
        }

        //shuffles the datagrid
        private void ShuffleTracks(object sender, RoutedEventArgs e)
        {
            TrackGrid.ItemsSource = MainWindow.MainTracklist.Shuffle();
        }

        //clears 'MainTracklist'
        private void ClearTrackList(object sender, RoutedEventArgs e)
        {
            //first asks for comfirmation
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Wilt u echt de hele lijst wissen?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                MainWindow.MainTracklist.Clear();
                TrackGrid.ItemsSource = GridData();
            }
        }
    }
}
