using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnMovies.Click += delegate { ShowMovieView?.Invoke(this, EventArgs.Empty); };
            btnCinemaList.Click += delegate { ShowCinemaView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowMovieView;

        public event EventHandler ShowCinemaView;

        private void btnMovies_Click(object sender, EventArgs e)
        {

        }
    }
}
