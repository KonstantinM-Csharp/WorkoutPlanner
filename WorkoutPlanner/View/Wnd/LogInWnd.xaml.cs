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
using System.Windows.Shapes;
using WorkoutPlanner.ViewModel;

namespace WorkoutPlanner.View.Wnd
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWnd.xaml
    /// </summary>
    public partial class LogInWnd : Window
    {
        public LogInWnd()
        {
            InitializeComponent();
            DataContext = new LogInViewModel();
        }


        private void TxtBxPsswrd_TextChanged(object sender, TextChangedEventArgs e)
        {
            psswrdBx.Password = TxtBxPsswrd.Text;
        }

        private void ChckBxShowPsswrd_Checked(object sender, RoutedEventArgs e)
        {
            TxtBxPsswrd.Visibility = Visibility.Visible;
            psswrdBx.Visibility = Visibility.Hidden;
        }
        private void ChckBxShowPsswrd_UnChecked(object sender, RoutedEventArgs e)
        {
            TxtBxPsswrd.Visibility = Visibility.Hidden;
            psswrdBx.Visibility = Visibility.Visible;
            psswrdBx.Password = TxtBxPsswrd.Text;
        }

        private void psswrdBx_PasswordChanged(object sender, RoutedEventArgs e)
        {
            TxtBxPsswrd.Text =  psswrdBx.Password ;
        }

    }
}
