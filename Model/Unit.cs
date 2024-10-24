using System.ComponentModel.DataAnnotations;

namespace task.Model
{
    public class Unit
    {
        [Key]
        public int unitNo { get; set; }
        [MaxLength(100)]
        public string unitName { get; set; }

        public Unit(string unitName)
        {
            this.unitName = unitName;
        }
    }
}
