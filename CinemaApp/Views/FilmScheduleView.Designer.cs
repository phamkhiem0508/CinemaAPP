namespace CinemaApp.Views
{
    partial class FilmScheduleView
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
            cbMovie = new ComboBox();
            btnCloseFilmScheduleDetail = new Button();
            lbMovieGenre = new Label();
            btnSaveFilmSchedule = new Button();
            txtFilmScheduleDate = new MaskedTextBox();
            label4 = new Label();
            txtFilmScheduleStartime = new MaskedTextBox();
            label3 = new Label();
            tabFilmScheduleList = new TabPage();
            btnDeleteFilmSchedule = new Button();
            btnEditFilmSchedule = new Button();
            btnAddNewFilmSchedule = new Button();
            dataGridView1 = new DataGridView();
            btnSearchFilmSchedule = new Button();
            txtSearchMovie = new TextBox();
            lbSearchMovie = new Label();
            tabFilmScheduleControl = new TabControl();
            tabFilmScheduleDetail = new TabPage();
            cbRoom = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            lbMovie = new Label();
            tabFilmScheduleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabFilmScheduleControl.SuspendLayout();
            tabFilmScheduleDetail.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbMovie
            // 
            cbMovie.FormattingEnabled = true;
            cbMovie.Items.AddRange(new object[] { "Action", "Kid" });
            cbMovie.Location = new Point(149, 77);
            cbMovie.Name = "cbMovie";
            cbMovie.Size = new Size(161, 23);
            cbMovie.TabIndex = 12;
            // 
            // btnCloseFilmScheduleDetail
            // 
            btnCloseFilmScheduleDetail.Location = new Point(256, 240);
            btnCloseFilmScheduleDetail.Name = "btnCloseFilmScheduleDetail";
            btnCloseFilmScheduleDetail.Size = new Size(75, 23);
            btnCloseFilmScheduleDetail.TabIndex = 11;
            btnCloseFilmScheduleDetail.Text = "Close";
            btnCloseFilmScheduleDetail.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCloseFilmScheduleDetail.UseVisualStyleBackColor = true;
            // 
            // lbMovieGenre
            // 
            lbMovieGenre.AutoSize = true;
            lbMovieGenre.Location = new Point(27, 83);
            lbMovieGenre.Name = "lbMovieGenre";
            lbMovieGenre.Size = new Size(40, 15);
            lbMovieGenre.TabIndex = 9;
            lbMovieGenre.Text = "Movie";
            // 
            // btnSaveFilmSchedule
            // 
            btnSaveFilmSchedule.Location = new Point(149, 240);
            btnSaveFilmSchedule.Name = "btnSaveFilmSchedule";
            btnSaveFilmSchedule.Size = new Size(75, 23);
            btnSaveFilmSchedule.TabIndex = 8;
            btnSaveFilmSchedule.Text = "Save";
            btnSaveFilmSchedule.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSaveFilmSchedule.UseVisualStyleBackColor = true;
            // 
            // txtFilmScheduleDate
            // 
            txtFilmScheduleDate.Location = new Point(149, 166);
            txtFilmScheduleDate.Mask = "00/00/0000";
            txtFilmScheduleDate.Name = "txtFilmScheduleDate";
            txtFilmScheduleDate.Size = new Size(274, 23);
            txtFilmScheduleDate.TabIndex = 7;
            txtFilmScheduleDate.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 177);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Date";
            label4.Click += label4_Click;
            // 
            // txtFilmScheduleStartime
            // 
            txtFilmScheduleStartime.Location = new Point(149, 116);
            txtFilmScheduleStartime.Mask = "90:00";
            txtFilmScheduleStartime.Name = "txtFilmScheduleStartime";
            txtFilmScheduleStartime.Size = new Size(274, 23);
            txtFilmScheduleStartime.TabIndex = 5;
            txtFilmScheduleStartime.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 127);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Start Time";
            // 
            // tabFilmScheduleList
            // 
            tabFilmScheduleList.Controls.Add(btnDeleteFilmSchedule);
            tabFilmScheduleList.Controls.Add(btnEditFilmSchedule);
            tabFilmScheduleList.Controls.Add(btnAddNewFilmSchedule);
            tabFilmScheduleList.Controls.Add(dataGridView1);
            tabFilmScheduleList.Controls.Add(btnSearchFilmSchedule);
            tabFilmScheduleList.Controls.Add(txtSearchMovie);
            tabFilmScheduleList.Controls.Add(lbSearchMovie);
            tabFilmScheduleList.Location = new Point(4, 24);
            tabFilmScheduleList.Name = "tabFilmScheduleList";
            tabFilmScheduleList.Padding = new Padding(3);
            tabFilmScheduleList.Size = new Size(792, 380);
            tabFilmScheduleList.TabIndex = 0;
            tabFilmScheduleList.Text = "FilmScheduleList";
            tabFilmScheduleList.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFilmSchedule
            // 
            btnDeleteFilmSchedule.Location = new Point(697, 179);
            btnDeleteFilmSchedule.Name = "btnDeleteFilmSchedule";
            btnDeleteFilmSchedule.Size = new Size(75, 23);
            btnDeleteFilmSchedule.TabIndex = 9;
            btnDeleteFilmSchedule.Text = "Delete";
            btnDeleteFilmSchedule.UseVisualStyleBackColor = true;
            // 
            // btnEditFilmSchedule
            // 
            btnEditFilmSchedule.Location = new Point(697, 124);
            btnEditFilmSchedule.Name = "btnEditFilmSchedule";
            btnEditFilmSchedule.Size = new Size(75, 23);
            btnEditFilmSchedule.TabIndex = 10;
            btnEditFilmSchedule.Text = "Edit";
            btnEditFilmSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddNewFilmSchedule
            // 
            btnAddNewFilmSchedule.Location = new Point(697, 77);
            btnAddNewFilmSchedule.Name = "btnAddNewFilmSchedule";
            btnAddNewFilmSchedule.Size = new Size(75, 23);
            btnAddNewFilmSchedule.TabIndex = 11;
            btnAddNewFilmSchedule.Text = "Add new";
            btnAddNewFilmSchedule.UseVisualStyleBackColor = true;
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
            // btnSearchFilmSchedule
            // 
            btnSearchFilmSchedule.Location = new Point(592, 30);
            btnSearchFilmSchedule.Name = "btnSearchFilmSchedule";
            btnSearchFilmSchedule.Size = new Size(75, 23);
            btnSearchFilmSchedule.TabIndex = 7;
            btnSearchFilmSchedule.Text = "Search";
            btnSearchFilmSchedule.UseVisualStyleBackColor = true;
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
            lbSearchMovie.Location = new Point(24, 15);
            lbSearchMovie.Name = "lbSearchMovie";
            lbSearchMovie.Size = new Size(122, 15);
            lbSearchMovie.TabIndex = 5;
            lbSearchMovie.Text = "Search Film Schedule:";
            // 
            // tabFilmScheduleControl
            // 
            tabFilmScheduleControl.Controls.Add(tabFilmScheduleList);
            tabFilmScheduleControl.Controls.Add(tabFilmScheduleDetail);
            tabFilmScheduleControl.Dock = DockStyle.Fill;
            tabFilmScheduleControl.Location = new Point(0, 42);
            tabFilmScheduleControl.Name = "tabFilmScheduleControl";
            tabFilmScheduleControl.SelectedIndex = 0;
            tabFilmScheduleControl.Size = new Size(800, 408);
            tabFilmScheduleControl.TabIndex = 4;
            // 
            // tabFilmScheduleDetail
            // 
            tabFilmScheduleDetail.Controls.Add(cbRoom);
            tabFilmScheduleDetail.Controls.Add(label2);
            tabFilmScheduleDetail.Controls.Add(cbMovie);
            tabFilmScheduleDetail.Controls.Add(btnCloseFilmScheduleDetail);
            tabFilmScheduleDetail.Controls.Add(lbMovieGenre);
            tabFilmScheduleDetail.Controls.Add(btnSaveFilmSchedule);
            tabFilmScheduleDetail.Controls.Add(txtFilmScheduleDate);
            tabFilmScheduleDetail.Controls.Add(label4);
            tabFilmScheduleDetail.Controls.Add(txtFilmScheduleStartime);
            tabFilmScheduleDetail.Controls.Add(label3);
            tabFilmScheduleDetail.Location = new Point(4, 24);
            tabFilmScheduleDetail.Name = "tabFilmScheduleDetail";
            tabFilmScheduleDetail.Padding = new Padding(3);
            tabFilmScheduleDetail.Size = new Size(792, 380);
            tabFilmScheduleDetail.TabIndex = 1;
            tabFilmScheduleDetail.Text = "FilmScheduleDetail";
            tabFilmScheduleDetail.UseVisualStyleBackColor = true;
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cbRoom.Location = new Point(149, 32);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(161, 23);
            cbRoom.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Room";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbMovie);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 3;
            // 
            // lbMovie
            // 
            lbMovie.AutoSize = true;
            lbMovie.Location = new Point(12, 13);
            lbMovie.Name = "lbMovie";
            lbMovie.Size = new Size(78, 15);
            lbMovie.TabIndex = 0;
            lbMovie.Text = "FilmSchedule";
            // 
            // FilmScheduleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabFilmScheduleControl);
            Controls.Add(panel1);
            Name = "FilmScheduleView";
            Text = "CinemaView";
            tabFilmScheduleList.ResumeLayout(false);
            tabFilmScheduleList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabFilmScheduleControl.ResumeLayout(false);
            tabFilmScheduleDetail.ResumeLayout(false);
            tabFilmScheduleDetail.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbMovie;
        private Button btnCloseFilmScheduleDetail;
        private Label lbMovieGenre;
        private Button btnSaveFilmSchedule;
        private MaskedTextBox txtFilmScheduleDate;
        private Label label4;
        private MaskedTextBox txtFilmScheduleStartime;
        private Label label3;
        private TabPage tabFilmScheduleList;
        private Button btnDeleteFilmSchedule;
        private Button btnEditFilmSchedule;
        private Button btnAddNewFilmSchedule;
        private DataGridView dataGridView1;
        private Button btnSearchFilmSchedule;
        private TextBox txtSearchMovie;
        private Label lbSearchMovie;
        private TabControl tabFilmScheduleControl;
        private TabPage tabFilmScheduleDetail;
        private Panel panel1;
        private Label lbMovie;
        private ComboBox cbRoom;
        private Label label2;
    }
}