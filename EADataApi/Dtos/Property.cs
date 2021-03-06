using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EADataApi.Dtos
{
    [Table("Properties")]
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;
        public double Price { get; set; } = 0F;
        public string Area { get; set; } = String.Empty;
        public string Link { get; set; } = String.Empty;
        public int Deposit { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
