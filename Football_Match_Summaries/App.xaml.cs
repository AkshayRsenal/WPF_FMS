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

        private string _firstName = "Akshay";   
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                /* _firstName = value;
                 NotifyOfPropertyChange(() => FirstName);*/
                _firstName = value;

            }
        }
    }
}
