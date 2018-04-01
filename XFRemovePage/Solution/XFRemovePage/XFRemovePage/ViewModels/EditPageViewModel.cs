using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFRemovePage.ViewModels
{
    public class EditPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;
        public DelegateCommand GoBackPageCommand { get; set; }
        public EditPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GoBackPageCommand = new DelegateCommand(async () =>
            {
                var fooPage = App.Current.MainPage;
                var fooNavigationStack = fooPage.Navigation.NavigationStack;
                var fooModalStack = fooPage.Navigation.ModalStack;
                var fooRemovePageNode = fooNavigationStack[fooNavigationStack.Count - 1];
                fooPage.Navigation.RemovePage(fooRemovePageNode);

                await _navigationService.GoBackAsync() ;
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
