using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;

namespace LearnPledgeChallenge.WP8.ViewModels
{
    public class MainPageViewModel : PropertyChangedBase
    {
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void NavigateToPledge()
        {
            _navigationService.Navigate(new Uri("/Views/PledgeView.xaml", UriKind.Relative));
        }

        public void NavigateToChallenge()
        {
            _navigationService.Navigate(new Uri("/Views/ChallengeView.xaml", UriKind.Relative));
        }

        public void NavigateToCharities()
        {
            _navigationService.Navigate(new Uri("/Views/CharitiesView.xaml", UriKind.Relative));
        }
    }
}
