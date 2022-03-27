using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PolarCape.Models
{
    public class ProjectClientEmployee
    {
        public List<Employee> Employees { get; set; }
        public List<Client> Client { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
    }
}