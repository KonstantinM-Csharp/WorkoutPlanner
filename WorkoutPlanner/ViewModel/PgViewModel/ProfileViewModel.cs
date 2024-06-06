using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorkoutPlanner.Services;
using WorkoutPlanner.ViewModel.Commands;

namespace WorkoutPlanner.ViewModel.PgViewModel
{
    class ProfileViewModel: WorkoutPlanner.ViewModel.Base.ViewModel
    {
        public string FirstName { get => UserManager.CurrentUser; }
        public string Patronymic { get => UserManager.CurrentUser; }
        public string LastName { get => UserManager.CurrentUser; }
        public string Birthday { get => UserManager.CurrentUser; }
        public string Photo { get => UserManager.CurrentUser; }
        public string Weight { get => UserManager.CurrentUser; set => UserManager.CurrentUser = value; }
        public string Height { get => UserManager.CurrentUser; set => UserManager.CurrentUser = value; }

        public ICommand Save { get; set; }
        public ProfileViewModel()
        {
            Save = new RelayCommand(SaveData);
        }
        public void SaveData(object parameter)
        {

        }
    }
}
