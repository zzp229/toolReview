using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using 导航2.ViewModels;
using 导航2.Views;

namespace 导航2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }

        public static new App Current => (App)Application.Current;

        public App()
        {
            var container = new ServiceCollection();

            container.AddSingleton<NavigationService>();
            container.AddSingleton<UserService>();

            container.AddTransient<LoginViewModel>();
            container.AddTransient<HomeViewModel>();
            //container.AddTransient<Home>();
            //container.AddTransient<Login>();

            container.AddSingleton<MainViewModel>();
            container.AddSingleton<MainWindow>();   // 

            

            Services = container.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }
    }

}
