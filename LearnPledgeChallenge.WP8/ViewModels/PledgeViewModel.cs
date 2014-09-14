using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using LearnPledgeChallenge.WP8.Data;

namespace LearnPledgeChallenge.WP8.ViewModels
{
    public class PledgeViewModel : PropertyChangedBase
    {
        private readonly INavigationService _navigationService;
        private readonly PledgeRepository _pledgeRepository;

        private string _customerName;
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                _customerName = value;
                NotifyOfPropertyChange(() => CustomerName);
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

        private DateTime _datePicker;
        public DateTime DatePicker
        {
        get { return _datePicker; }
            set
            {
                _datePicker = value;
                NotifyOfPropertyChange(() => DatePicker);
            }
        }

        public PledgeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _pledgeRepository = new PledgeRepository();
            DatePicker = DateTime.Now;
        }

        public async void TryPledge()
        {
            var result = await _pledgeRepository.Add(new Pledge
            {
                Email = this.Email,
                ExpirationDateTime = this.DatePicker,
                Forfeit = this.Forfeit,
                Name = this.CustomerName,
                PledgeText = this.Pledge
            });
            if (result)
            {
                MessageBox.Show("Your pledge has been created");
            }
            else
            {
                MessageBox.Show("Something went wrong, try again");
            }
        }
    }
}
