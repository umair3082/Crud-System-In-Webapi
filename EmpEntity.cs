using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Validations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class EmpEntity
    {
        [Key]
        public int empid { get; set; }
        [FirstLetterUpperCase]
        public string name { get; set; }
        public string address { get; set; }
        public string Phone { get; set; }
    }
}
