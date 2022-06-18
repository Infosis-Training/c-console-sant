using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;

namespace ImageProcesser.Pages
{
    public class IndexModel : PageModel
    {
        public string CurrentTime { get; set; } = string.Empty;

        public IFormFile File { get; set; }

        public void OnGet()
        {
            CurrentTime =$"{DateTime.Now}";
        }

        public void OnPost()
        {
            imageRotate();
        }

        public void imageRotate()
        {

            var ImageName = File.FileName;

            Stream imageStream = new MemoryStream();

            File.CopyTo(imageStream);

            Bitmap bitmap = new Bitmap(imageStream);

            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);

            var filePath = Path.Combine(Directory.GetCurrentDirectory(),@"wwwroot\images", File.FileName+"rorate.jpg");
            
            bitmap.Save(filePath);

        }
    }
}