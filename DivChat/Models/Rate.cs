using System.ComponentModel.DataAnnotations;

namespace DivChat.Models
{
    public class Rate
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 5)]
        public int Stars { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}