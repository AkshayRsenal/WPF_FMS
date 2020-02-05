using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
/*using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;*/
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Football_Match_Summaries
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window /*INotifyPropertyChanged*/
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // FootballMatchStats.ItemsSource = App._members;
        }

        /*private void Reset_Click(object sender, RoutedEventArgs e)
        {
            BoundNumber = 0;

        }

        private int _boundNumber;
        public int BoundNumber
        {
            get { return _boundNumber; }
            set
            {
                if (_boundNumber != value)
                {
                    _boundNumber = value;
                    OnPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/

        private void Match_Save_Click(object sender, RoutedEventArgs e)
        {

            string team1 = t1ComboBox.SelectedValue.ToString();
            string team2 = t2ComboBox.SelectedValue.ToString();
            DateTime? selectedDate = matchDate.SelectedDate;
            /*if (selectedDate.HasValue)
            {
                string newMatchDate = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }*/
            string newMatchDate = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            string pitchType = comboBoxpitch.SelectedValue.ToString();

            var detailsMatch = new Dictionary<string, string>();

            detailsMatch.Add("Team1", team1);
            detailsMatch.Add("Team2", team2);
            detailsMatch.Add("MatchDate", newMatchDate);
            detailsMatch.Add("typeOfPitch", pitchType);

            /*var list = detailsMatch.Select(p => new Dictionary<string, string>() { { p.Key, p.Value } });*/

            string[] matchDetails = { team1, team2, newMatchDate, pitchType };

            var fixtureDetails = new FootMatches { Team1 = team1, Team2 = team2, MatchDate = newMatchDate, typeOfPitch = pitchType };
            App._matchDetails.Add(fixtureDetails);
            /*var mem = new FootMatches { FirstName = "Please Edit", LastName = "Please Edit" };*/

            FootMatches appObj = new FootMatches();
            /*string asd =*/ appObj.Add_Match(detailsMatch);


        }


    }
}
