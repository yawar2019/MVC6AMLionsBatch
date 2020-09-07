using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdoNetExample.Models
{
    public class Register
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password and Confirm Password is Not Same")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "EmailId is Required")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [Required]
        [Range(18,50,ErrorMessage ="Age should be between 18 to 50")]
        public int Age { get; set; }
        [StringLength(20,ErrorMessage ="More then 20 Character we can't Enter Address")]
        public string Address { get; set; }

    }
}