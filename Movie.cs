using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number10
{
    public class Movie
    {

      
        private string Title = "";
        private string Movie_Category = "";
        public Movie(string title, string movie_Category)
        {
            Title = title;
            Movie_Category = movie_Category;
        }
       public string GetTitle()
        {
            return Title;
        }
        public string GetCategory()
        {
            return Movie_Category;
        }
        
        
        public void DisplaySelectedMovies(string selected_Category)
        {
             
            int counter = 0;
         
            List<Movie> MovieList = MovieIO.default_MovieCatalog;
           
            switch (selected_Category)
            {
                case "1":
                    selected_Category = "animated";
                    Console.WriteLine($"Here are the Movie List  {selected_Category}");
                    break;
                case "2":
                    selected_Category = "drama";
                    break;
                case "3":
                    selected_Category = "horror";
                    break;
                case "4":
                    selected_Category = "scifi";
                    break;
                case "5":
                    selected_Category = "comedy";
                    break;
                case "6":
                    selected_Category = "musical";
                    break;
                default:
                    Console.WriteLine("You entered wrong category.Please select valid number");
                    break;

            }




            foreach (Movie m in MovieList.OrderBy(m => m.GetTitle()))
            {


                if (selected_Category == m.GetCategory())
                {
                    counter++;

                    // counter++;
                    Console.WriteLine("Title" + "   " + m.GetTitle());
                    if (counter == 10) break;


                }

            }

            Console.WriteLine("continue?(y/n):");
          



        }

    }
}


        
        


        

