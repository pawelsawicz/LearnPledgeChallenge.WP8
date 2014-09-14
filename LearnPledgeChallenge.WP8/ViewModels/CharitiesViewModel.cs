﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.Foundation.Metadata;
using Caliburn.Micro;
using LearnPledgeChallenge.WP8.Data;
using Microsoft.Phone.SecureElement;
using Microsoft.Phone.Tasks;

namespace LearnPledgeChallenge.WP8.ViewModels
{
    public class CharitiesViewModel : PropertyChangedBase
    {
        private readonly INavigationService _navigationService;
        private readonly JustGivingCharityRepository _justGivingCharityRepository;

        public BindableCollection<Chairty> Charities { get; set; }

        public CharitiesViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _justGivingCharityRepository = new JustGivingCharityRepository();
            Charities = new BindableCollection<Chairty>();
            LoadCharities();
        }

        public void TileTap()
        {
            var linktoNavigate = CreateSimpleDonationIntegrationLink(2344);
            var webBrowserTask = new WebBrowserTask
            {
                Uri = new Uri(linktoNavigate, UriKind.Absolute)
            };
            webBrowserTask.Show();
        }

        private string CreateSimpleDonationIntegrationLink(int charityId)
        {
            var amountOfMoney = "5";
            var reference = "wepromise";
            var exitUrl = "";
            var completeString = string.Format("http://www.justgiving.com/4w350m3/donation/direct/charity/{0}?amount={1}&reference={2}", charityId, amountOfMoney, reference);
            return completeString;
        }

        private async void LoadCharities()
        {
            var charities = await _justGivingCharityRepository.GetRecommendedChairties();
            Charities.AddRange(charities);
        }
    }
}
