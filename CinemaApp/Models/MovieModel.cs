using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Schema;

namespace CinemaApp.Models
{
    public class MovieModel
    {

        private int id;
        private string title;
        private string description;
        private string image;
        private string genre;
        private string duration;
        private string releaseDate;

        [DisplayName("Movie ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Movie Title")]
        [Required(ErrorMessage = "Movie Title is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Movie Title can't be longer than 50 characters")]
        public string Title { get => title; set => title = value; }

        [DisplayName("Movie Description")]
        [Required(ErrorMessage = "Movie Description is required")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Movie Description can't be longer than 500 characters")]
        public string Description { get => description; set => description = value; }
            
        //public string Image { get => image; set => image = value; }
        public string Image
        {
            get
            {
                return "https://image.tmdb.org/t/p/w500" + image;
            }
            set
            {
                image = value;
            }
        }

        [DisplayName("Movie Genre")]
        [Required(ErrorMessage = "Movie Genre is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Movie Genre can't be longer than 50 characters")]
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        [DisplayName("Movie Duration")]
        [Required(ErrorMessage = "Movie Duration is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Movie Duration can't be longer than 50 characters")]
        public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }

        [DisplayName("Movie Release Date")]
        [Required(ErrorMessage = "Movie Release Date is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Movie Release Date can't be longer than 50 characters")]
        public string ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                releaseDate = value;
            }
        }

        public ICollection<FilmScheduleModel> ?FilmScheduleModels { get; set; }
    }
}
