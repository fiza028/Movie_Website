using Movieplayingwebsite.Models.Domain;
using Movieplayingwebsite.Models.DTO;

namespace Movieplayingwebsite.Repositories.Abstract
{
    public interface IMovieService
    {
        bool Add(Movie model);
        bool Update(Movie model);
        Movie GetById(int id);

        bool Delete(int id);
            
        MovieListVm List(string term="", bool paging = false, int crntPgae = 0); //return a list of genre
        //term is used to search

        List<int> GetGenreByMovieId(int movieId);
    }
}
