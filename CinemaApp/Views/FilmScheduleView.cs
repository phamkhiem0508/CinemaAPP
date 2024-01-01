using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaApp._Repositories;
using CinemaApp.Data;
using CinemaApp.Models;
using CinemaApp.Presenters.Utilities;

namespace CinemaApp.Views
{
    public partial class FilmScheduleView : Form, IFilmScheduleView
    {
        private static FilmScheduleView instance;
        private int id;
        private bool isEdit = false;
        private string message = "";

        public FilmScheduleView(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            tabFilmScheduleControl.TabPages.Remove(tabFilmScheduleDetail);
            btnClose.Click += delegate { this.Close(); };

            IEnumerable<MovieModel> movies = new MovieRepository(new CinemaAppContext()).GetAllMovies();

            PrepareAndRaiseEvent();



        }

        public event EventHandler AddFilmScheduleEvent;
        public event EventHandler EditFilmScheduleEvent;
        public event EventHandler LoadFilmScheduleEvent;
        public event EventHandler UpdateFilmScheduleEvent;
        public event EventHandler DeleteFilmScheduleEvent;
        public event EventHandler SearchFilmScheduleEvent;
        public event EventHandler SaveFilmScheduleEvent;
        public event EventHandler CloseFormEvent;


        private void PrepareAndRaiseEvent()
        {
            btnSearchFilmSchedule.Click += delegate { SearchFilmScheduleEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchMovie.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchFilmScheduleEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            //Add movie
            btnAddNewFilmSchedule.Click += delegate
            {
                this.IsEdit = false;
                AddFilmScheduleEvent?.Invoke(this, EventArgs.Empty);
                tabFilmScheduleControl.TabPages.Remove(tabFilmScheduleList);
                tabFilmScheduleControl.TabPages.Add(tabFilmScheduleDetail);
                tabFilmScheduleControl.SelectedTab = tabFilmScheduleDetail;
                tabFilmScheduleDetail.Text = "Add Film Schedule";
            };



            //Save movie
            btnSaveFilmSchedule.Click += delegate
            {
                SaveFilmScheduleEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(this.Message, "Add Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            //Edit movie
            btnEditFilmSchedule.Click += delegate
            {
                this.IsEdit = true;
                tabFilmScheduleControl.TabPages.Remove(tabFilmScheduleList);
                tabFilmScheduleControl.TabPages.Add(tabFilmScheduleDetail);
                tabFilmScheduleControl.SelectedTab = tabFilmScheduleDetail;
                tabFilmScheduleDetail.Text = "Edit Movie";
                EditFilmScheduleEvent?.Invoke(this, EventArgs.Empty);
            };

            //Close movie detail
            btnCloseFilmScheduleDetail.Click += delegate
            {
                this.IsEdit = false;
                CloseFormEvent?.Invoke(this, EventArgs.Empty);
                tabFilmScheduleControl.TabPages.Remove(tabFilmScheduleDetail);
                tabFilmScheduleControl.TabPages.Add(tabFilmScheduleList);
                tabFilmScheduleControl.SelectedTab = tabFilmScheduleList;
                tabFilmScheduleList.Text = "Film Schedule List";
            };

            //};

            //Delete movie
            btnDeleteFilmSchedule.Click += delegate
            {
                var result = MessageBox.Show("Do you want to delete?", "Delete Movie", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //var result = MessageBox.Show(this.message, "Delete Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    DeleteFilmScheduleEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(this.message, "Delete Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }
        public string Date { get => txtFilmScheduleDate.Text; set => txtFilmScheduleDate.Text = value; }
        public string Room { get => cbRoom.Text; set => cbRoom.Text = value; }
        public string Message { get => this.message; set => this.message = value; }
        public bool IsEdit { get => this.isEdit; set => this.isEdit = value; }
        public string Movie { get => this?.cbMovie?.SelectedValue?.ToString(); set => this.cbMovie.SelectedValue = value; }
        public string StartTime { get => txtFilmScheduleStartime.Text; set => txtFilmScheduleStartime.Text = value; }
        public string EndTime { get; set; }
        public int Id { get => this.id; set => this.id = value; }
        public string SearchFilmScheduleValue { get => this.txtSearchMovie.Text; set => this.txtSearchMovie.Text = value; }

        public void SetMovieComboBox(IEnumerable<MovieModel> movies)
        {
            cbMovie.DataSource = null;

            cbMovie.Items.Clear();
            cbMovie.DisplayMember = "Text";
            cbMovie.ValueMember = "Value";
            BindingList<ComboBoxItem> list = new BindingList<ComboBoxItem>();


            foreach (var movie in movies)
            {
                list.Add(new ComboBoxItem(movie.Title.ToString(), movie.Id.ToString()));
            }

            //Add range of data to combobox
            cbMovie.DataSource = list;
        }

        public void SetMovieListBindingSource(BindingSource movieList)
        {
            dataGridView1.DataSource = movieList;
        }

        public static FilmScheduleView GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FilmScheduleView(parent);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void IFilmScheduleView.DisplayForm()
        {
            this.Show();
        }
    }
}
