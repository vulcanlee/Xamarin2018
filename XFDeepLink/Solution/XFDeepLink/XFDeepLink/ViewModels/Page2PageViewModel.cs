﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFDeepLink.ViewModels
{
    public class Page2PageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public DelegateCommand GoPage3Command { get; set; }
        private readonly INavigationService _navigationService;

        public Page2PageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GoPage3Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("Page3Page");
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
