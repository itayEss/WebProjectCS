using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebProjectCS.Models.Managment
{
    public class UserAcccount
    {
        [Key]
        public int UId { get; set; } // user id
        
        [Required(ErrorMessage ="First Name is required.")]
        public string FirstName { get; set; } // User first Name

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; } // User Last Name

        [Required(ErrorMessage = "Email is Invalid, Re-Enter your email address.")] 
        [DataType(DataType.EmailAddress)] // Validate Email address
        public string Email { get; set; } // User Email

        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; set; } // User UserName

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } // User Password

        [Compare("Password",ErrorMessage = "Please Vlidate your Password")]
        [DataType(DataType.Password)]   
        public string ConfirmPassword { get; set; } // ConfirmPassword

        public int UPriv { get; set; } = 0 ;
    }
}
