using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjectCS.Models
{
    public class ConvBlogItem
    {
        [Key]
        public int ConvBlogItemID { get; set; }

        [Required(ErrorMessage = "Converation Name is Required.")]
        public string ConvName { get; set; }

        [Required(ErrorMessage = "Converation Creator Name is Required.")]
        public string ConvCreatorName { get; set; }
    }
}
