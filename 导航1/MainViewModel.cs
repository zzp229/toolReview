using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 导航1
{
    public class MainViewModel : ViewModelBase
    {
        public List<ViewModelBase> ViewModels { get; set; }

        public MainViewModel(Page1ViewModel p1, Page2ViewModel p2, Page3ViewModel p3)
        {
            ViewModels = new List<ViewModelBase> { p1, p2, p3 };
        }
    }
}
