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

        public PledgeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
        }
    }
}
