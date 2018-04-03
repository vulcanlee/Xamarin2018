using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Unity.Attributes;

namespace XFDeepLink.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public DelegateCommand GoPage1Command { get; set; }
        public DelegateCommand GoDeeplyPage31Command { get; set; }
        
        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;

            GoPage1Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("Page1Page");
            });
            GoDeeplyPage31Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("Page1Page/Page2Page/Page3Page");
                //await _navigationService.NavigateAsync("Page1Page/NavigationPage/Page2Page/NavigationPage/Page3Page");
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }
    }
}
