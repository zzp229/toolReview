using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool1.Models;

namespace Tool1.ViewModels.HomePage
{
    public partial class RegisterViewModel : ViewModelBase
    {
        [ObservableProperty]
        private BindingList<study> studies = new BindingList<study>();
        //private ObservableCollection<study> studies = new ObservableCollection<study>();

        private int count = 1;

        public RegisterViewModel()
        {
            initData();
        }

        // 初始化显示的数据
        [RelayCommand]
        private void initData()
        {
            studies.Clear();
            count = 1;
            studies.Add(new study()
            {
                id = 1,
                content = "",
            });
        }


        // 多加一条
        [RelayCommand]
        private void add()
        {
            studies.Add(new study()
            {
                id = ++count,
                content = "",
            });
        }


        // 保存
        [RelayCommand]
        private void save()
        {
            foreach (var study in studies)
            {
                Debug.WriteLine(study.id);
                Debug.WriteLine(study.content);
            }

        }
    }
}
