using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VerklegtNamskeid.Models
{
    public class UserAccount
    {
        [Key]
        public int _userID { get; set; }
        [Required(ErrorMessage = "Please insert a username")]
        public string _userName { get; set; }
        [Required(ErrorMessage = "Please insert an email")]
        [DataType(DataType.EmailAddress)]
        public string _userEmail { get; set; }
        [Required(ErrorMessage = "Please insert a password")]
        [DataType(DataType.Password)]
        public string _userPassword { get; set; }
        [Compare("_userPassword", ErrorMessage ="Please confirm password")]
        [DataType(DataType.Password)]
        public string _userconfirmPassword { get; set; }
    }
}