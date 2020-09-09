using System;

namespace Lab11_5Submittal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
namespace _11_5_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            SakilaContext sakila = new SakilaContext();
            Film war1917 = new Film("1917", "2019 War Drama By Director Sam Mendes", "2019", 3, 5.99m, 179, 19.99m, "R");
            Film joker = new Film("Joker", "Oscar-Nominated SuperHero Drama", "2019", 3, 6.99m, 182, 23.99m, "R");
            Film jarjarAbrams = new Film("Star Wars: The Rise of SkyWalker", "Trash Disney Fanfic", "2019", 3, 4.99m, 202, 21.99m, "PG-13");

            sakila.Film.Add(war1917);  //uncomment these lines to insert the film
            sakila.Film.Add(joker);  // uncomment these lines to insert the film
            sakila.Film.Add(jarjarAbrams); //uncomment these lines to insert the film
            sakila.SaveChanges();

            //Get All Films from the Sakila DB


            Film[] allfilms = sakila.Film.ToArray();
            //Film[] allfilms = (from db in sakila.Film
            //                   select new Film(db.title, db.description, db.release_year, db.rental_duration, db.rental_rate, db.length, db.replacement_cost, db.rating)).ToArray();

            //Filter to get the new 2019 films you added
            var newfilms = allfilms.Where(x => x.release_year == "2019");

            StringBuilder html = new StringBuilder();
            html.Append("<html>\n");
            html.Append("  <head>");
            html.Append("    <title>Sakila New Films</title>\n");
            html.Append("  </head>\n");
            html.Append("  <body\n");
            html.Append("    <h1> New Films Coming Soon! </h1>\n");
            html.Append("      <ul>\n");
            foreach (var film in newfilms)
            {
                html.Append("<li>");
                html.Append(film.title + " " + film.description);
                html.Append("</li>");
            }


            html.Append("      </ul>\n");
            html.Append("  </body>\n");
            html.Append("</html>\n");

            string htmlFile = "D:\\output\\newfilms.html";
            File.WriteAllText(htmlFile, html.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _11_5_Solution
{
    class Film
    {
        [Key]
        public int film_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string release_year { get; set; }
        public byte language_id { get; set; }
        public byte original_language_id { get; set; }
        public byte rental_duration { get; set; }
        public decimal rental_rate { get; set; }
        public Int16 length { get; set; }
        public decimal replacement_cost { get; set; }
        public string rating { get; set; }
        public string special_features { get; set; }
        public DateTime last_update { get; set; }

        public Film(string title, string description, string release_year, byte rental_duration,
            decimal rental_rate, Int16 length, decimal replacement_cost, string rating)
        {
            this.title = title;
            this.description = description;
            this.release_year = release_year;
            this.rental_duration = rental_duration;
            this.rental_rate = rental_rate;
            this.length = length;
            this.replacement_cost = replacement_cost;
            this.rating = rating;

            special_features = "Trailers";
            last_update = DateTime.Now;
            language_id = 1;
            original_language_id = 1;

        }

    }
}


using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using System.Text;

namespace _11_5_Solution
{
    class SakilaContext : DbContext
    {

        public DbSet<Film> Film { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost\sqlexpress;Database=sakila;Trusted_Connection=True;")
;
        }
    }
}


