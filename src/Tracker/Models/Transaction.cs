using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Tracker.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public int AssociateId { get; set; }
        public virtual Associate Associate { get; set; }
        public int InventoryId { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
