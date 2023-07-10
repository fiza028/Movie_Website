using Movieplayingwebsite.Models.Domain;

namespace Movieplayingwebsite.Models.DTO
{
    public class MovieListVm
    {
        public IQueryable<Movie> MovieList{ get; set; }

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }

        public string? Term { get; set; }
    }
}
