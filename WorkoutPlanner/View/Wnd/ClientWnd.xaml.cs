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
using WorkoutPlanner.View.Pg.Client;

namespace WorkoutPlanner.View.Wnd
{
    /// <summary>
    /// Логика взаимодействия для MainWnd.xaml
    /// </summary>
    public partial class ClientWnd : Window
    {
        public ClientWnd()
        {
            InitializeComponent();
            TrainerFrm.Navigate(new ProfilePg());
        }
    }
}
