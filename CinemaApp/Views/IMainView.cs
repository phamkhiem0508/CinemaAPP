using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Views
{
    public interface IMainView
    {
        public event EventHandler ShowMovieView;
        public event EventHandler ShowCinemaView;
        
    }
}
