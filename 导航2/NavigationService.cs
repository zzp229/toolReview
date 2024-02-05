using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 导航2.ViewModels;

namespace 导航2
{
    public class NavigationService
    {
        // 原本是有的后面改到App.xaml.cs中了
        //public static NavigationService Instance { get; } = new NavigationService();
        //private NavigationService() { }
       
        private ViewModelBase? currentViewModel;    

        public ViewModelBase? CurrentViewModel
        {
            get { return currentViewModel; }
            set 
            { 
                currentViewModel = value;
                //RaisePropertyChanged(nameof(CurrentViewModel)); // 通知View更改
                CurrentViewModelChanged?.Invoke();  // 触发事件
            }
        }

        public event Action? CurrentViewModelChanged;

        // 这个方法会改变CurrentViewModel，从而激活CurrentViewModelChanged绑定的方法
        //public void NavigateTo(ViewModelBase viewModel) => CurrentViewModel = viewModel;

        public void NavigateTo<T>() where T : ViewModelBase
            => CurrentViewModel = App.Current.Services.GetService<T>();
    }
}
