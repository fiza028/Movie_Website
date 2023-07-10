using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movieplayingwebsite.Models.Domain;
using Movieplayingwebsite.Repositories.Abstract;
using Movieplayingwebsite.Repositories.Implement;


namespace Movieplayingwebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
       private readonly IHttpContextAccessor contxt;
        
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(IMovieService movieService,
IHttpContextAccessor HttpContextAccessor,            UserManager<ApplicationUser> userManager)
        {
            _movieService = movieService;
            this.contxt = HttpContextAccessor;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string term = "", int currentPage = 1)

        {
            //ApplicationUser crntuser = await _userManager.GetUserAsync(User);//this is used to get the current user

             //contxt.HttpContext.Session.SetString("Username", crntuser.Name);
            //contxt.HttpContext.Session.SetString("Username", "fiza");
            //contxt.HttpContext.Session.GetString("Username");//this is used to get session from userauth..service
            var movies = _movieService.List(term, true, currentPage);
            return View(movies);
        
        
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult MovieDetail(int movieId)
        {
            var movie = _movieService.GetById(movieId);
            return View(movie);
        }
        
        public IActionResult MoviePlay(int id)
        {
            var movie = _movieService.GetById(id);
            return View(movie);
        }

    }
}