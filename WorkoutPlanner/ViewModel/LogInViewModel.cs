using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorkoutPlanner.Services;
using WorkoutPlanner.View.Wnd;
using WorkoutPlanner.ViewModel.Commands;

namespace WorkoutPlanner.ViewModel
{
    class LogInViewModel : WorkoutPlanner.ViewModel.Base.ViewModel
    {
        private string _login;
        private string _password;
        private string _message;
        public string Login {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public string Message { 
            get 
            {
                return _message;
            } 
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; set; }
       
        public LogInViewModel()
        {
            LoginCommand = new RelayCommand(LoginUser);
        }
        public void LoginUser(object parameter)
        {
            if (UserManager.Login(Login, Password))
            {
                Message = $"Добро пожаловать {UserManager.CurrentUser}";
                ClientWnd client = new ClientWnd();
                client.Show();
            }
            else
                Message = "Проверьте учетные данные и повторите попытку";
        }
    }
}
