using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 导航2.ViewModels
{
    public class ViewModelBase : ObservableObject
    {
        public void RaisePropertyChanged(string propertyName)
        {
            if (propertyName != null)
            {
                this.RaisePropertyChanged(propertyName);
            }
        }
    }
}
