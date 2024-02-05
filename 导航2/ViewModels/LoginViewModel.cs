using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 导航2.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        private readonly NavigationService _navigationService;
        private readonly UserService userService;
        [ObservableProperty]
        string? userName = "Sean";

        public LoginViewModel(NavigationService navigationService, UserService userService)
        {
            _navigationService = navigationService;
            this.userService = userService;
        }


        [RelayCommand]
        void Login()
        {
            //navigationService.NavigateTo(new HomeViewModel()); // 这个时候就是调用导航去这个界面
            userService.UserName = UserName;
            _navigationService.NavigateTo<HomeViewModel>();
        }
    }
}
