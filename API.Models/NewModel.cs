using API.Common.Model;

namespace API.Models
{
    public class NewModel : ModelBase
    {
        public string Title { get; set; }
        public string H2 { get; set; }
        public string[] Lis { get; set; }
    }
}