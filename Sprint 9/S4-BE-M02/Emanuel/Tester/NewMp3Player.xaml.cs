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
using AudioDevices.Devices;
using AudioDevices.Tracks;
using System.Drawing;



namespace Tester
{
    /// <summary>
    /// Interaction logic for NewMp3Player.xaml
    /// </summary>
    public partial class NewMp3Player : Window
    {
        public NewMp3Player()
        {
            
            InitializeComponent();
        }
        
        private void OpenFileClick(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png"; // Default file extension
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                
                // Open document
                MainWindow.Mp3Image = dlg.FileName;
                Mp3Image.Source = new BitmapImage(new Uri(MainWindow.Mp3Image));
                
            }
        }

        //makes an instance of Mp3Player with the info in the form and adds it to the static list 'AddMp3Player'
        private void AddMp3PlayerClick(object sender, RoutedEventArgs e)
        {
            //adds 1 to Id everytime a Mp3Player is created
            MainWindow.Mp3PlayerId += 1;
            Mp3Player player = new Mp3Player(MainWindow.Mp3PlayerId);
            player.Make = txtMerk.Text;
            player.Model = txtModel.Text;
            player.PriceExBtw = Convert.ToInt32(txtPrijs.Text);
            player.DisplayWidth = Convert.ToInt32(txtBreedte.Text);
            player.DisplayHeight = Convert.ToInt32(txtHoogte.Text);
            player.CreationDate = DateTime.Parse(cbProductisedatum.Text);
            player.Picture = System.Drawing.Image.FromFile(MainWindow.Mp3Image);

            MainWindow.AddMp3Player.Add(player);

            //clears all form fields
            txtBreedte.Clear();
            txtHoogte.Clear();
            txtMerk.Clear();
            txtModel.Clear();
            txtPrijs.Clear();
            cbProductisedatum.Text = "";
            MainWindow.Mp3Image = "";
            Mp3Image.Source = null;

            //focuses on the first field of the form
            txtMerk.Focusable = true;
            Keyboard.Focus(txtMerk);
        }
    }
}
