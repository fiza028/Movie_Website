using Movieplayingwebsite.Models.Domain;
using Movieplayingwebsite.Models.DTO;

namespace Movieplayingwebsite.Repositories.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update(Genre model);
        Genre GetById(int id);

        bool Delete(int id);
            
        IQueryable<Genre> List(); //return a list of genre
    }
}
