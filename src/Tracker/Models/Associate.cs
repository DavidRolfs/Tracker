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

        public override bool Equals(System.Object otherItem)
        {
            if (!(otherItem is Associate))
            {
                return false;
            }
            else
            {
                Associate newItem = (Associate)otherItem;
                return this.Id.Equals(newItem.Id);
            }
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
