using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolarCape.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }


        [Required]
        [Display(Name = "Employee Number")]
        public int EmployeeNumber { get; set; }


        [Required]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Mobile Phone")]
        public string PhoneNumber { get; set; }


        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}