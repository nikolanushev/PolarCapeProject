using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PolarCape.Models
{
    public class Client
    {
        [Key]
        [Required]
        public int ClientId { get; set; }


        [Required]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Mobile Phone")]
        public string PhoneNumber { get; set; }


        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }


        [Required]
        public string Company { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}