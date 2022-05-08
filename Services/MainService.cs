using ApplicationTemplate.Context;
using ApplicationTemplate.DataModels;

using System;
using System.Linq;

namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{

     
    

    public void Invoke()
    {
        var db = new MovieContext();
        /*
        

        System.Console.WriteLine("Enter NEW User Name: ");
        var user2 = Console.ReadLine();

        using (db = new MovieContext())
        {
            var occupation = new Occupation()
            {
                Name = user2
            };
            db.Occupations.Add(occupation);
            db.SaveChanges();

            var newOccupation = db.Users.FirstOrDefault(x => x.Name == user2);
            System.Console.WriteLine($"({Users.Id}) {newOccupation.Name}");
        }

        // New occupation
        System.Console.WriteLine("Enter NEW Occupation Name: ");
        var occ2 = Console.ReadLine();

        using ( db = new MovieContext())
        {
             var occupation = new Occupation() {
                 Name = occ2
             };
             db.Occupations.Add(occupation);
             db.SaveChanges();

             var newOccupation = db.Occupations.FirstOrDefault(x => x.Name == occ2);
             System.Console.WriteLine($"({newOccupation.Id}) {newOccupation.Name}");
         }*/
        

        string choice;

        Console.WriteLine("1) Search/view Movies");
        Console.WriteLine("2) Add Movies");
        Console.WriteLine("3) Update Movies");
        Console.WriteLine("4) Delete Movies");
        choice = Console.ReadLine();




        if (choice == "1")
        {
            


            //Search Movies in database
            Console.WriteLine("Enter the Movie Title you wish to view ");
            var MovieSearch = Console.ReadLine();
            var movie_Search = db.Movies.Where(x => x.Title.Contains(MovieSearch));
            foreach (var movie in movie_Search)
            {
                Console.WriteLine($"\tMovie: {movie.Id} {movie.Title}");
            }
            
         //  Console.WriteLine(movie_Search.FirstOrDefault()); 
            System.Console.WriteLine($"{movie_Search.Count()} Movies with this keyword");

        }
        else if (choice == "2")
        {
            // Create and save a new Movie
            Console.Write("Enter a title for a new Movie: ");
            var Title = Console.ReadLine();
       //     Console.WriteLine("How many genres does it contain?");
       //     var genreNum = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What is the genre ? Enter the correct Id...");
        //    string[] genreAr = new string[genreNum];
            var GenreList = db.Genres.OrderBy(g => g.Id);
            foreach (var item in GenreList)
            {
                Console.WriteLine($"\tGenre: {item.Id} {item.Name}");
            }
            var genreIDinput = Convert.ToInt64(Console.ReadLine());
            //loop for multiple genres
            /*
            for (int i = 0; i < genreNum; i++)
            {
                Console.WriteLine("Genre (" + (i + 1) + ")");
                var movieGenre = Console.ReadLine();
                genreAr[i] = movieGenre;


            }
            var GenresString = string.Join('|', genreAr);
*/
            var movie = new Movie { Title = Title  };
            var genretype = new Genre { Id = genreIDinput };
            
            using (db = new MovieContext())
            {
                db.Movies.Add(movie);
                
           //      logger.Info("Blog added - {name}", Title);
                db.SaveChanges();
           //     var moviegenre = new MovieGenre { Genre = genreIDinput, Movie = movie  };
            //    db.MovieGenres.Add(moviegenre);
             //   db.SaveChanges();
            }

        }
        else if (choice == "3")
        {
            //update
            Console.WriteLine("Enter the Id for the Movie you wish to update: ");
            var updateMovieS = Convert.ToInt32(Console.ReadLine());

            var update_Search = db.Movies.Where(u => u.Id == updateMovieS);

            foreach (var movie in update_Search)
            {
                Console.WriteLine($"\tMovie: {movie.Id} {movie.Title} was selected");
            }

            Console.WriteLine("Enter the title of this updated movie: ");
            var updatedtitle = Console.ReadLine();

            var movieU = new Movie { Id = updateMovieS, Title = updatedtitle };

            using (db = new MovieContext())
            {
                db.Movies.UpdateRange(movieU);
                db.SaveChanges();
                Console.WriteLine(updatedtitle, " Has replaced the existing title");
            }

        }
        else if (choice == "4")
        {
            //delete
            Console.WriteLine("Enter the Id for the Movie you wish to delete: ");
            var deletion = Convert.ToInt32(Console.ReadLine());
            var movietodelete = db.Movies.Where(d => d.Id == deletion);
            var movie = movietodelete;
            using (db = new MovieContext())
            {
                db.Movies.RemoveRange(movie);

                //     logger.Info("Movie Deleted - {name}", Title);
                db.SaveChanges();
                

            }
        }













    }
}
