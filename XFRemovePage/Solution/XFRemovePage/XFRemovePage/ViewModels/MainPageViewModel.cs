using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFRemovePage.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;
        public DelegateCommand GotoDetailPageCommand { get; set; }
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GotoDetailPageCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("DetailPage");
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
