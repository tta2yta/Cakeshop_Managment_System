using Microsoft.AspNetCore.Mvc;
using OnlineCakeShop.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCakeShop.Model
{
    public class Pie
    {
        public int PieId { get; set; }
        [Remote("CheckIfPieNameAlreadyExists", "PieManagement", ErrorMessage = "That name already exists")]
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        /*  public string ImageUrl { get; set; }
          public string ImageThumbnailUrl { get; set; }*/
        [ValidUrl(ErrorMessage = "That's not a valid URL")]
        public string ImageUrl { get; set; }

        [ValidUrl(ErrorMessage = "That's not a valid URL")]
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public  List<PieReview> PieReviews { get; set; }
        public SugarLevel SugarLevel { get; }
    }
}
