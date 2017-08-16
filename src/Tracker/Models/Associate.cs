using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Tracker.Models
{
    [Table("Associates")]
    public class Associate
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SalesTotal { get; set; }
    }
}
