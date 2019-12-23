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
using AudioDevices.Devices;

namespace Tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //set the private fields
        private static TrackList mainTracklist = new TrackList();
        private static List<MemoRecorder> addMemorecorder = new List<MemoRecorder>();
        private static int memorecorderId = 0;
        private static List<CdDiscMan> addCdDiscMen = new List<CdDiscMan>();
        private static int cdDiskManId = 0;
        private static List<Mp3Player> addMp3Player = new List<Mp3Player>();
        private static int mp3PlayerId = 0;
        private static string mp3Image;

        //set the properties
        public static TrackList MainTracklist { get { return mainTracklist; } set { mainTracklist = value; } }
        public static List<MemoRecorder> AddMemoRecorder { get { return addMemorecorder; } set { addMemorecorder = value; } }
        public static int MemorecorderId { get { return memorecorderId; } set { memorecorderId = value; } }
        public static List<CdDiscMan> AddCdDiscMan { get { return addCdDiscMen; } set { addCdDiscMen = value; } }
        public static int CdDiskManId { get { return cdDiskManId; } set { cdDiskManId = value; } }
        public static List<Mp3Player> AddMp3Player { get { return addMp3Player; } set { addMp3Player = value; } }
        public static int Mp3PlayerId { get { return mp3PlayerId; } set { mp3PlayerId = value; } }
        public static string Mp3Image { get { return mp3Image; } set { mp3Image = value; } }

        //initilaize 
        public MainWindow()
        {
            InitializeComponent();
            //start the window in the center of the screen
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            //set the debug vaules
            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);
            mainTracklist.Add(t1);
            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);
            mainTracklist.Add(t2);
            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);
            mainTracklist.Add(t3);

            MemoRecorder memo1 = new MemoRecorder(1000);
            memo1.MaxCartridgeType = MemoCartridgeType.C90;
            memo1.CreationDate = DateTime.Now.AddMonths(-6);
            addMemorecorder.Add(memo1);
            MemoRecorder memo2 = new MemoRecorder(500);
            memo2.MaxCartridgeType = MemoCartridgeType.C120;
            memo2.CreationDate = DateTime.Now.AddMonths(-3);
            addMemorecorder.Add(memo2);

            CdDiscMan discman1 = new CdDiscMan(1000);
            discman1.Make = "JVC";
            discman1.Model = "HG-410";
            addCdDiscMen.Add(discman1);
            CdDiscMan discman2 = new CdDiscMan(500);
            discman2.Make = "VCJJ";
            discman2.Model = "AK-47";
            addCdDiscMen.Add(discman2);

            Mp3Player player1 = new Mp3Player(1000);
            player1.Make = "Activa";
            player1.Model = "Beta";
            addMp3Player.Add(player1);
            Mp3Player player2 = new Mp3Player(500);
            player2.Make = "Creative";
            player2.Model = "Alpha";
            addMp3Player.Add(player2);

       
        }


        //open the New Track window
        private void NewTrackClick(object sender, RoutedEventArgs e)
        {
            NewTrack NewTrackWindow = new NewTrack();
            NewTrackWindow.Show();
        }

        //open the show tracks window
        private void ShowTracksClick(object sender, RoutedEventArgs e)
        {
            ShowTracks ShowTracksWindow = new ShowTracks();
            ShowTracksWindow.Show();
        }
        //delete teh tracks
        private void DeleteTracklistClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Wilt u echt de hele lijst wissen?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                mainTracklist.Clear();
            }
        }


        //open the new Memo Recorder window
        private void NewMemorecorderClick(object sender, RoutedEventArgs e)
        {
            NewMemorecorders NewMemorecordersWindow = new NewMemorecorders();
            NewMemorecordersWindow.Show();
        }

        //open the list of memo recorder list
        private void ListMemorecorderClick(object sender, RoutedEventArgs e)
        {
            ShowMemorecorders ShowMemorecordersWindow = new ShowMemorecorders();
            ShowMemorecordersWindow.Show();
        }

        //Delete the Memorecordes
        private void DeleteMemorecorderClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Wilt u echt de hele lijst wissen?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                addMemorecorder.Clear();
                memorecorderId = 0;
            }
        }


        //open the new Cd discman window
        private void NewCdDiscManClick(object sender, RoutedEventArgs e)
        {
            NewCdDiscMan NewCdDiscManWindow = new NewCdDiscMan();
            NewCdDiscManWindow.Show();
        }

        //open the list of Cddisc man
        private void ListCdDiscManClick(object sender, RoutedEventArgs e)
        {
            ShowCdDiscMan ShowCdDiscManWindow = new ShowCdDiscMan();
            ShowCdDiscManWindow.Show();
        }

        //Delete the CdDiscsmans
        private void DeleteCdDiscManClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Wilt u echt de hele lijst wissen?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                addCdDiscMen.Clear();
                cdDiskManId = 0;
            }
        }


        //open the New Mp3player window
        private void NewMp3PlayerClick(object sender, RoutedEventArgs e)
        {
            NewMp3Player NewMp3PlayerWindow = new NewMp3Player();
            NewMp3PlayerWindow.Show();
        }

        //open the list op mp3players
        private void ListMp3PlayerClick(object sender, RoutedEventArgs e)
        {
            ShowMp3Player ShowMp3PlayerWindow = new ShowMp3Player();
            ShowMp3PlayerWindow.Show();
        }

        //delete the mp3 players
        private void DeleteMp3PlayerClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Wilt u echt de hele lijst wissen?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                addMp3Player.Clear();
                mp3PlayerId = 0;
            }
        }
    }
}
