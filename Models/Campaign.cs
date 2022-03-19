using System.ComponentModel.DataAnnotations;

namespace RazorPagesCampaign.Models {
    public class Campaign {
        public int Id {get; set;}
        
        [Required]
        public string Name {get; set;} = string.Empty;
        
        [Required]
        public List<Keyword> Keywords {get; set;} = new List<Keyword>();
        
        [Required]
        public decimal BidAmount {get; set;}
        
        [Required]
        public bool Status {get; set;} = false;
        public string Town {get; set;} = string.Empty;
        
        [Required]
        public decimal Radius {get; set;}
    }
}