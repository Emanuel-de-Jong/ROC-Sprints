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
    /// Interaction logic for NewMemorecorders.xaml
    /// </summary>
    public partial class NewMemorecorders : Window
    {
        public NewMemorecorders()
        {
            InitializeComponent();
        }

        //makes an instance of MemoRecorder with the info in the form and adds it to the static list 'AddMemorecorder'
        private void AddMemorecorderClick(object sender, RoutedEventArgs e)
        {
            //adds 1 to Id everytime a MemoRecorder is created
            MainWindow.MemorecorderId += 1;

            MemoRecorder memo = new MemoRecorder(MainWindow.MemorecorderId);
            memo.MaxCartridgeType = (MemoCartridgeType)cbCatridge.SelectedValue;
            memo.Make = txtMerk.Text;
            memo.Model = txtModel.Text;
            memo.PriceExBtw = Convert.ToInt32(txtPrijs.Text);
            memo.CreationDate = Convert.ToDateTime(cbProductisedatum.Text);

            MainWindow.AddMemoRecorder.Add(memo);

            //clears all form fields
            txtMerk.Clear();
            txtModel.Clear();
            txtPrijs.Clear();
            cbProductisedatum.Text = "";
            cbCatridge.Text = "";

            //focuses on the first field of the form
            txtMerk.Focusable = true;
            Keyboard.Focus(txtMerk);
        }
    }
}
