using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Football_Match_Summaries
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<FootMatches> _matchDetails;

        //public static ObservableCollection<Member> _members;

        /*private ObservableCollection<Member> GenerateMembers(int cnt)
        {
            var obvlist = new ObservableCollection<Member>();

            for (int i = 0; i < cnt; i++)
            {
                obvlist.Add(new Member { firstName = "fn" + i, lastName = "ln" + i });
            }

            return obvlist;
        }*/

        /*        private string _firstName = "Akshay";   
                public string FirstName
                {
                    get
                    {
                        return _firstName;
                    }
                    set
                    {
                        *//* _firstName = value;
                         NotifyOfPropertyChange(() => FirstName);*//*
                        _firstName = value;

                    }
                }*/

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Get the needed data

            //_members = GenerateMembers(20);

            _matchDetails = ClassXML.ReadXML<ObservableCollection<FootMatches>>("Football_Match_Details.xml");

            if (_matchDetails == null)
            {
                _matchDetails = new ObservableCollection<FootMatches>();
            }

           


        }

        /*void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl)
            {
                //do work when tab is changed
                _matchDetails = ClassXML.ReadXML<ObservableCollection<FootMatches>>("Football_Match_Details.xml");
                MessageBox.Show("This is " + _matchDetails + " tab");
            }
        }*/

        /* public ObservableCollection<FootMatches> Add_Match(string[] _detailsMatch)
         {
             var obvMatch = new ObservableCollection<FootMatches>();
             //obvMatch.Add(new FootMatches { FirstName = "fn" + i, LastName = "ln" + i });

             return obvMatch;
         }*/

        /*private void Application_Exit(object sender, ExitEventArgs e)
        {
            ClassXML.WriteXml<ObservableCollection<FootMatches>>(_matchDetails, "Football_Match_Details.xml");
        }*/
    }
}
