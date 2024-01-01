using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Views
{
    public interface ILoginView
    {
        //Properties

        string Username { get; set; }
        string Password { get; set; }

        string Message { get; set; }

        bool IsSuccessful { get; set; }

        //Events
        event EventHandler LoginEvent;

        //Methods

        void Show();
    }
}
