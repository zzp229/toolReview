using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tool1.ViewModels;

namespace Tool1.Views
{
    /// <summary>
    /// Home.xaml 的交互逻辑
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        //DataTemplate中已经设置好DataContext了，这里再设置一遍就报错
        //public Home(HomeViewModel homeViewModel)
        //{
        //    InitializeComponent();

        //    this.DataContext = homeViewModel;
        //}
    }
}
