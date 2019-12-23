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
    /// Interaction logic for NewTrack.xaml
    /// </summary>
    public partial class NewTrack : Window
    {
        public NewTrack()
        {
            InitializeComponent();
        }

        private void SecondenClick(object sender, RoutedEventArgs e)
        {
            LengteStackPanel.SetValue(Grid.RowProperty, 1);
            Seconden.Visibility = Visibility.Visible;
            Minuten.Visibility = Visibility.Hidden;
            Uren.Visibility = Visibility.Hidden;
        }
        private void MinutenSecondenClick(object sender, RoutedEventArgs e)
        {
            LengteStackPanel.SetValue(Grid.RowProperty, 2);
            Seconden.Visibility = Visibility.Visible;
            Minuten.Visibility = Visibility.Visible;
            Uren.Visibility = Visibility.Hidden;
        }
        private void UrenMinutenSecondenClick(object sender, RoutedEventArgs e)
        {
            LengteStackPanel.SetValue(Grid.RowProperty, 3);
            Seconden.Visibility = Visibility.Visible;
            Minuten.Visibility = Visibility.Visible;
            Uren.Visibility = Visibility.Visible;
        }
        private void AddTrackClick(object sender, RoutedEventArgs e)
        {
            Track tr = new Track(Convert.ToInt16(txtID.Text), txtName.Text, txtArtist.Text);
            tr.AlbumSource = txtAlbumSource.Text;
            tr.Style = (Category)cbCategory.SelectedValue;
            if(Minuten.Text == "")
            {
                tr.Length = new Time(Convert.ToInt16(Seconden.Text));
            }
            else if(Uren.Text == "")
            {
                tr.Length = new Time(Convert.ToInt16(Minuten.Text), Convert.ToInt16(Seconden.Text));
            }
            else
            {
                tr.Length = new Time(Convert.ToInt16(Uren.Text), Convert.ToInt16(Minuten.Text), Convert.ToInt16(Seconden.Text));
            }
            MainWindow.MainTracklist.Add(tr);

            txtID.Clear();
            txtName.Clear();
            txtArtist.Clear();
            txtAlbumSource.Clear();
            Uren.Clear();
            Minuten.Clear();
            Seconden.Clear();
            LengteStackPanel.SetValue(Grid.RowProperty, 1);
            Seconden.Visibility = Visibility.Visible;
            Minuten.Visibility = Visibility.Hidden;
            Uren.Visibility = Visibility.Hidden;
            rbSec.IsChecked = true;
        }
    }
}
