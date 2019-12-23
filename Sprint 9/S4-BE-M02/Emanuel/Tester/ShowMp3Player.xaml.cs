using System;
using System.Collections.Generic;
using System.IO;
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
using System.Drawing;
using System.Drawing.Imaging;



namespace Tester
{
    /// <summary>
    /// Interaction logic for ShowMp3Player.xaml
    /// </summary>
    public partial class ShowMp3Player : Window
    {
        //initilize 
        public ShowMp3Player()
        {
            InitializeComponent();

            Mp3PlayerGrid.ItemsSource = MainWindow.AddMp3Player;
        }

        //look if the list selection changed
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //select the player
            Mp3Player player = (Mp3Player)Mp3PlayerGrid.SelectedItem;

            //look ig the player has a image
            if (player.Picture != null)
            {
                //show the image
                Mp3Image.Source = Convert(player.Picture);
            }
            else
            {
                //clear the image
                Mp3Image.Source = null;
            }
        }

        //convert system.drwaing.image to bitmapimage
        public BitmapImage Convert(System.Drawing.Image img)
        {
            using (var memory = new MemoryStream())
            {
                img.Save(memory, ImageFormat.Png);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }
    }


}