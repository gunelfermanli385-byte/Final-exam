using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class Product:BaseModel
    {
        [Required,MaxLength(50)]
        public string Title { get; set; }
        [Required, MaxLength(50)]
        public string Description { get; set; }
        [Required, MaxLength(50)]
        public string ImageUrl { get; set; }

    }
}
