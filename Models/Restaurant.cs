using System.ComponentModel.DataAnnotations;

namespace AYAlab12.Models
{
    public class Restaurant
    {
        // Id - первичный ключ для ДБ
        [Key]
        public int Id { get; set; }
        // Должно быть определено - Required
        [Required]
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Rating { get; set; }
    }
}
