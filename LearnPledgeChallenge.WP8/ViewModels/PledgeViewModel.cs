using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;

namespace LearnPledgeChallenge.WP8.ViewModels
{
    public class PledgeViewModel : PropertyChangedBase
    {
        private readonly INavigationService _navigationService;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                NotifyOfPropertyChange(() => Email);
            }
        }

        private string _pledge;
        public string Pledge
        {
            get { return _pledge; }
            set
            {
                _pledge = value;
                NotifyOfPropertyChange(() => Pledge);
            }
        }

        private string _forfeit;
        public string Forfeit
        {
            get { return _forfeit; }
            set
            {
                _forfeit = value;
                NotifyOfPropertyChange(() => Forfeit);
            }
        }


        public PledgeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void TryPledge()
        {
            MessageBox.Show("Try Pledge");
        }
    }
}
