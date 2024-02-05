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
using 导航2.ViewModels;

namespace 导航2.Views
{
    /// <summary>
    /// Home.xaml 的交互逻辑
    /// </summary>
    public partial class Home : UserControl
    {
        //private readonly HomeViewModel homeViewModel;
        public Home()   //这个时候都不用指定DataContext，看看为什么先
        {
            InitializeComponent();
        }

        //public Home(HomeViewModel homeViewModel)
        //{
        //    InitializeComponent();

        //    this.DataContext = homeViewModel;
        //}
    }
}
