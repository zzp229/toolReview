using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace 导航1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; set; }

        // 通过这个方便外面获取
        public static new App Current => (App)Application.Current;

        public App()
        {
            var container = new ServiceCollection();    // 这个需要安装DependencyInjery的NuGet

            container.AddSingleton<MainWindow>();
            container.AddSingleton<MainViewModel>();

            container.AddScoped<Page1ViewModel>();
            container.AddScoped<Page2ViewModel>();
            container.AddScoped<Page3ViewModel>();

            Services = container.BuildServiceProvider();
        }

        // 这个重写了Startup，要删除App.xaml中的StartUrl
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = Services.GetRequiredService<MainWindow>();
            MainWindow.Show();

            //MainWindow = new MainWindow(new MainViewModel());
            //MainWindow.Show();

        }
    }

}
