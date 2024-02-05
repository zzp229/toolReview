using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 导航1 
{
    //这个牛，前端就只要绑定上这里文件名（ViewModels）就能有跳转的页面了
    public class Page1ViewModel : ViewModelBase
    {
        public string Header { get; set; } = "Page 1";
        public string PageMessage { get; set; } = "Hello, Page 1";
        public Page1ViewModel()
        {
            
        }
    }

    public class Page2ViewModel : ViewModelBase
    {
        public string Header { get; set; } = "Page 2";
        public string PageMessage { get; set; } = "Hello, Page 2";
        public Page2ViewModel()
        {

        }
    }

    public class Page3ViewModel : ViewModelBase
    {
        public string Header { get; set; } = "Page 3";
        public string PageMessage { get; set; } = "Hello, Page 3";
        public Page3ViewModel()
        {

        }
    }
}
