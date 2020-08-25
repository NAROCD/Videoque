using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Videoque.Models;

namespace Videoque.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter movie name.")]
        public string Name { get; set; }
        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please select movie genre.")]
        public byte? GenreId { get; set; }


        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please enter Release date.")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required(ErrorMessage = "The field Number in Stock must be between 1 and 20.")]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }


        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

    }
}