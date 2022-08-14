using System.ComponentModel.DataAnnotations;

namespace davesPub.Models
{
    public class mainPageItem
    {
        public int Id { get; set; }
        public string imgLink { get; set; }
        public string title { get; set; }
        public string linkToPage { get; set; }
    }
}
