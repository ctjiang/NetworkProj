using System;

namespace MVC_Razor.Models
{
    public class Movie
    {
        public int ID {get; set;}
        public string Title {get; set;}
        public DateTime ReleaseDate {get; set;}
        public string Gere {get; set;}
        public decimal Price {get; set;}
    }
}