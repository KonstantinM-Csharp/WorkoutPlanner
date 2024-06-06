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
using WorkoutPlanner.ViewModel.PgViewModel;

namespace WorkoutPlanner.View.Pg.Client
{
    /// <summary>
    /// Логика взаимодействия для ProfilePg.xaml
    /// </summary>
    public partial class ProfilePg : Page
    {
        public ProfilePg()
        {
            InitializeComponent();
            DataContext = new ProfileViewModel();
        }
    }
}
