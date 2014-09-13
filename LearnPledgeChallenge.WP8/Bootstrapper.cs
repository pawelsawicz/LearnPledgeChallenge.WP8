using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Caliburn.Micro;
using Caliburn.Micro.BindableAppBar;
using LearnPledgeChallenge.WP8.ViewModels;
using LearnPledgeChallenge.WP8.Views;

namespace LearnPledgeChallenge.WP8
{
    public class Bootstrapper : PhoneBootstrapperBase
    {
        PhoneContainer _phoneContainer;

        public Bootstrapper()
        {
            this.Start();
        }

        protected override void Configure()
        {
            _phoneContainer = new PhoneContainer();
            _phoneContainer.RegisterPhoneServices(RootFrame);
            _phoneContainer.PerRequest<MainPageViewModel>();
            _phoneContainer.PerRequest<PledgeViewModel>();
            _phoneContainer.PerRequest<ChallengeViewModel>();

            ConventionManager.AddElementConvention<BindableAppBarMenuItem>(Control.IsEnabledProperty, "DataContext", "Click");
            ConventionManager.AddElementConvention<BindableAppBarButton>(Control.IsEnabledProperty, "DataContext", "Click");
        }

        protected override object GetInstance(Type service, string key)
        {
            return _phoneContainer.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _phoneContainer.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _phoneContainer.BuildUp(instance);
        }

    }
}
