using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number10
{
    class Program
    {
        static void Main(string[] args)
        {
            string Game_Continue = "";

                string selected_Category = "";
              int counter = 0;
               
            Console.WriteLine("Welcome to the Movie List Appliction");
              Console.WriteLine();
              Console.WriteLine();
              Console.WriteLine($"There are  100 movies in the list ");




                  
                
        Movie Display = new Movie("", "");
            do
            {
                Console.WriteLine("What category are you intrested in  ");
                Console.WriteLine("Select a  number from the  category \n\n 1-Animated \n 2-Drama \n 3-horror\n 4-scifi \n 5-Musical\n6-Comedy");

                //selected_Category = Console.ReadLine();
                Display.DisplaySelectedMovies(Console.ReadLine());
                Game_Continue = Console.ReadLine().ToLower();

            } while (Game_Continue == "y");









        }

    }
}

    

        
    

