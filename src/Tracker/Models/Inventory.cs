using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tracker.Models
{
    [Table("Inventory")]
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public bool Availability { get; set; }
    }
}