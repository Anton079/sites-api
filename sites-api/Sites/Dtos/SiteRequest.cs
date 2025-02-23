using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sites_api.Sites.Dtos
{
    public class SiteRequest
    {

       
        public string Type { get; set; }

      
        public int PageNumber { get; set; }

       
        public int Price { get; set; }
    }
}
