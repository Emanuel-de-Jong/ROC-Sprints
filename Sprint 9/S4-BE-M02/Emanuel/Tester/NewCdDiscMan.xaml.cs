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

namespace Tester
{
    /// <summary>
    /// Interaction logic for NewCdDiscMan.xaml
    /// </summary>
    public partial class NewCdDiscMan : Window
    {
        public NewCdDiscMan()
        {
            InitializeComponent();
        }

        //makes an instance of CdDiscMan with the info in the form and adds it to the static list 'AddCdDiscMan'
        private void AddCdDiskManClick(object sender, RoutedEventArgs e)
        {
            //adds 1 to Id everytime a CdDiscMan is created
            MainWindow.CdDiskManId += 1;

            CdDiscMan discman = new CdDiscMan(MainWindow.CdDiskManId);
            discman.Make = txtMerk.Text;
            discman.Model = txtModel.Text;
            discman.PriceExBtw = Convert.ToInt32(txtPrijs.Text);
            discman.DisplayWidth = Convert.ToInt32(txtBreedte.Text);
            discman.DisplayHeight = Convert.ToInt32(txtHoogte.Text);
            discman.CreationDate = Convert.ToDateTime(cbProductisedatum.Text);
            discman.MBSize = Convert.ToInt32(txtMBSize);

            //Eject is a toggle. This way, It's turned on when the checkbox is checked and the other way around
            if (cbUitgeworpen.IsChecked.Value && !discman.IsEjected)
            {
                discman.Eject();
            }
            else if (!cbUitgeworpen.IsChecked.Value && discman.IsEjected)
            {
                discman.Eject();
            }

            MainWindow.AddCdDiscMan.Add(discman);

            //clears all form fields
            txtBreedte.Clear();
            txtHoogte.Clear();
            txtMBSize.Clear();
            txtMerk.Clear();
            txtModel.Clear();
            txtPrijs.Clear();
            cbProductisedatum.Text = "";
            cbUitgeworpen.IsChecked = false;

            //focuses on the first field of the form
            txtMerk.Focusable = true;
            Keyboard.Focus(txtMerk);
        }
    }
}
