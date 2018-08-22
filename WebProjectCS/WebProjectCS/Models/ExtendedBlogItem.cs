using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebProjectCS.Models
{
    public class ExtendedBlogItem : BlogItem
    {
        public string UName { get; set; }
    }
}
