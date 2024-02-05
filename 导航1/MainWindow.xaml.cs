using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 导航1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        // 方案一：通过从容器中绑定DataContext
        public MainWindow(MainViewModel vm)
        {
            InitializeComponent();

            this.DataContext = vm;  // 这里使用注入的

            // DataContext由容器中获取
            //Page1.DataContext = App.Current.Services.GetRequiredService<Page1ViewModel>();
            //Page2.DataContext = App.Current.Services.GetRequiredService<Page2ViewModel>();
            //Page3.DataContext = App.Current.Services.GetRequiredService<Page3ViewModel>();
        }
    }
}