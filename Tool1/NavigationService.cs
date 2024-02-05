using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool1.ViewModels;

namespace Tool1
{
    public class NavigationService
    {
        private ViewModelBase? currentViewModel;

        public ViewModelBase? CurrentViewModel
        {
            get { return currentViewModel; }
            set 
            { 
                currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }

        // 属性一旦改变就调用这个事件，这个事件给MainVM订阅，更换它的VM
        public event Action? CurrentViewModelChanged;

        public void NavigateTo<T>() where T : ViewModelBase
            => CurrentViewModel = App.Current.Services.GetService<T>();
    }
}
