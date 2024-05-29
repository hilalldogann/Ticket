﻿using System.ComponentModel.DataAnnotations;

namespace Ticket.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage ="Email adress is required")]

        public string EmailAddress {  get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }    
    }
}
