using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Razor.Models;

namespace MVC_Razor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MVC_Razor.Models.MovieContext _context;

        public IndexModel(MVC_Razor.Models.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }
        public SelectList Genres;
        public string MovieGenre {get; set;}

        public async Task OnGetAsync(string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movies
                                            orderby m.Gere
                                            select m.Gere;

            var movies = from m in _context.Movies
                         select m;
            
            if(!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync(); //_context.Movies.ToListAsync();
        }
    }
}
