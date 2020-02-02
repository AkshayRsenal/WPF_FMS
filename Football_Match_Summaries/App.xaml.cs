using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

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

            //_members = MyStorage.ReadXML<ObservableCollection<Member>>("ClubMembers.xml");

            if (_matchDetails == null)
            {
                _matchDetails = new ObservableCollection<FootMatches>();
            }

           


        }

        private ObservableCollection<FootMatches> Add_Match(string[] cnt)
        {
            var obvMatch = new ObservableCollection<FootMatches>();
            //obvMatch.Add(new FootMatches { FirstName = "fn" + i, LastName = "ln" + i });
           

            return obvMatch;
        }
    }
}
