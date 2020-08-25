using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videoque.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter movie name.")]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please select movie genre.")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please enter Release date.")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required(ErrorMessage = "The field Number in Stock must be between 1 and 20.")]
        public byte NumberInStock { get; set; }
    }
}