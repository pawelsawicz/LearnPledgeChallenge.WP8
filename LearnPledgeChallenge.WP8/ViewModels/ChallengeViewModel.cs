using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using Microsoft.Phone.Tasks;

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
            ChallengeFriends();

        }

        private void ChallengeFriends()
        {
            var shareLinkTaks = new ShareLinkTask
            {
                Title = "#hack4good app test",
                LinkUri = new Uri("http://wepromi.se/", UriKind.Absolute),
                Message = "#hack4good test message I challenge @sawiczpawel @jghackers"
            };
            shareLinkTaks.Show();
        }
    }
}
