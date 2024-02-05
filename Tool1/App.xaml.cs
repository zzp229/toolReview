using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Navigation;
using Tool1.Comm;
using Tool1.ViewModels;

namespace Tool1
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

            container.AddSingleton<MainWindowViewModel>();
            container.AddSingleton<MainWindow>();   // 

            Services = container.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //这个MainWindow是自带的
            MainWindow = Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }
    }

}
