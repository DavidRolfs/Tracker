using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Tracker.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public int TransactionId { get; set; }
        public virtual Transaction Transaction { get; set; }

    }
}