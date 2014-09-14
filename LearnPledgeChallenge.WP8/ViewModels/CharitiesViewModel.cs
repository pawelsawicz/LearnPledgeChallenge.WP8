using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;

namespace LearnPledgeChallenge.WP8.ViewModels
{
    public class CharitiesViewModel : PropertyChangedBase
    {
        private readonly INavigationService _navigationService;

        public CharitiesViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LoadCharities();
        }

        public void TileTap()
        {
            MessageBox.Show("saddaads");
        }

        private void LoadCharities()
        {
            
        }
    }
}
