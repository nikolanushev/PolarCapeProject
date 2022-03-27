using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolarCape.Models
{
    public class Project
    {
        [Key]
        [Required]
        public int ProjectId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public IEnumerable<SelectListItem> Client { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public IEnumerable<SelectListItem> Employee { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}