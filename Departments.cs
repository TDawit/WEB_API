using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    [Table("Departmnt")]
    public class Departments
    {
        [Key]
        public int Did { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
