using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TrainingDbContextDataContext dataContext = new TrainingDbContextDataContext();
            //var empQuery = (from emp in dataContext.Employees select emp).ToList();

            //foreach (Employee e in empQuery)
            //{
            //    Console.WriteLine(e.EmpId + "," + e.FirstName + "," + e.LastName + "," + e.JoiningDate + "," + e.Age);
            //}

            //Employee employee = new Employee { EmpId = 250, FirstName = "Andy", LastName = "Jones", Age = 25, JoiningDate = new DateTime(2020, 12, 11) };
            //dataContext.Employees.InsertOnSubmit(employee);
            //dataContext.SubmitChanges();

            int[] numbers = { 2, 5, 7, 12, 17, 20 };

            var numQuery = from num in numbers
                           where num % 2 == 0
                           select num;

            var numQuery1 = numbers.Where(e => e % 2 == 0);

            foreach (int n in numQuery1)
            {
                Console.WriteLine(n);
            }

            List<Movie> movieList = new List<Movie>
            {
                new Movie{Title="Shashank Redemption",Genre="Drama",Year=1994 },
                new Movie{Title="The Godfather",Genre="Crime", Year=1972},
                new Movie{Title="Schindler's List",Genre="Drama", Year=1993},
                new Movie{Title="The DarkNight",Genre="Action", Year=2000},
                new Movie{Title="The Lord of the Rings",Genre="Adventure", Year=2003},
            };

            var movieQuery2 = movieList.GroupBy(e => e.Genre);
            var movieQuery3 = movieList.OrderBy(emp => emp.Title).ThenBy(emp=>emp.Year).GroupBy(e=>e.Genre);

            foreach (var movie in movieQuery3)
            {
                Console.WriteLine(movie.Key);
                foreach (var m in movie)
                {
                    Console.WriteLine(" "+m.Title+" "+m.Year+" ");
                }
            }
            

            var movieQuery4 = from movie in movieList
                              orderby movie.Title
                              group movie by movie.Genre;

            var movieQuery1 = from movie in movieList
                              group movie by movie.Genre;


            //var joinQuery = from m in movieList
            //                join n in movieList
            //                on m.Title = n.Title
            //                select new { Title = m.Title, ReleaseYear = n.Year };
        
            //foreach(var movie in joinQuery)
            //{
            //    Console.WriteLine(movie.Title+","+movie.ReleaseYear);
            //}
        
        }
    }
}
