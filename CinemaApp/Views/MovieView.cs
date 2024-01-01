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
    public partial class MovieView : Form, IMovieView
    {
        //Fields
        private int movieId;
        private bool isEdit = false;
        private bool isSuccessful = false;
        private string message = "";

        //Constructor
        public MovieView()
        {
            InitializeComponent();
            PrepareAndRaiseEvent();
            tabMovieControl.TabPages.Remove(tabMovieDetail);
            btnClose.Click += delegate { this.Close(); };
            cbGenre.SelectedIndex = 0;
        }

        private void PrepareAndRaiseEvent()
        {
            btnSearchMovie.Click += delegate { SearchMovieEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchMovie.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchMovieEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            //Add movie
            btnAddNewMovie.Click += delegate
            {
                this.IsEdit = false;
                AddMovieEvent?.Invoke(this, EventArgs.Empty);
                tabMovieControl.TabPages.Remove(tabMovieList);
                tabMovieControl.TabPages.Add(tabMovieDetail);
                tabMovieControl.SelectedTab = tabMovieDetail;
                tabMovieDetail.Text = "Add Movie";

            };



            //Save movie
            btnSaveMovie.Click += delegate
            {
                SaveMovieEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(this.message, "Add Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            //Edit movie
            btnEditMovie.Click += delegate
            {
                this.IsEdit = true;
                tabMovieControl.TabPages.Remove(tabMovieList);
                tabMovieControl.TabPages.Add(tabMovieDetail);
                tabMovieControl.SelectedTab = tabMovieDetail;
                tabMovieDetail.Text = "Edit Movie";
                EditMovieEvent?.Invoke(this, EventArgs.Empty);
                CancelSaveMovieEvent?.Invoke(this, EventArgs.Empty);
            };

            //Close movie detail
            btnCloseMovie.Click += delegate
            {
                this.IsEdit = false;
                CancelSaveMovieEvent?.Invoke(this, EventArgs.Empty);
                tabMovieControl.TabPages.Remove(tabMovieDetail);
                tabMovieControl.TabPages.Add(tabMovieList);
                tabMovieControl.SelectedTab = tabMovieList;
                tabMovieList.Text = "Movie List";


            };

            //Delete movie
            btnDeleteMovie.Click += delegate
            {
                var result = MessageBox.Show("Do you want to delete?", "Delete Movie", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //var result = MessageBox.Show(this.message, "Delete Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    DeleteMovieEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(this.message, "Delete Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        public string MovieTitle { get => txtMovieTitle.Text; set => txtMovieTitle.Text = value; }
        public string MovieDescription { get => txtMovieDesciption.Text; set => txtMovieDesciption.Text = value; }
        public string MovieDuration { get => txtMovieDuration.Text; set => txtMovieDuration.Text = value; }
        public string MovieReleaseDate { get => txtReleasedDate.Text; set => txtReleasedDate.Text = value; }
        public string SearchMovieValue { get => txtSearchMovie.Text; set => txtSearchMovie.Text = value; }
        public string MovieImage { get => ""; set { } }
        public string MovieGenre { get => cbGenre.SelectedItem.ToString(); set => cbGenre.SelectedItem = value; }
        public string Message { get => this.message; set => message = value; }
        public bool IsSuccessful { get => this.isSuccessful; set => isSuccessful = value; }
        public bool IsEdit { get => this.isEdit; set => isEdit = value; }
        public int MovieId { get => this.movieId; set => this.movieId = value; }


        //Events
        public event EventHandler AddMovieEvent;
        public event EventHandler DeleteMovieEvent;
        public event EventHandler UpdateMovieEvent;
        public event EventHandler GetAllMoviesEvent;
        public event EventHandler SearchMovieEvent;
        public event EventHandler SaveMovieEvent;
        public event EventHandler CancelSaveMovieEvent;
        public event EventHandler EditMovieEvent;


        private void lbMovie_Click(object sender, EventArgs e)
        {

        }

        private void lbSearchMovie_Click(object sender, EventArgs e)
        {

        }

        private void txtMovieTtitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        //Methods
        void IMovieView.SetMovieListBindingSource(BindingSource movieList)
        {
            dataGridView1.DataSource = movieList;
            //throw new NotImplementedException();
        }

        void IMovieView.Show()
        {
            this.Show();
            //throw new NotImplementedException();
        }

        //Singleton pattern
        private static MovieView instance = null;

        public static MovieView GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MovieView();
                instance.MdiParent = parent;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
            }
            instance.BringToFront();
            return instance;
        }
    }
}
