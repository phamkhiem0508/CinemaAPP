using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp._Repositories;
using CinemaApp.Views;

namespace CinemaApp.Presenters
{
    public class LoginPresenter
    {
        private ILoginView loginView;
        private IUserRepository userRepository;

        public LoginPresenter(ILoginView view, IUserRepository repository)
        {
            this.loginView = view;
            this.userRepository = repository;
            this.loginView.LoginEvent += Login;
        }

        private void Login(object sender, EventArgs e)
        {
            string username = loginView.Username;
            string password = loginView.Password;



            bool isSuccessful = userRepository.Login(username, password);

            if (isSuccessful)
            {
                loginView.IsSuccessful = true;
                loginView.Show();
            }
            else
            {
                loginView.IsSuccessful = false;
                loginView.Message = "Login Failed";
            }


        }
    }
}
