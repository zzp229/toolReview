using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Tool1.Comm;

namespace Tool1.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;
        private readonly UserService userService;
        [ObservableProperty]
        private string userName;

        public LoginViewModel(NavigationService navigationService, UserService userService)
        {
            this.navigationService = navigationService;
            this.userService = userService;
        }

        [RelayCommand]
        public void Login()
        {
            userService.UserName = UserName;
            navigationService.NavigateTo<HomeViewModel>();
        }
    }
}
