using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Tool1.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly NavigationService navigator;

        [ObservableProperty]
        private ViewModelBase currentViewModel;

        public MainWindowViewModel(NavigationService navigationService)
        {
            navigator = navigationService;

            navigator.CurrentViewModelChanged += () =>
            {
                CurrentViewModel = navigationService.CurrentViewModel;  // 让当前这个变成导航服务这个
            };

            navigator.NavigateTo<LoginViewModel>();
        }
    }
}
