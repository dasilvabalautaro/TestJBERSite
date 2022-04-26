using System.ComponentModel.DataAnnotations.Schema;

namespace TestJBERSite.Models
{
    public class Song
    {
        public int ID { get; set; }
        public int IdArtist { get; set; }
        public string Title { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(6,2)")]
        public decimal Duration { get; set; }
        public int Popularity { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
