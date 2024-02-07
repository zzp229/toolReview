using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool1.Models;

namespace Tool1.ViewModels.HomePage
{
    public partial class RegisterViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<study> studies = new ObservableCollection<study>();

        public RegisterViewModel()
        {
            initData();
        }

        // 初始化显示的数据
        [RelayCommand]
        private void initData()
        {
            studies.Clear();
            studies.Add(new study()
            {
                id = 1,
                content = "可以就可以",
            });
        }


        // 多加一条
        [RelayCommand]
        private void add()
        {
            studies.Add(new study()
            {
                id = 1,
                content = "可以就可以",
            });
        }

    }
}
