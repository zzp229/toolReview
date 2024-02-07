using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool1.Models
{
    // 接上接口可以通知回每一个属性
    public class study1 : INotifyPropertyChanged
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("id");
                }
            }
        }

        private string _content;
        public string content
        {
            get { return _content; }
            set
            {
                if (_content != value)
                {
                    _content = value;
                    OnPropertyChanged("content");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // 用上BindingList，属性的PropertyChanged都不用实现了
    public class study
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set 
            {
                _id = value; 
            }
        }

        private string _content;

        public string content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
