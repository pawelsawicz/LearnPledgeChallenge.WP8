using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;

namespace LearnPledgeChallenge.WP8.ViewModels
{
    public class ChallengeViewModel : PropertyChangedBase
    {
        private readonly INavigationService _navigationService;

        public ChallengeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void TryChallenge()
        {
            MessageBox.Show("Challenge friends");
        }
    }
}
