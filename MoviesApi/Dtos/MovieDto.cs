﻿using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Dtos
{
    public class MovieDto
    {
        [MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }
        [MaxLength(2500)]
        public string StoreLine { get; set; }
        public IFormFile? Poster { get; set; }

        public int GenreId { get; set; }

        //public string GenreName { get; set; }
    }
}