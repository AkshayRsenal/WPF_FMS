using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Football_Match_Summaries
{
    public class FootMatches
    {
     
        public string Team1{ get; set; }
        public string Team2{ get; set; }
        public string MatchDate{ get; set; }
        public string typeOfPitch{ get; set; }

        /*public string Add_Match(string[] _detailsMatch)
        {
            var obvMatch = new ObservableCollection<FootMatches>();
            //obvMatch.Add(new FootMatches { FirstName = "fn" + i, LastName = "ln" + i });
            if (_detailsMatch != null)
            {
                MessageBox.Show("Please " + _detailsMatch[2]);
                *//* MessageBox.Show("Please " + _detailsMatch["Team1"]);
                 MessageBox.Show("Please " + _detailsMatch["typeOfPitch"]);
                 MessageBox.Show("Please " + _detailsMatch["MatchDate"]); */
                /* var Team1 = _detailsMatch["Team1"];
                 var Team2 = _detailsMatch["Team2"];*/
                /*obvMatch.Add(_detailsMatch["Team2"]);*/
                /*ClassXML.WriteXml<Dictionary<string, string>>(_detailsMatch, "Football_Match_Details.xml");*//*
                ClassXML.WriteXml<string[]>(_detailsMatch, "Football_Match_Details.xml");


            }

            return "Msg";
        }*/

        public ObservableCollection<FootMatches> Add_Match(Dictionary<string, string> _detailsMatch)
        {
            var obvMatch = new ObservableCollection<FootMatches>();
            //obvMatch.Add(new FootMatches { FirstName = "fn" + i, LastName = "ln" + i });
            if (_detailsMatch != null)
            {
                /*MessageBox.Show("Please " + _detailsMatch[2]);*/
                MessageBox.Show("Please " + _detailsMatch["Team1"]);
                MessageBox.Show("Please " + _detailsMatch["typeOfPitch"]);
                MessageBox.Show("Please " + _detailsMatch["MatchDate"]);
                var team_one = _detailsMatch["Team1"];
                var team_two = _detailsMatch["Team2"];
                
                obvMatch.Add(new FootMatches { Team1 = _detailsMatch["Team1"] , Team2= _detailsMatch["Team2"], MatchDate = _detailsMatch["MatchDate"], typeOfPitch = _detailsMatch["typeOfPitch"] });
                /*ClassXML.WriteXml<Dictionary<string, string>>(_detailsMatch, "Football_Match_Details.xml");*/
                ClassXML.WriteXml<ObservableCollection<FootMatches>>(obvMatch, "Football_Match_Details.xml");


            }

            return obvMatch;
        }
/*
        public string Add_Match(Dictionary<string, string> _detailsMatch)
        {
            var obvMatch = new ObservableCollection<FootMatches>();
            //obvMatch.Add(new FootMatches { FirstName = "fn" + i, LastName = "ln" + i });
            if (_detailsMatch != null)
            {
                *//*MessageBox.Show("Please " + _detailsMatch[2]); */
                /* MessageBox.Show("Please " + _detailsMatch["Team1"]);
                 MessageBox.Show("Please " + _detailsMatch["typeOfPitch"]);
                 MessageBox.Show("Please " + _detailsMatch["MatchDate"]); *//*
                var Team1 = _detailsMatch["Team1"];
                var Team2 = _detailsMatch["Team2"];
                obvMatch.Add(Team1);
                ClassXML.WriteXml<ObservableCollection<FootMatches>>(_detailsMatch, "Football_Match_Details.xml");

            }

            return "Msg";
        }
 */
 
        /*internal string Add_Match(IEnumerable<Dictionary<string, string>> list)
        {
            throw new NotImplementedException();
        }*/

        /*internal string Add_Match(Dictionary<string, string> detailsMatch)
        {
            throw new NotImplementedException();
        }*/
    }
}
