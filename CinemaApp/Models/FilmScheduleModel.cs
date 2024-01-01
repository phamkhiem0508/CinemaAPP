using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace CinemaApp.Models
{
    public class FilmScheduleModel
    {
        [DisplayName("Film Schedule ID")]
        public int Id { get; set; }

        [DisplayName("Movie ID")]
        [Required(ErrorMessage = "Movie ID is required")]
        public int MovieId { get; set; }

        [DisplayName("Cinema ID")]
        [Required(ErrorMessage = "Cinema ID is required")]
        public int CinemaId { get; set; }

        [DisplayName("Date")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [DisplayName("Start Time")]
        [Required(ErrorMessage = "Start Time is required")]
        public string StartTime { get; set; }

        [DisplayName("End Time")]
        [Required(ErrorMessage = "End Time is required")]
        public string EndTime { get; set; }
        public MovieModel Movie { get; set; }

    }
}
