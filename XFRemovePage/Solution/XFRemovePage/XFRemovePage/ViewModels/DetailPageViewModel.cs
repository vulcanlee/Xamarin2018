using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFRemovePage.ViewModels
{
    public class DetailPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;
        public DelegateCommand GotoEditPageCommand { get; set; }
        public DetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GotoEditPageCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("EditPage", null, true);
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
