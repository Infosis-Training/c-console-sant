using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Models
{
    public class Movie
    {
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
        [Range(0, int.MaxValue)]
        public int Length { get; set; } = int.MinValue;

        [Display(Name = "Upload Banner")]
        public string ImgUrl { get; set; } = "";
    }
}
