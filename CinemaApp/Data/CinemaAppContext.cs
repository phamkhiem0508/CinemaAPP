using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Data
{
    public class CinemaAppContext : DbContext
    {

        public DbSet<MovieModel> Movies { get; set; } = null;

        public DbSet<UserModel> Users { get; set; } = null;

        public DbSet<FilmScheduleModel> FilmSchedules { get; set; } = null;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-R8D9BDH\SQLEXPRESS;Initial Catalog=CinemaApp; User ID=sa;Password=khiem123;TrustServerCertificate=True");
        }
    }
}
