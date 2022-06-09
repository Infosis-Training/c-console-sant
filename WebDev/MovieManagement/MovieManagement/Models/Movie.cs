namespace MovieManagement.Models
{
    public class Movie
    {
        public string Name { get; set; } = "";
        public string Desc { get; set; } = "";
        public string Code { get; set; } = "";
        public string Genre { get; set; } = "";
        public DateTime ReleaseDate { get; set; }
        public float Length { get; set; }
    }
}
