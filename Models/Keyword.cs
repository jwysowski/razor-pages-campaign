using System.ComponentModel.DataAnnotations;

namespace RazorPagesCampaign.Models {
    public class Keyword {
        public int Id {get; set;}
        public string Name {get; set;} = string.Empty;
    }
}