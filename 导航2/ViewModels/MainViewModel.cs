using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 导航2.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private readonly NavigationService navigator;

        [ObservableProperty]    // 这个特性的使用要继承Observable
        private ViewModelBase currentViewModel;

        public MainViewModel(NavigationService navigationService)
        {
            navigator = navigationService;
            // 主要还是这里绑定上了修改自己ViewModel的属性
            navigator.CurrentViewModelChanged += () =>
            {
                CurrentViewModel = navigationService.CurrentViewModel;  // CurrentViewModel变了就会调用这里
            };

            //navigationService.NavigateTo(new LoginViewModel());
            navigator.NavigateTo<LoginViewModel>(); // 这下就直接传泛型就行了
        }
    }
}
