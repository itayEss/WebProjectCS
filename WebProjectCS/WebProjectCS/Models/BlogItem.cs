using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebProjectCS.Models
{
    public class BlogItem
    {
        [Key]
        public int BlogItemID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; } = new DateTime();

        [Required(ErrorMessage = "ConversationID is not Defined.")]
        public int ConvID { get; set; }

        [Required(ErrorMessage = "UID is required.")]
        public int UID { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        public string Message{ get; set; }

        public int RelatedID { get; set; } = -1;
    }
}
