using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DataAccess.Providers.SqlEntityFramework.Models
{
    [Table("New")]
    public class NewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string H2 { get; set; }
        public ICollection<LisModel> Lis { get; set; }
    }
}
