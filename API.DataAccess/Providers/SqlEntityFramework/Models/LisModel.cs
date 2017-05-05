using System.ComponentModel.DataAnnotations.Schema;

namespace API.DataAccess.Providers.SqlEntityFramework.Models
{
    [Table("Lis")]
    public class LisModel
    {
        public int ID { get; set; }
        public int NewID { get; set; }
        [Column("lis")]
        public string LisItem { get; set; }

        [ForeignKey("NewID")]
        public NewModel NewModel { get; set; }
    }
}
