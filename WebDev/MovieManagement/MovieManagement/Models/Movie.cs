namespace MovieManagement.Models
{
    public class Movie
    {
        public string Name { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        public DateTime ReleaseDate { get; set; }

        public float Length { get; set; }
    }
}
