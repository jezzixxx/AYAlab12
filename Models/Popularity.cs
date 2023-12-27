using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AYAlab12.Models
{
    public class Popularity
    {
        [Key]
        public int Id { get; set; }
        public int CommentsCount { get; set; }
        public int GuestsPerDay { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
    }
}
