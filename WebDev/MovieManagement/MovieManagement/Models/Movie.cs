﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3,ErrorMessage ="Name must be atleast 3 Char.")]
        public string Name { get; set; } = "";

        [DisplayName("Movie Brief Details")]
        public string Desc { get; set; } = "";
        public string Code { get; set; } = "";

        [DisplayName("Choose Genre")]
        public string Genre { get; set; } = "";

        [DataType(DataType.Date)]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        [DisplayName("Movie Length (in Minute)")]
        public int Length { get; set; }

        [Display(Name = "Upload Banner")]
        public string? ImgUrl { get; set; } = "Default.JPG";
    }
}
