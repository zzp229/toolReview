using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 导航2.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;
        private readonly UserService userService;
        [ObservableProperty]
        string? userName;

        public HomeViewModel()
        {
            
        }

        public HomeViewModel(NavigationService navigationService, UserService userService)
        {
            this.navigationService = navigationService;
            this.userService = userService;
            UserName = userService.UserName;
        }

        [RelayCommand]
        public void test()
        {
            //navigationService.NavigateTo(new LoginViewModel());
            userService.UserName = null;
            navigationService.NavigateTo<LoginViewModel>(); // 找容器要就行了
        }
    }
}
