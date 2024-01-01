namespace CinemaApp.Views
{
    partial class MovieView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbMovie = new Label();
            panel1 = new Panel();
            tabMovieControl = new TabControl();
            tabMovieList = new TabPage();
            btnDeleteMovie = new Button();
            btnEditMovie = new Button();
            btnAddNewMovie = new Button();
            dataGridView1 = new DataGridView();
            btnSearchMovie = new Button();
            txtSearchMovie = new TextBox();
            lbSearchMovie = new Label();
            tabMovieDetail = new TabPage();
            cbGenre = new ComboBox();
            btnCloseMovie = new Button();
            lbMovieGenre = new Label();
            btnSaveMovie = new Button();
            txtReleasedDate = new MaskedTextBox();
            label4 = new Label();
            txtMovieDuration = new MaskedTextBox();
            label3 = new Label();
            txtMovieDesciption = new TextBox();
            label2 = new Label();
            txtMovieTitle = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            tabMovieControl.SuspendLayout();
            tabMovieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabMovieDetail.SuspendLayout();
            SuspendLayout();
            // 
            // lbMovie
            // 
            lbMovie.AutoSize = true;
            lbMovie.Location = new Point(12, 13);
            lbMovie.Name = "lbMovie";
            lbMovie.Size = new Size(45, 15);
            lbMovie.TabIndex = 0;
            lbMovie.Text = "Movies";
            lbMovie.Click += lbMovie_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbMovie);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 1;
            // 
            // tabMovieControl
            // 
            tabMovieControl.Controls.Add(tabMovieList);
            tabMovieControl.Controls.Add(tabMovieDetail);
            tabMovieControl.Dock = DockStyle.Fill;
            tabMovieControl.Location = new Point(0, 42);
            tabMovieControl.Name = "tabMovieControl";
            tabMovieControl.SelectedIndex = 0;
            tabMovieControl.Size = new Size(800, 408);
            tabMovieControl.TabIndex = 2;
            // 
            // tabMovieList
            // 
            tabMovieList.Controls.Add(btnDeleteMovie);
            tabMovieList.Controls.Add(btnEditMovie);
            tabMovieList.Controls.Add(btnAddNewMovie);
            tabMovieList.Controls.Add(dataGridView1);
            tabMovieList.Controls.Add(btnSearchMovie);
            tabMovieList.Controls.Add(txtSearchMovie);
            tabMovieList.Controls.Add(lbSearchMovie);
            tabMovieList.Location = new Point(4, 24);
            tabMovieList.Name = "tabMovieList";
            tabMovieList.Padding = new Padding(3);
            tabMovieList.Size = new Size(792, 380);
            tabMovieList.TabIndex = 0;
            tabMovieList.Text = "MovieList";
            tabMovieList.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Location = new Point(697, 179);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(75, 23);
            btnDeleteMovie.TabIndex = 9;
            btnDeleteMovie.Text = "Delete";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btnEditMovie
            // 
            btnEditMovie.Location = new Point(697, 124);
            btnEditMovie.Name = "btnEditMovie";
            btnEditMovie.Size = new Size(75, 23);
            btnEditMovie.TabIndex = 10;
            btnEditMovie.Text = "Edit";
            btnEditMovie.UseVisualStyleBackColor = true;
            // 
            // btnAddNewMovie
            // 
            btnAddNewMovie.Location = new Point(697, 77);
            btnAddNewMovie.Name = "btnAddNewMovie";
            btnAddNewMovie.Size = new Size(75, 23);
            btnAddNewMovie.TabIndex = 11;
            btnAddNewMovie.Text = "Add new";
            btnAddNewMovie.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(646, 292);
            dataGridView1.TabIndex = 8;
            // 
            // btnSearchMovie
            // 
            btnSearchMovie.Location = new Point(592, 30);
            btnSearchMovie.Name = "btnSearchMovie";
            btnSearchMovie.Size = new Size(75, 23);
            btnSearchMovie.TabIndex = 7;
            btnSearchMovie.Text = "Search";
            btnSearchMovie.UseVisualStyleBackColor = true;
            // 
            // txtSearchMovie
            // 
            txtSearchMovie.Location = new Point(21, 30);
            txtSearchMovie.Name = "txtSearchMovie";
            txtSearchMovie.Size = new Size(565, 23);
            txtSearchMovie.TabIndex = 6;
            // 
            // lbSearchMovie
            // 
            lbSearchMovie.AutoSize = true;
            lbSearchMovie.Location = new Point(21, 12);
            lbSearchMovie.Name = "lbSearchMovie";
            lbSearchMovie.Size = new Size(81, 15);
            lbSearchMovie.TabIndex = 5;
            lbSearchMovie.Text = "Search Movie:";
            // 
            // tabMovieDetail
            // 
            tabMovieDetail.Controls.Add(cbGenre);
            tabMovieDetail.Controls.Add(btnCloseMovie);
            tabMovieDetail.Controls.Add(lbMovieGenre);
            tabMovieDetail.Controls.Add(btnSaveMovie);
            tabMovieDetail.Controls.Add(txtReleasedDate);
            tabMovieDetail.Controls.Add(label4);
            tabMovieDetail.Controls.Add(txtMovieDuration);
            tabMovieDetail.Controls.Add(label3);
            tabMovieDetail.Controls.Add(txtMovieDesciption);
            tabMovieDetail.Controls.Add(label2);
            tabMovieDetail.Controls.Add(txtMovieTitle);
            tabMovieDetail.Controls.Add(label1);
            tabMovieDetail.Location = new Point(4, 24);
            tabMovieDetail.Name = "tabMovieDetail";
            tabMovieDetail.Padding = new Padding(3);
            tabMovieDetail.Size = new Size(792, 380);
            tabMovieDetail.TabIndex = 1;
            tabMovieDetail.Text = "MovieDetail";
            tabMovieDetail.UseVisualStyleBackColor = true;
            tabMovieDetail.Click += tabPage2_Click;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Items.AddRange(new object[] { "Action", "Kid", "Comedy", "Romance", "Drama", "Adventure" });
            cbGenre.Location = new Point(156, 165);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(161, 23);
            cbGenre.TabIndex = 12;
            // 
            // btnCloseMovie
            // 
            btnCloseMovie.Location = new Point(263, 328);
            btnCloseMovie.Name = "btnCloseMovie";
            btnCloseMovie.Size = new Size(75, 23);
            btnCloseMovie.TabIndex = 11;
            btnCloseMovie.Text = "Close";
            btnCloseMovie.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCloseMovie.UseVisualStyleBackColor = true;
            // 
            // lbMovieGenre
            // 
            lbMovieGenre.AutoSize = true;
            lbMovieGenre.Location = new Point(31, 168);
            lbMovieGenre.Name = "lbMovieGenre";
            lbMovieGenre.Size = new Size(38, 15);
            lbMovieGenre.TabIndex = 9;
            lbMovieGenre.Text = "Genre";
            // 
            // btnSaveMovie
            // 
            btnSaveMovie.Location = new Point(156, 328);
            btnSaveMovie.Name = "btnSaveMovie";
            btnSaveMovie.Size = new Size(75, 23);
            btnSaveMovie.TabIndex = 8;
            btnSaveMovie.Text = "Save";
            btnSaveMovie.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSaveMovie.UseVisualStyleBackColor = true;
            // 
            // txtReleasedDate
            // 
            txtReleasedDate.Location = new Point(156, 254);
            txtReleasedDate.Mask = "00/00/0000";
            txtReleasedDate.Name = "txtReleasedDate";
            txtReleasedDate.Size = new Size(274, 23);
            txtReleasedDate.TabIndex = 7;
            txtReleasedDate.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 262);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 6;
            label4.Text = "Movie Released Date";
            // 
            // txtMovieDuration
            // 
            txtMovieDuration.Location = new Point(156, 204);
            txtMovieDuration.Mask = "90:00";
            txtMovieDuration.Name = "txtMovieDuration";
            txtMovieDuration.Size = new Size(274, 23);
            txtMovieDuration.TabIndex = 5;
            txtMovieDuration.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 212);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Movie Duration";
            // 
            // txtMovieDesciption
            // 
            txtMovieDesciption.Location = new Point(156, 101);
            txtMovieDesciption.Name = "txtMovieDesciption";
            txtMovieDesciption.Size = new Size(274, 23);
            txtMovieDesciption.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 104);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Movie Description";
            // 
            // txtMovieTitle
            // 
            txtMovieTitle.Location = new Point(156, 43);
            txtMovieTitle.Name = "txtMovieTitle";
            txtMovieTitle.Size = new Size(274, 23);
            txtMovieTitle.TabIndex = 1;
            txtMovieTitle.TextChanged += txtMovieTtitle_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 51);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Movie Title";
            // 
            // MovieView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabMovieControl);
            Controls.Add(panel1);
            Name = "MovieView";
            Text = "MovieView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabMovieControl.ResumeLayout(false);
            tabMovieList.ResumeLayout(false);
            tabMovieList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabMovieDetail.ResumeLayout(false);
            tabMovieDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbMovie;
        private Panel panel1;
        private TabControl tabMovieControl;
        private TabPage tabMovieList;
        private TabPage tabMovieDetail;
        private Button btnDeleteMovie;
        private Button btnEditMovie;
        private Button btnAddNewMovie;
        private DataGridView dataGridView1;
        private Button btnSearchMovie;
        private TextBox txtSearchMovie;
        private Label lbSearchMovie;
        private TextBox txtMovieTitle;
        private Label label1;
        private TextBox txtMovieDesciption;
        private Label label2;
        private Label label3;
        private MaskedTextBox txtReleasedDate;
        private Label label4;
        private MaskedTextBox txtMovieDuration;
        private Button btnSaveMovie;
        private Label lbMovieGenre;
        private Button btnCloseMovie;
        private ComboBox cbGenre;
    }
}