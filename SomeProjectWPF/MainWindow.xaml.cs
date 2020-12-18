using SomeProjectWPF.Classes;
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

namespace SomeProjectWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class 
        MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            var user = classConnect.db.SignIn.FirstOrDefault(item => item.Username == txtLogin.Text && item.Password == txtPassword.Text);

            if (user != null)
            {
                switch (user.IDRole)
                {
                    case "A":
                        MessageBox.Show("privey") ;
                        break;
                }


                
               
            }

            
        }

        private void btnButton2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
