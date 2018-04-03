using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFDI.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        private readonly INavigationService _navigationService;
        ISayHello _SayHello;
        public MainPageViewModel(INavigationService navigationService,
            ISayHello sayHello)
        {
            _navigationService = navigationService;
            _SayHello = sayHello;

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Title = _SayHello.Hello();
        }

    }
}
