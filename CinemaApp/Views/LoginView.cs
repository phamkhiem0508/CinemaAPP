using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaApp.Presenters;

namespace CinemaApp.Views
{
    public partial class LoginView : Form, ILoginView
    {
        private bool isSuccessful = false;
        private string message = "";
        public string Username { get => txtUserName.Text; set => txtUserName.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string Message { get => this.message; set => this.message = value; }
        public bool IsSuccessful { get => this.isSuccessful; set => this.isSuccessful = value; }

        public event EventHandler LoginEvent;

        public void Show()
        {
            this.Hide();
            var mainView = new MainView();
            new MainPresenter(mainView);
            mainView.ShowDialog();
        }

        public LoginView()
        {
            InitializeComponent();
            btnLogin.Click += delegate
            {
                LoginEvent?.Invoke(this, EventArgs.Empty);
                if (!isSuccessful)
                {
                    MessageBox.Show(message);
                }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

