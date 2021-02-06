using System.Collections.ObjectModel;
using System.Windows;
using WpfApp3.Model;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Service> Services = new ObservableCollection<Service>()
            {
                new Service {Title = "Яблоко", Price = 15.4, Time = "13:00", Photo = "/Resources/4.jpg" },
                new Service {Title = "Апельсин", Price = 10, Time = "03:00", Photo = "/Resources/5.jpg" },
                new Service {Title = "Арбуз", Price = 15.4, Time = "13:00", Photo = "/Resources/7.jpg" },
                new Service {Title = "Киви", Price = 15.4, Time = "13:00", Photo = "/Resources/6.jpg" },

            };

            listDataView.ItemsSource = Services;
        }
    }
}
