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

namespace Tester
{
    /// <summary>
    /// Interaction logic for ShowMemorecorders.xaml
    /// </summary>
    public partial class ShowCdDiscMan : Window
    {
        public ShowCdDiscMan()
        {
            InitializeComponent();

            CdDiscManGrid.ItemsSource = MainWindow.AddCdDiscMan;
        }
    }
}
