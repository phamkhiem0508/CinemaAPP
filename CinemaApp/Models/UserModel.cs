using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CinemaApp.Models
{
    public class UserModel
    {
        private int id;
        private string username;
        private string password;

        [DisplayName("User ID")]
        public int Id { get => this.id; set => this.id = value; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username can't be longer than 50 characters")]
        public string Username { get => this.username; set => this.username = value; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password can't be longer than 50 characters")]
        public string Password { get => this.password; set=> this.password = value; }

        public UserModel(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
