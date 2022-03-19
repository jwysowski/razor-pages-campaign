using System.ComponentModel.DataAnnotations;

namespace RazorPagesCampaign.Models {
    public class Campaign {
        public int Id {get; set;}
        public string Name {get; set;} = string.Empty;
        // public string[] Keywords {get; set;} = new string[5];
        public decimal BidAmount {get; set;}
        public bool Status {get; set;} = false;
        public string Town {get; set;} = string.Empty;
        public decimal Radius {get; set;}
    }
}